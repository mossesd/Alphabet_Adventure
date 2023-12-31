Rev|Int|Fix|IsArray|IsDate|IsEmpty|IsNull|IsNumeric|IsObject|Item|Items|Join|Keys|LBound|LCase|Left|Len|LoadPicture|Log|LTrim|RTrim|Trim|Maths|Mid|Minute|Month|MonthName|MsgBox|Now|Oct|Remove|RemoveAll|Replace|RGB|Right|Rnd|Round|ScriptEngine|ScriptEngineBuildVersion|ScriptEngineMajorVersion|ScriptEngineMinorVersion|Second|SetLocale|Sgn|Sin|Space|Split|Sqr|StrComp|String|StrReverse|Tan|Time|Timer|TimeSerial|TimeValue|TypeName|UBound|UCase|Unescape|VarType|Weekday|WeekdayName|Year)\b)</string>
			<key>name</key>
			<string>support.function.vb.asp</string>
		</dict>
		<dict>
			<key>match</key>
			<string>-?\b((0(x|X)[0-9a-fA-F]*)|(([0-9]+\.?[0-9]*)|(\.[0-9]+))((e|E)(\+|-)?[0-9]+)?)(L|l|UL|ul|u|U|F|f)?\b</string>
			<key>name</key>
			<string>constant.numeric.asp</string>
		</dict>
		<dict>
			<key>match</key>
			<string>(?i:\b(vbtrue|vbfalse|vbcr|vbcrlf|vbformfeed|vblf|vbnewline|vbnullchar|vbnullstring|int32|vbtab|vbverticaltab|vbbinarycompare|vbtextcomparevbsunday|vbmonday|vbtuesday|vbwednesday|vbthursday|vbfriday|vbsaturday|vbusesystemdayofweek|vbfirstjan1|vbfirstfourdays|vbfirstfullweek|vbgeneraldate|vblongdate|vbshortdate|vblongtime|vbshorttime|vbobjecterror|vbEmpty|vbNull|vbInteger|vbLong|vbSingle|vbDouble|vbCurrency|vbDate|vbString|vbObject|vbError|vbBoolean|vbVariant|vbDataObject|vbDecimal|vbByte|vbArray)\b)</string>
			<key>name</key>
			<string>support.type.vb.asp</string>
		</dict>
		<dict>
			<key>captures</key>
			<dict>
				<key>1</key>
				<dict>
					<key>name</key>
					<string>entity.name.function.asp</string>
				</dict>
			</dict>
			<key>match</key>
			<string>(?i:(\b[a-zA-Z_x7f-xff][a-zA-Z0-9_x7f-xff]*?\b)(?=\(\)?))</string>
			<key>name</key>
			<string>support.function.asp</string>
		</dict>
		<dict>
			<key>match</key>
			<string>(?i:((?&lt;=(\+|=|-|\&amp;|\\|/|&lt;|&gt;|\(|,))\s*\b([a-zA-Z_x7f-xff][a-zA-Z0-9_x7f-xff]*?)\b(?!(\(|\.))|\b([a-zA-Z_x7f-xff][a-zA-Z0-9_x7f-xff]*?)\b(?=\s*(\+|=|-|\&amp;|\\|/|&lt;|&gt;|\(|\)))))</string>
			<key>name</key>
			<string>variable.other.asp</string>
		</dict>
		<dict>
			<key>match</key>
			<string>!|\$|%|&amp;|\*|\-\-|\-|\+\+|\+|~|===|==|=|!=|!==|&lt;=|&gt;=|&lt;&lt;=|&gt;&gt;=|&gt;&gt;&gt;=|&lt;&gt;|&lt;|&gt;|!|&amp;&amp;|\|\||\?\:|\*=|/=|%=|\+=|\-=|&amp;=|\^=|\b(in|instanceof|new|delete|typeof|void)\b</string>
			<key>name</key>
			<string>keyword.operator.js</string>
		</dict>
	</array>
	<key>repository</key>
	<dict>
		<key>round-brackets</key>
		<dict>
			<key>begin</key>
			<string>\(</string>
			<key>beginCaptures</key>
			<dict>
				<key>0</key>
				<dict>
					<key>name</key>
					<string>punctuation.section.round-brackets.begin.asp</string>
				</dict>
			</dict>
			<key>end</key>
			<string>\)</string>
			<key>endCaptures</key>
			<dict>
				<key>0</key>
				<dict>
					<key>name</key>
					<string>punctuation.section.round-brackets.end.asp</string>
				</dict>
			</dict>
			<key>name</key>
			<string>meta.round-brackets</string>
			<key>patterns</key>
			<array>
				<dict>
					<key>include</key>
					<string>$self</string>
				</dict>
			</array>
		</dict>
	</dict>
	<key>scopeName</key>
	<string>source.asp.vb.net</string>
	<key>uuid</key>
	<string>7F9C9343-D48E-4E7D-BFE8-F680714DCD3E</string>
</dict>
</plist>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     <?xml version="1.0" encoding="UTF-8"?>
<StringTable>
	<String ID="GroupMemory">Memory</String>
	<String ID="RuleCheckAvailMemory" loc.comment="Name of rule seen in WPDC">Check available memory</String>
	<String ID="RuleMemoryTable">Memory Utilization Table</String>
	<String ID="RuleReduceHandleTable">Adjust Handle Table</String>
	<String ID="RuleFreeSystemPTE">Check on System Page Table Entries Free</String>
	<String ID="WarnFreeSystemPTE_symptom" loc.comment="Symptom string for warning message: WarnFreeSystemPTE">Free System Page Table Entries (PTE) Performance counter average is low</String>
	<String ID="WarnFreeSystemPTE_cause" loc.comment="Cause string for warning message: WarnFreeSystemPTE">Too many System PTE are in use.</String>
	<String ID="WarnFreeSystemPTE_details" loc.comment="Details string for warning message: WarnFreeSystemPTE">There are {freesyspte} free entries.</String>
	<String ID="WarnFreeSystemPTE_res1" loc.comment="Resolution string for warning message: WarnFreeSystemPTE">1. Verify the condition still exists.</String>
	<String ID="WarnFreeSystemPTE_res2" loc.comment="Resolution string for warning message: WarnFreeSystemPTE">2. Close any unused applications.</String>
	<String ID="WarnFreeSystemPTE_related1" loc.comment="First resolution detail string for warning message: WarnFreeSystemPTE">Virtual Memory</String>
	<String ID="WarnPaging_symptom" loc.comment="Symptom string for warning message: WarnPaging">The system is experiencing excessive paging</String>
	<String ID="WarnPaging_cause" loc.comment="Cause string for warning message: WarnPaging">Available memory on the system is low.</String>
	<String ID="WarnPaging_details" loc.comment="Details string for warning message: WarnPaging">The total physical memory on the system is not capable of handling the load.</String>
	<String ID="WarnPaging_res1" loc.comment="Resolution string for warning message: WarnPaging">Upgrade the physical memory or reduce system load</String>
	<String ID="WarnPaging_related1">Memory Diagnosis</String>
</StringTable>
                                                                                                                                                                                                                                                                                                                                                                                