<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="dormitoryDatabase">
    <html>
      <body>
        <h1>Гуртожиток</h1>
        <table>
          <tr>
            <th>ПІБ</th>
            <th>Факультет</th>
            <th>Курс</th>
            <th>Корпус</th>
            <th>Місце проживання</th>
          </tr>
          <xsl:apply-templates select="inmate"/>
        </table>
      </body>
    </html>
  </xsl:template>
  <xsl:template match="inmate">
    <tr>
      <td><xsl:value-of select="@name"/></td>
      <td><xsl:value-of select="@faculty"/></td>
      <td><xsl:value-of select="@year"/></td>
      <td><xsl:value-of select="@building"/></td>
      <td><xsl:value-of select="@address"/></td>
    </tr>
  </xsl:template>
</xsl:stylesheet>
