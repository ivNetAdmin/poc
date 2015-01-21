<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
  
    <select>
      <xsl:for-each select="*">
        <option></option>
      </xsl:for-each>
    </select>
  
  </xsl:template>

</xsl:stylesheet>
