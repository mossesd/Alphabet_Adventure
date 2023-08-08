ype">
                    <xs:attribute name="File" use="required" />
                    <xs:attribute name="Lines" />
                </xs:extension>
            </xs:complexContent>
        </xs:complexType>
    </xs:element>
    <xs:element name="RegisterAssembly" substitutionGroup="msb:Task">
        <xs:complexType>
            <xs:complexContent>
                <xs:extension base="msb:TaskType">
                    <xs:attribute name="Assemblies" use="required" />
                    <xs:attribute name="CreateCodeBase" />
                    <xs:attribute name="StateFile" />
                    <xs:attribute name="TypeLibFiles" />
                </xs:extension>
            </xs:complexContent>
        </xs:complexType>
    </xs:element>
    <xs:element name="RemoveDir" substitutionGroup="msb:Task">
        <xs:complexType>
            <xs:complexContent>
                <xs:extension base="msb:TaskType">
                    <xs:attribute name="Directories" use="required" />
                    <xs:attribute name="RemovedDirectories" />
                </xs:extension>
            </xs:complexContent>
        </xs:complexType>
    </xs:element>
    <xs:element name="RemoveDuplicates" substitutionGroup="msb:Task">
        <xs:complexType>
            <xs:complexContent>
                <xs:extension base="msb:TaskType">
                    <xs:attribute name="Filtered" />
                    <xs:attribute name="Inputs" />
                </xs:extension>
            </xs:complexContent>
        </xs:complexType>
    </xs:element>
    <xs:element name="ResGen" substitutionGroup="msb:Task">
        <xs:complexType>
            <xs:complexContent>
                <xs:extension base="msb:TaskType">
                    <xs:attribute name="Sources" use="required" />
                    <xs:attribute name="FilesWritten" />
                    <xs:attribute name="OutputResources" />
                    <xs:attribute name="References" />
                    <xs:attribute name="StateFile" />
                    <xs:attribute name="Timeout" />
                    <xs:attribute name="ToolPath" />
                    <xs:attribute name="UseSourcePath" />
                </xs:extension>
            </xs:complexContent>
        </xs:complexType>
    </xs:element>
    <xs:element name="ResolveAssemblyReference" substitutionGroup="msb:Task">
        <xs:complexType>
            <xs:complexContent>
                <xs:extension base="msb:TaskType">
                    <xs:attribute name="SearchPaths" use="required" />
                    <xs:attribute name="AppConfigFile" />
                    <xs:attribute name="Assemblies" />
        