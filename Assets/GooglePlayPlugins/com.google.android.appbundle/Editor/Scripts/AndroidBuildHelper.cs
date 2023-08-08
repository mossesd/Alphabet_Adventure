s0 register names are selected according to
the architecture and \s-1CPU\s0 of the binary being disassembled.
.ie n .IP """hwr\-names=\f(CIARCH\f(CW""" 4
.el .IP "\f(CWhwr\-names=\f(CIARCH\f(CW\fR" 4
.IX Item "hwr-names=ARCH"
Print \s-1HWR \s0(hardware register, used by the \f(CW\*(C`rdhwr\*(C'\fR instruction) names
as appropriate for the \s-1CPU\s0 or architecture specified by
\&\fI\s-1ARCH\s0\fR.  By default, \s-1HWR\s0 names are selected according to
the architecture and \s-1CPU\s0 of the binary being disassembled.
.ie n .IP """reg\-names=\f(CIABI\f(CW""" 4
.el .IP "\f(CWreg\-names=\f(CIABI\f(CW\fR" 4
.IX Item "reg-names=ABI"
Print \s-1GPR\s0 and \s-1FPR\s0 names as appropriate for the selected \s-1ABI.\s0
.ie n .IP """reg\-names=\f(CIARCH\f(CW""" 4
.el .IP "\f(CWreg\-names=\f(CIARCH\f(CW\fR" 4
.IX Item "reg-names=ARCH"
Print CPU-specific register names (\s-1CP0\s0 register and \s-1HWR\s0 names)
as appropriate for the selected \s-1CPU\s0 or architecture.
.RE
.RS 4
.Sp
For any of the options listed above, \fI\s-1ABI\s0\fR or
\&\fI\s-1ARCH\s0\fR may be specified as \fBnumeric\fR to have numbers printed
rather than names, for the selected types of registers.
You can list the available values of \fI\s-1ABI\s0\fR and \fI\s-1ARCH\s0\fR using
the \fB\-\-help\fR option.
.Sp
For \s-1VAX,\s0 you can specify function entry addresses with \fB\-M
entry:0xf00ba\fR.  You can use this multiple times to properly
disassemble \s-1VAX\s0 binary files that don't contain symbol tables (like
\&\s-1ROM\s0 dumps).  In these cases, the function entry mask would otherwise
be decoded as \s-1VAX\s0 instructions, which would probably lead the rest
of the function being wrongly disassembled.
.RE
.IP "\fB\-p\fR" 4
.IX Item "-p"
.PD 0
.IP "\fB\-\-private\-headers\fR" 4
.IX Item "--private-headers"
.PD
Print information that is specific to the object file format.  The exact
information printed depends upon the object file format.  For some
object file formats, no additional information is printed.
.IP "\fB\-P\fR \fIoptions\fR" 4
.IX Item "-P options"
.PD 0
.IP "\fB\-\-private=\fR\fIoptions\fR" 4
.IX Item "--private=options"
.PD
Print information that is specific to the object file format.  The
argument \fIoptions\fR is a comma separated list that depends on the
format (the lists of options is displayed with the help).
.Sp
For \s-1XCOFF,\s0 the available options are:
.RS 4
.ie n .IP """header""" 4
.el .IP "\f(CWheader\fR" 4
.IX Item "header"
.PD 0
.ie n .IP """aout""" 4
.el .IP "\f(CWaout\fR" 4
.IX Item "aout"
.ie n .IP """sections""" 4
.el .IP "\f(CWsections\fR" 4
.IX Item "sections"
.ie n .IP """syms""" 4
.el .IP "\f(CWsyms\fR" 4
.IX Item "syms"
.ie n .IP """relocs""" 4
.el .IP "\f(CWrelocs\fR" 4
.IX Item "relocs"
.ie n .IP """lineno,""" 4
.el .IP "\f(CWlineno,\fR" 4
.IX Item "lineno,"
.ie n .IP """loader""" 4
.el .IP "\f(CWloader\fR" 4
.IX Item "loader"
.ie n .IP """except""" 4
.el .IP "\f(CWexcept\fR" 4
.IX Item "except"
.ie n .IP """typchk""" 4
.el .IP "\f(CWtypchk\fR" 4
.IX Item "typchk"
.ie n .IP """traceback""" 4
.el .IP "\f(CWtraceback\fR" 4
.IX Item "traceback"
.ie n .IP """toc""" 4
.el .IP "\f(CWtoc\fR" 4
.IX Item "toc"
.ie n .IP """ldinfo""" 4
.el .IP "\f(CWldinfo\fR" 4
.IX Item "ldinfo"
.RE
.RS 4
.PD
.Sp
Not all object formats support this option.  In particular the \s-1ELF\s0
format does not use it.
.RE
.IP "\fB\-r\fR" 4
.IX Item "-r"
.PD 0
.IP "\fB\-\-reloc\fR" 4
.IX Item "--reloc"
.PD
Print the relocation entries of the file.  If used with \fB\-d\fR or
\&\fB\-D\fR, the relocations are printed interspersed with the
disassembly.
.IP "\fB\-R\fR" 4
.IX Item "-R"
.PD 0
.IP "\fB\-\-dynamic\-reloc\fR" 4
.IX Item "--dynamic-reloc"
.PD
Print the dynamic relocation entries of the file.  This is only
meaningful for dynamic objects, such as certain types of shared
libraries.  As for \fB\-r\fR, if used with \fB\-d\fR or
\&\fB\-D\fR, the relocations are printed interspersed with the
disassembly.
.IP "\fB\-s\fR" 4
.IX Item "-s"
.PD 0
.IP "\fB\-\-full\-contents\fR" 4
.IX Item "--full-contents"
.PD
Display the full contents of any sections requested.  By default all
non-empty sections are displayed.
.IP "\fB\-S\fR" 4
.IX Item "-S"
.PD 0
.IP "\fB\-\-source\fR" 4
.IX Item "--source"
.PD
Display source code intermixed with disassembly, if possible.  Implies
\&\fB\-d\fR.
.IP "\fB\-\-prefix=\fR\fIprefix\fR" 4
.IX Item "--prefix=prefix"
Specify \fIprefix\fR to add to the absolute paths when used with
\&\fB\-S\fR.
.IP "\fB\-\-prefix\-strip=\fR\fIlevel\fR" 4
.IX Item "--prefix-strip=level"
Indicate how many initial directory names to strip off the hardwired
absolute paths. It has no effect without \fB\-\-prefix=\fR\fIprefix\fR.
.IP "\fB\-\-show\-raw\-insn\fR" 4
.IX Item "--show-raw-insn"
When disassembling instructions, print the instruction in hex as well as
in symbolic form.  This is the default except when
\&\fB\-\-prefix\-addresses\fR is used.
.IP "\fB\-\-no\-