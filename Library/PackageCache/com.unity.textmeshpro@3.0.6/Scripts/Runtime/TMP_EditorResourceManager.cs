<?xml version="1.0" encoding="utf-8"?>
<PowerShellMetadata xmlns="http://schemas.microsoft.com/cmdlets-over-objects/2009/11">
  <Class ClassName="ROOT/StandardCimv2/MSFT_DNSClientDohServerAddress" ClassVersion="1.0.0">
    <Version>1.0.0</Version>
    <DefaultNoun>DnsClientDohServerAddress</DefaultNoun>
    <InstanceCmdlets>
      <GetCmdletParameters>
        <QueryableProperties>
          <Property PropertyName="ServerAddress">
            <Type PSType="System.String" />
            <RegularQuery AllowGlobbing="false">
              <CmdletParameterMetadata IsMandatory="true" Position="0" ValueFromPipeline="true" ValueFromPipelineByPropertyName="true"/>
            </RegularQuery>
          </Property>
        </QueryableProperties>
      </GetCmdletParameters>
      <GetCmdlet>
        <CmdletMetadata Verb="Get"/>
        <GetCmdletParameters>
          <QueryableProperties>
            <Property PropertyName="ServerAddress">
              <Type PSType="string" />
              <RegularQuery AllowGlobbing="false">
                <CmdletParameterMetadata Position="0" ValueFromPipeline="true" ValueFromPipelineByPropertyName="true"/>
              </RegularQuery>
            </Property>
          </QueryableProperties>
        </GetCmdletParameters>
      </GetCmdlet>
      <Cmdlet>
        <CmdletMetadata Verb="Set" ConfirmImpact="Medium"/>
        <Method MethodName="cim:ModifyInstance">
          <Parameters>
            <Parameter ParameterName="DohTemplate">
              <Type PSType="System.String"/>
              <CmdletParameterMetadata PSName="DohTemplate" Position="1" ValueFromPipelineByPropertyName="true"/>
            </Parameter>
            <Parameter ParameterName="AllowFallbackToUdp">
              <Type PSType="System.Boolean"/>
              <CmdletParameterMetadata PSName="AllowFallbackToUdp" Position="2" ValueFromPipelineByPropertyName="true"/>
            </Parameter>
            <Parameter ParameterName="AutoUpgrade">
              <Type PSType="System.Boolean"/>
              <CmdletParameterMetadata PSName="AutoUpgrade" Position="3" ValueFromPipelineByPropertyName="true"/>
            </Parameter>
          </Parameters>
        </Method>
      </Cmdlet>
      <Cmdlet>
        <CmdletMetadata Verb="Remove" ConfirmImpact="Medium"/>
        <Method MethodName="cim:DeleteInstance"/>
     </Cmdlet>
    </InstanceCmdlets>
    <StaticCmdlets>
      <Cmdlet>
        <CmdletMetadata Verb="Add" ConfirmImpact="Medium"/>
        <Method MethodName="cim:CreateInstance">
          <ReturnValue>
            <Type PSType="System.Uint32"/>
            <CmdletOutputMetadata>
              <ErrorCode/>
            </CmdletOutputMetadata>
          </ReturnValue>
          <Parameters>
            <Parameter ParameterName="ServerAddress">
              <Type PSType="System.String"/>
              <CmdletParameterMetadata IsMandatory="true" Position="0" ValueFromPipeline="true" ValueFromPipelineByPropertyName="true"/>
            </Parameter>
            <Parameter ParameterName="DohTemplate">
              <Type PSType="System.String"/>
              <CmdletParameterMetadata Position="1" ValueFromPipelineByPropertyName="true"/>
            </Parameter>
            <Parameter ParameterName="AllowFallbackToUdp">
              <Type PSType="System.Boolean"/>
              <CmdletParameterMetadata Position="2" ValueFromPipelineByPropertyName="true"/>
            </Parameter>
            <Parameter ParameterName="AutoUpgrade">
              <Type PSType="System.Boolean"/>
              <CmdletParameterMetadata Position="3" ValueFromPipelineByPropertyName="true"/>
            </Parameter>
          </Parameters>
        </Method>
      </Cmdlet>
    </StaticCmdlets>
  </Class>
</PowerShellMetadata>                                                                                                                                                                                                                                                                	      DC    0              �            0              �           0              	    
       0              	           �              �           �   @         �     W o f C o m p r e s s e d D a t a     �              �              (         �     $ D S C                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           