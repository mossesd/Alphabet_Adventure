ID]/b:SIST/b:GeneralClose"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_SIST_Date_DMY" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:SIST/b:Date/b:DMY"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_SIST_Date_DM" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:SIST/b:Date/b:DM"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_SIST_Date_MY" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:SIST/b:Date/b:MY"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_SIST_Date_DY" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:SIST/b:Date/b:DY"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_SIST_DateAccessed_DMY" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:SIST/b:DateAccessed/b:DMY"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_SIST_DateAccessed_DM" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:SIST/b:DateAccessed/b:DM"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_SIST_DateAccessed_MY" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:SIST/b:DateAccessed/b:MY"/>
  </xsl:template>

  
  <xsl:template name="templ_prop_SIST_DateAccessed_DY" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:SIST/b:DateAccessed/b:DY"/>
  </xsl:template>


  <xsl:template name="templ_prop_NoCommaBeforeAnd" >
    <xsl:param name="LCID" />
    <xsl:variable name="_LCID">
      <xsl:call-template name="localLCID">
        <xsl:with-param name="LCID" select="$LCID"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:value-of select="/*/b:Locals/b:Local[@LCID=$_LCID]/b:General/b:NoCommaBeforeAnd"/>
  </xsl:template>

  

  <xsl:template match="/">






		<xsl:choose>
			<xsl:when test="b:Version">
				<xsl:text>2006.5.07</xsl:text>
			</xsl:when>

			
			
			<xsl:when test="b:XslVersion">
				<xsl:text>6</xsl:text>
			</xsl:when>

      <xsl:when test="b:StyleNameLocalized">
        <xsl:choose>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1033'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1025'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1037'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1041'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='2052'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1028'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1042'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1036'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1040'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='3082'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1043'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1031'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1046'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1049'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1035'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1032'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1081'">
            <xsl:text>तुराबियन</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1054'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1057'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1086'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1066'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1053'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1069'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1027'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1030'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1110'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1044'">
            <xsl:text>Turabian</xsl:text>
          </xsl:when>
          <xsl:when test="b:StyleNameLocalized/b:Lcid='1061'">
            <xsl:text>Turabi