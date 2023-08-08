s for native code support. */
STDAPI MonoFixupExe(HMODULE ModuleHandle)
{
	IMAGE_DOS_HEADER* DosHeader;
	IMAGE_NT_HEADERS* NtHeaders;
	DWORD_PTR* Address;
	DWORD OldProtect;
	DWORD_PTR BaseDiff;

	DosHeader = (IMAGE_DOS_HEADER*)ModuleHandle;
	if (DosHeader == NULL)
		return E_POINTER;

	if (DosHeader->e_magic != IMAGE_DOS_SIGNATURE)
		return E_INVALIDARG;

	NtHeaders = (IMAGE_NT_HEADERS*)((DWORD_PTR)DosHeader + DosHeader->e_lfanew);
	if (NtHeaders->Signature != IMAGE_NT_SIGNATURE)
		return E_INVALIDARG;

	if (NtHeaders->OptionalHeader.Magic != IMAGE_NT_OPTIONAL_HDR_MAGIC)
		return E_INVALIDARG;

	if (NtHeaders->FileHeader.Characteristics & IMAGE_FILE_DLL)
		return S_OK;

	if (NtHeaders->OptionalHeader.NumberOfRvaAndSizes > IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR)
	{
		IMAGE_DATA_DIRECTORY* CliHeaderDir;
		MonoCLIHeader* CliHeader;

		CliHeaderDir = &NtHeaders->OptionalHeader.DataDirectory[IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR];
		if (CliHeaderDir->VirtualAddress)
		{
			CliHeader = (MonoCLIHeader*)((DWORD_PTR)DosHeader + CliHeaderDir->VirtualAddress);
			if (CliHeader->ch_flags & CLI_FLAGS_ILONLY)
				return S_OK;
		}
	}

	BaseDiff = (DWORD_PTR)DosHeader - NtHeaders->OptionalHeader.ImageBase;
	if (BaseDiff != 0)
	{
		if (NtHeaders->FileHeader.Characteristics & IMAGE_FILE_RELOCS_STRIPPED)
			return E_FAIL;

		Address = &NtHeaders->OptionalHeader.ImageBase;
		if (!VirtualProtect(Address, sizeof(DWORD_PTR), PAGE_READWRITE, &OldProtect))
			return E_UNEXPECTED;
		*Address = (DWORD_PTR)DosHeader;
		if (!VirtualProtect(Address, sizeof(DWORD_PTR), OldProtect, &OldProtect))
			return E_UNEXPECTED;

		if (NtHeaders->OptionalHeader.NumberOfRvaAndSizes > IMAGE_DIRECTORY_ENTRY_BASERELOC)
		{
			IMAGE_DATA_DIRECTORY* BaseRelocDir;
			IMAGE_BASE_RELOCATION* BaseReloc;
			USHORT* RelocBlock;
			ULONG BaseRelocSize;
			ULONG RelocBlockSize;
			USHORT RelocOffset;
			DWORD_PTR UNALIGNED *RelocFixup;

			BaseRelocDir = &NtHeaders->OptionalHeader.DataDirectory[IMAGE_DIRECTORY_ENTRY_BASERELOC];
			if (BaseRelocDir->VirtualAddress)
			{
				BaseReloc = (IMAGE_BASE_RELOCATION*)((DWORD_PTR)DosHeader + BaseRelocDir->VirtualAddress);
				BaseRelocSize = BaseRelocDir->Size;

				while (BaseRelocSize)
				{
					RelocBlockSize = BaseReloc->SizeOfBlock;

					if (!RelocBlockSize || BaseRelocSize < RelocBlockSize)
						return E_FAIL;

					BaseRelocSize -= RelocBlockSize;
					RelocBlock = (USHORT*)((DWORD_PTR)BaseReloc + sizeof(IMAGE_BASE_RELOCATION));
					RelocBlockSize -= sizeof(IMAGE_BASE_RELOCATION);
					RelocBlockSize /= sizeof(USHORT);

					while (RelocBlockSize-- != 0)
					{
						RelocOffset = *RelocB