lexType>
    
  <xs:complexType name="tBindingOperationMessage" >
    <xs:complexContent>
      <xs:extension base="wsdl:tExtensibleDocumented" >
        <xs:attribute name="name" type="xs:NCName" use="optional" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  
  <xs:complexType name="tBindingOperationFault" >
    <xs:complexContent>
      <xs:extension base="wsdl:tExtensibleDocumented" >
        <xs:attribute name="name" type="xs:NCName" use="required" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:complexType name="tBindingOperation" >
    <xs:complexContent>
      <xs:extension base="wsdl:tExtensibleDocumented" >
        <xs:sequence>
          <xs:element name="input" type="wsdl:tBindingOperationMessage" minOccurs="0" />
          <xs:element name="output" type="wsdl:tBindingOperationMessage" minOccurs="0" />
          <xs:element name="fault" type="wsdl:tBindingOperationFault" minOccurs="0" maxOccurs="unbounded" />
        </xs:sequence>
        <xs:attribute name="name" type="xs:NCName" use="required" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
     
  <xs:complexType name="tService" >
    <xs:complexContent>
      <xs:extension base="wsdl:tExtensibleDocumented" >
        <xs:sequence>
          <xs:element name="port" type="wsdl:tPort" minOccurs="0" maxOccurs="unbounded" />
        </xs:sequence>
        <xs:attribute name="name" type="xs:NCName" use="required" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
     
  <xs:complexType name="tPort" >
    <xs:complexContent>
      <xs:extension base="wsdl:tExtensibleDocumented" >
        <xs:attribute name="name" type="xs:NCName" use="required" />
        <xs:attribute name="binding" type="xs:QName" use="required" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:attribute name="arrayType" type="xs:string" />
  <xs:attribute name="required" type="xs:boolean" />
  <xs:complexType name="tExtensibilityElement" abstract="true" >
    <xs:attribute ref="wsdl:required" use="optional" />
  </xs:complexType>

</xs:schema>u  <?xml version="1.0" encoding="UTF-8" ?> 
<!-- 
 
Copyright 2001 - 2005, International Business Machines Corporation and Microsoft Corporation
All Rights Reserved

License for WSDL Schema Files

The Authors grant permission to copy and distribute the WSDL Schema 
Files in any medium without fee or royalty as long as this notice and 
license are distributed with them.  The originals of these files can 
be located at:

http://schemas.xmlsoap.org/wsdl/soap/2003-02-11.xsd

THESE SCHEMA FILES ARE PROVIDED "AS IS," AND THE AUTHORS MAKE