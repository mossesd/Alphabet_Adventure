xs:schema xmlns:xs="http://www.w3.org/2001/XMLSchema"
           xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/"
           targetNamespace="http://schemas.xmlsoap.org/wsdl/"
           elementFormDefault="qualified" >
   
  <xs:complexType mixed="true" name="tDocumentation" >
    <xs:sequence>
      <xs:any minOccurs="0" maxOccurs="unbounded" processContents="lax" />
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name="tDocumented" >
    <xs:annotation>
      <xs:documentation>
      This type is extended by  component types to allow them to be documented
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name="documentation" type="wsdl:tDocumentation" minOccurs="0" />
    </xs:sequence>
  </xs:complexType>
	 
  <xs:complexType name="tExtensibleAttributesDocumented" abstract="true" >
    <xs:complexContent>
      <xs:extension base="wsdl:tDocumented" >
        <xs:annotation>
          <xs:documentation>
          This type is extended by component types to allow attributes from other namespaces to be added.
          </xs:documentation>
        </xs:annotation>
        <xs:anyAttribute namespace="##other" processContents="lax" />    
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:complexType name="tExtensibleDocumented" abstract="true" >
    <xs:complexContent>
      <xs:extension base="wsdl:tDocumented" >
        <xs:annotation>
          <xs:documentation>
          This type is extended by component types to allow elements from other namespaces to be added.
          </xs:documentation>
        </xs:annotation>
        <xs:sequence>
          <xs:any namespace="##other" minOccurs="0" maxOccurs="unbounded" processContents="lax" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:element name="definitions" type="wsdl:tDefinitions" >
    <xs:key name="message" >
      <xs:selector xpath="wsdl:message" />
      <xs:field xpath="@name" />
    </xs:key>
    <xs:key name="portType" >
      <xs:selector xpath="wsdl:portType" />
      <xs:field xpath="@name" />
    </xs:key>
    <xs:key name="binding" >
      <xs:selector xpath="wsdl:binding" />
      <xs:field xpath="@name" />
    </xs:key>
    <xs:key name="service" >
      <xs:selector xpath="wsdl:service" />
      <xs:field xpath="@name" />
    </xs:key>
    <xs:key name="import" >
      <xs:selector xpath="wsdl:import" />
      <xs:field xpath="@namespace" />
    </xs:key>
  </xs:element>

  <xs:group name="anyTopLevelOptionalElement" >
    <xs:annotation>
      <xs:documentation>
      Any top level optional element allowed to appear more then once - any child of definitions element except wsdl:types. Any extensibility element is allowed in any place.
      </xs:documentation>
    </xs:annotation>
    <xs:choice>
      <xs:element name="import" type="wsdl:tImport" />
      <xs:element name="types" type="wsdl:tTypes" />                     
      <xs:element name="message"  type="wsdl:tMessage" >
        <xs:unique name="part" >
          <xs:selector xpath="wsdl:part" />
          <xs:field xpath="@name" />
        </xs:unique>
      </xs:element>
      <xs:element name="portType" type="wsdl:tPortType" />
      <xs:element name="binding"  type="wsdl:tBinding" />
      <xs:element name="service"  type="wsdl:tService" >
        <xs:unique name="port" >
          <xs:selector xpath="wsdl:port" />
          <xs:field xpath="@name" />
        </xs:unique>
	  </xs:element>
    </xs:choice>
  </xs:group>

  <xs:complexType name="tDefinitions" >
    <xs:complexContent>
      <xs:extension base="wsdl:tExtensibleDocumented" >
        <xs:sequence>
          <xs:group ref="wsdl:anyTopLevelOptionalElement"  minOccurs="0"   maxOccurs="unbounded" />
        </xs:sequence>
        <xs:attribute name="targetNamespace" type="xs:anyURI" use="optional" />
        <xs:attribute name="name" type="xs:NCName" use="optional" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
   
  <xs:complexType name="tImport" >
    <xs:complexContent>
      <xs:extension base="wsdl:tExtensibleAttributesDocumented" >
        <xs:attribute name="namespace" type="xs:anyURI" use="required" />
        <xs:attribute name="location" type="xs:anyURI" use="required" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
   
  <xs:complexType name="tTypes" >
    <xs:complexContent>   
      <xs:extension base="