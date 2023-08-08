ntField><xsl:text>b:Pages</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Year</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:ConferenceName</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:City</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Publisher</xsl:text></b:ImportantField>
						</xsl:when>

						<xsl:when test="b:GetImportantFields/b:SourceType='Report'">
							<b:ImportantField><xsl:text>b:Author/b:Author/b:NameList</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Title</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Year</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Publisher</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:City</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:ThesisType</xsl:text></b:ImportantField>
						</xsl:when>

						<xsl:when test="b:GetImportantFields/b:SourceType='SoundRecording'">
							<b:ImportantField><xsl:text>b:Author/b:Composer/b:NameList</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Author/b:Conductor/b:NameList</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Author/b:Performer/b:NameList</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Title</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Year</xsl:text></b:ImportantField>
						</xsl:when>

						<xsl:when test="b:GetImportantFields/b:SourceType='Performance'">
							<b:ImportantField><xsl:text>b:Title</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Author/b:Writer/b:NameList</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Author/b:Performer/b:NameList</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Theater</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:City</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Year</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Month</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Day</xsl:text></b:ImportantField>
						</xsl:when>

						<xsl:when test="b:GetImportantFields/b:SourceType='Art'">
							<b:ImportantField><xsl:text>b:Author/b:Artist/b:NameList</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Title</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b:Institution</xsl:text></b:ImportantField>
							<b:ImportantField><xsl:text>b