<?xml version="1.0"?> 
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0"> 
  <xsl:template match="/"> 
    <html> 
      <head> 
        <title>Movies Movies Movies</title> 
      </head> 
      <body> 
        <h1>Movies Movies Movies</h1>
 

        <ul>
          <xsl:for-each select="movies/movie">
          <xsl:sort select="release-date/year" order="descending" data-type="text" />
            <li><h2><xsl:value-of select="title"/></h2>
              <img>
                <xsl:attribute name="src">
                  <xsl:value-of select="poster/@src" />
                </xsl:attribute>
                <xsl:attribute name="height">
                  300
                </xsl:attribute>
		          </img><br />
              Genres: <xsl:for-each select="genre">
                <xsl:value-of select="."/>
                <xsl:if test="position()!=last()">, </xsl:if>
              </xsl:for-each><br />
              Released <xsl:value-of select="concat(format-number(release-date/year, '0000'), '.', format-number(release-date/month,'00'), '.', format-number(release-date/day,'00'))"/> 
              <xsl:if test="count(studio)!=0"> by <xsl:value-of select="studio"/></xsl:if>.<br />
              Staring: <xsl:for-each select="actor">
                <xsl:value-of select="."/>
                <xsl:choose>
                  <xsl:when test="position()=last()">.</xsl:when>
                  <xsl:when test="position()=last()-1">, and </xsl:when>
                  <xsl:otherwise>, </xsl:otherwise>  
                </xsl:choose>
              </xsl:for-each><br />                   
              <xsl:if test="title/@lang!='en'">
                Language: <xsl:value-of select="title/@lang"/><br />
              </xsl:if>
              <xsl:choose> 
                <xsl:when test="count(mpaa)!=0">
                  Rating: <xsl:value-of select="mpaa/rating"/><br />
                </xsl:when>
                <xsl:otherwise>            
                  Rating: Unrated<br />
                </xsl:otherwise> 
              </xsl:choose>
              See the <a><xsl:attribute name="href">full-reviews.xml#<xsl:value-of select="translate(title, ' ', '-')"/></xsl:attribute>reviews</a>.
            </li>
          </xsl:for-each>
        </ul>
 
      </body> 
    </html> 
  </xsl:template> 
</xsl:stylesheet> 
