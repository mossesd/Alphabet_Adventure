tem "--headers"
.PD
Display summary information from the section headers of the
object file.
.Sp
File segments may be relocated to nonstandard addresses, for example by
using the \fB\-Ttext\fR, \fB\-Tdata\fR, or \fB\-Tbss\fR options to
\&\fBld\fR.  However, some object file formats, such as a.out, do not
store the starting address of the file segments.  In those situations,
although \fBld\fR relocates the sections correctly, using \fBobjdump
\&\-h\fR to list the file section headers cannot show the correct addresses.
Instead, it shows the usual addresses, which are implicit for the
target.
.Sp
Note, in some cases it is possible for a section to have both the
\&\s-1READONLY\s0 and the \s-1NOREAD\s0 attributes set.  In such cases the \s-1NOREAD\s0
attribute takes precedence, but \fBobjdump\fR will report both
since the exact setting of the flag bits might be important.
.IP "\fB\-H\fR" 4
.IX Item "-H"
.PD 0
.IP "\fB\-\-help\fR" 4
.IX Item "--help"
.PD
Print a summary of the options to \fBobjdump\fR and exit.
.IP "\fB\-i\fR" 4
.IX Item "-i"
.PD 0
.IP "\fB\-\-info\fR" 4
.IX Item "--info"
.PD
Display a list showing all architectures and object formats available
for specification with \fB\-b\fR or \fB\-m\fR.
.IP "\fB\-j\fR \fIname\fR" 4
.IX Item "-j name"
.PD 0
.IP "\fB\-\-section=\fR\fIname\fR" 4
.IX Item "--section=name"
.PD
Display information only for section \fIname\fR.
.IP "\fB\-l\fR" 4
.IX Item "-l"
.PD 0
.IP "\fB\-\-line\-numbers\fR" 4
.IX Item "--line-numbers"
.PD
Label the display (using debugging information) with the filename and
source line numbers corresponding to the object code or relocs shown.
Only useful with \fB\-d\fR, \fB\-D\fR, or \fB\-r\fR.
.IP "\fB\-m\fR \fImachine\fR" 4
.IX Item "-m machine"
.PD 0
.IP "\fB\-\-architecture=\fR\fImachine\fR" 4
.IX Item "--architecture=machine"
.PD
Specify the architecture to use when disassembling object files.  This
can be useful when disassembling object files which do not describe
architecture information, such as S\-records.  You can list the available
architectures with the \fB\-i\fR option.
.Sp
If the target is an \s-1ARM\s0 architecture then this switch has an
additional effect.  It restricts the disassembly to only those
instructions supported by the architecture specified by \fImachine\fR.
If it is necessary to use this switch because the input file does not
contain any architecture information, but it is also desired to
disassemble all the instructions use \fB\-marm\fR.
.IP "\fB\-M\fR \fIoptions\fR" 4
.IX Item "-M options"
.PD 0
.IP "\fB\-\-disassembler\-options=\fR\fIoptions\fR" 4
.IX Item "--disassembler-options=options"
.PD
Pass target specific information to the disassembler.  Only supported on
some targets.  If it is necessary to specify more than one
disassembler option then multiple \fB\-M\fR options can be used or
can be placed together into a comma separated list.
.Sp
If the target is an \s-1ARM\s0 architecture then this switch can be used to
select which register name set is used during disassembler.  Specifying
\&\fB\-M reg-names-std\fR (the default) will select the register names as
used in \s-1ARM\s0's instruction set documentation, but with register 13 called
\&'sp', register 14 called 'lr' and register 15 called 'pc'.  Specifying
\&\fB\-M reg-names-apcs\fR will select the name set used by the \s-1ARM\s0
Procedure Call Standard, whilst specifying \fB\-M reg-names-raw\fR will
just use \fBr\fR followed by the register number.
.Sp
There are also two variants on the \s-1APCS\s0 register naming scheme enabled
by \fB\-M reg-names-atpcs\fR and \fB\-M reg-names-special-atpcs\fR which
use the ARM/Thumb Procedure Call Standard naming conventions.  (Either
with the normal register names or the special register names).
.Sp
This option can also be used for \s-1ARM\s0 architectures to force the
disassembler to interpret all instructions as Thumb instructions by
using the switch \fB\-\-disassembler\-options=force\-thumb\fR.  This can be
useful when attempting to disassemble thumb code produced by other
compilers.
.Sp
For the x86, some of the options duplicate functions of the \fB\-m\fR
switch, but allow finer grained control.  Multiple selections from the
following may be specified as a comma separated string.
.RS 4
.ie n .IP """x86\-64""" 4
.el .IP "\f(CWx86\-64\fR" 4
.IX Item "x86-64"
.PD 0
.ie n .IP """i386""" 4
.el .IP "\f(CWi386\fR" 4
.IX Item "i386"
.ie n .IP """i8086""" 4
.el .IP "\f(CWi8086\fR" 4
.IX Item "i8086"
.PD
Select disassembly for the given architecture.
.ie n .IP """intel""" 4
.el .IP "\f(CWintel\fR" 4
.IX Item "intel"
.PD 0
.ie n .IP """att""" 4
.el .IP "\f(CWatt\fR" 4
.IX Item "att"
.PD
Select between intel syntax mode and \s-1AT&T\s0 