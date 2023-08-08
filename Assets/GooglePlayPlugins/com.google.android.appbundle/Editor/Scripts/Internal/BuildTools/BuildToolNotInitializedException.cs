mentation>
    </xs:annotation>
    <xs:list itemType="xs:anyURI" />
  </xs:simpleType>

  <xs:element name="binding" type="soap:tBinding" />
  <xs:complexType name="tBinding" >
    <xs:complexContent>
      <xs:extension base="wsdl:tExtensibilityElement" >
        <xs:attribute name="transport" type="xs:anyURI" use="required" />
        <xs:attribute name="style" type="soap:tStyleChoice" use="optional" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:simpleType name="tStyleChoice" >
    <xs:restriction base="xs:string" >
      <xs:enumeration value="rpc" />
      <xs:enumeration value="document" />
    </xs:restriction>
  </xs:simpleType>

  <xs:element name="operation" type="soap:tOperation" />
  <xs:complexType name="tOperation" >
    <xs:complexContent>
      <xs:extension base="wsdl:tExtensibilityElement" >
        <xs:attribute name="soapAction" type="xs:anyURI" use="optional" />
        <xs:attribute name="style" type="soap:tStyleChoice" use="optional" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:element name="body" type="soap:tBody" />
  <xs:attributeGroup name="tBodyAttributes" >
    <xs:at