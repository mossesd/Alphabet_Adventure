string" />
    <xs:attribute name="issuerKeyHash" type="xs:string" />
    <xs:anyAttribute namespace="##other" processContents="lax" />
  </xs:complexType>
</xs:schema>    �\  <?xml version="1.0" encoding="UTF-8"?>
<xsd:schema targetNamespace="urn:mpeg:mpeg21:2003:01-REL-R-NS" xmlns:r="urn:mpeg:mpeg21:2003:01-REL-R-NS" xmlns:enc="http://www.w3.org/2001/04/xmlenc#" xmlns:dsig="http://www.w3.org/2000/09/xmldsig#" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:sccns="urn:uddi-org:schemaCentricC14N:2002-07-10" elementFormDefault="qualified" attributeFormDefault="unqualified">
	<xsd:import namespace="http://www.w3.org/XML/1998/namespace" schemaLocation="xml.0.0.0.1.xsd"/>
	<xsd:import namespace="http://www.w3.org/2000/09/xmldsig#" schemaLocation="xmldsig-core-schema.0.0.0.2.xsd"/>
	<xsd:element name="allConditions" type="r:AllConditions" substitutionGroup="r:condition"/>
	<xsd:element name="allPrincipals" type="r:AllPrincipals" substitutionGroup="r:principal"/>
	<xsd:element name="anXmlExpression" type="r:AnXmlExpression" substitutionGroup="r:anXmlPatternAbstract"/>
	<xsd:element name="anXmlPatternAbstract" type="r:AnXmlPatternAbstract" substitutionGroup="r:resource"/>
	<xsd:element name="condition" type="r:Condition" substitutionGroup="r:licensePart"/>
	<xsd:element name="conditionIncremental" type="r:ConditionIncremental" substitutionGroup="r:dcConstraint"/>
	<xsd:element name="conditionPattern" type="r:ConditionPattern"/>
	<xsd:element name="conditionPatternAbstract" type="r:ConditionPatternAbstract" substitutionGroup="r:anXmlPatternAbstract"/>
	<xsd:element name="datum" type="r:Datum"/>
	<xsd:element name="conditionUnchanged" type="r:ConditionUnchanged" substitutionGroup="r:dcConstraint"/>
	<xsd:element name="dcConstraint" type="r:DcConstraint" substitutionGroup="r:licensePart"/>
	<xsd:element name="delegationControl" substitutionGroup="r:licensePart">
		<xsd:complexType>
			<xsd:complexContent>
				<xsd:extension base="r:LicensePart">
					<xsd:sequence minOccurs="0">
						<xsd:element ref="r:dcConstraint" maxOccurs="unbounded"/>
					</xsd:sequence>
				</xsd:extension>
			</xsd:complexContent>
		</xsd:complexType>
	</xsd:element>
	<xsd:element name="depthConstraint" type="r:DepthConstraint" substitutionGroup="r:dcConstraint"/>
	<xsd:element name="digitalResource" type="r:DigitalResource" substitutionGroup="r:resource"/>
	<xsd:element name="exerciseMechanism" type="r:ExerciseMechanism" substitutionGroup="r:condition"/>
	<xsd:element name="existsRight" type="r:ExistsRight" substitutionGroup="r:condition"/>
	<xsd:element name="forAll" block="#all" substitutionGroup="r:licensePart" final="#all">
		<xsd:complexType>
			<xsd:complexContent>
				<xsd:extension base="r:LicensePart">
					<xsd:sequence>
						<xsd:element ref="r:anXmlPatternAbstract" minOccurs="0" maxOccurs="unbounded"/>
					</xsd:sequence>
					<xsd:attribute name="varName" type="r:VariableName"/>
				</xsd:extension>
			</xsd:complexContent>
		</xsd:complexType>
	</xsd:element>
	<xsd:element name="fulfiller" type="r:Fulfiller" substitutionGroup="r:condition"/>
	<xsd:element name="grant" type="r:Grant" substitutionGroup="r:resource"/>
	<xsd:element name="grantGroup"