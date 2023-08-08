bug_aranges  0 : { *(.debug_aranges) }
  .debug_pubnames 0 : { *(.debug_pubnames) }
  /* DWARF 2 */
  .debug_info     0 : { *(.debug_info) }
  .debug_abbrev   0 : { *(.debug_abbrev) }
  .debug_line     0 : { *(.debug_line .debug_line.* .debug_line_end ) }
  .debug_frame    0 : { *(.debug_frame) }
  .debug_str      0 : { *(.debug_str) }
  .debug_loc      0 : { *(.debug_loc) }
  .debug_macinfo  0 : { *(.debug_macinfo) }
  /* SGI/MIPS DWARF 2 extensions */
  .debug_weaknames 0 : { *(.debug_weaknames) }
  .debug_funcnames 0 : { *(.debug_funcnames) }
  .debug_typenames 0 : { *(.debug_typenames) }
  .debug_varnames  0 : { *(.debug_varnames) }
  /* DWARF 3 */
  .debug_pubtypes 0 : { *(.debug_pubtypes) }
  .debug_ranges   0 : { *(.debug_ranges) }
  /* DWARF Extension.  */
  .debug_macro    0 : { *(.debug_macro) }
  .debug_addr     0 : { *(.debug_addr) }
  .gnu.attributes 0 : { KEEP (*(.gnu.attributes)) }
}

       /* Script for ld -r: link without relocation */
/* Copyright (C) 2014-2016 Free Software Foundation, Inc.
   Copying and distribution of this script, with or without modification,
   are permitted in any medium without royalty provided the copyright
   notice and this notice are preserved.  */
OUTPUT_FORMAT("elf64-k1om", "elf64-k1om",
	      "elf64-k1om")
OUTPUT_ARCH(k1om)
 /* For some reason, the Solaris linker makes bad executables
  if gld -r is used and the intermediate file has sections starting
  at non-zero addresses.  Could be a Solaris ld bug, could be a GNU ld
  bug.  But for now assigning the zero vmas works.  */
SECTIONS
{
  /* Read-only sections, merged into text segment: */
  .interp       0 : { *(.interp) }
  .note.gnu.build-id : { *(.note.gnu.build-id) }
  .hash         0 : { *(.hash) }
  .gnu.hash     0 : { *(.gnu.hash) }
  .dynsym       0 : { *(.dynsym) }
  .dynstr       0 : { *(.dynstr) }
  .gnu.version  0 : { *(.gnu.version) }
  .gnu.version_d 0: { *(.gnu.version_d) }
  .gnu.version_r 0: { *(.gnu.version_r) }
  .rela.init    0 : { *(.rela.init) }
  .rela.text    0 : { *(.rela.text) }
  .rela.fini    0 : { *(.rela.fini) }
  .rela.rodata  0 : { *(.rela.rodata) }
  .rela.data.rel.ro 0 : { *(.rela.data.rel.ro) }
  .rela.data    0 : { *(.rela.data) }
  .rela.tdata	0 : { *(.rela.tdata) }
  .rela.tbss	0 : { *(.rela.tbss) }
  .rela.ctors   0 : { *(.rela.ctors) }
  .rela.dtors   0 : { *(.rela.dtors) }
  .rela.got     0 : { *(.rela.got) }
  .rela.bss     0 : { *(.rela.bss) }
  .rela.ldata   0 : { *(.rela.ldata) }
  .rela.lbss    0 : { *(.rela.lbss) }
  .rela.lrodata 0 : { *(.rela.lrodata) }
  .rela.ifunc   0 : { *(.rela.ifunc) }
  .rela.plt     0 :
    {
      *(.rela.plt)
    }
  .init         0 :
  {
    KEEP (*(SORT_NONE(.init)))
  }
  .plt          0 : { *(.plt) *(.iplt) }
