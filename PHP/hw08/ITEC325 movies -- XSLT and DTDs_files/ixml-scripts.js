/** Starting on a certain date, generate a warning that this page is old.
 * The phrasing is currently specific to a course-page (semesters).
 * Example:  
 *     displayDeprecationNoticeAsOf( 2006, 12, 25, "http://shop.com/nextYearsCatalog.html" ) 
 * 
 * @param expireYear The year this page expires (eg, 2006)
 * @param expireMonth1 The month this page expires (1-12).
 * @param expireDay The day-of-month this page expires (1-31 or so).
 *     The warnings start as of 00:00 (midnight) on that day.
 * @param target A URL to suggest as an alternative.
 * @return An HTML warning, or the empty string (depending on the date).
 * @author Ian Barland
 * @version 2007.Aug.14
 */
function displayDeprecationNoticeAsOf( expireYear, expireMonth1, expireDay, target ) {
  if (new Date() > new Date(expireYear, expireMonth1-1, expireDay)) {
    /* IAN: BUG: don't use document.write; insert a node into the DOM instead. */
    document.write("<h3 align='center'><font color='red'>Old Material</font> &mdash; "
                 + "This page is for an old semester. "
                 + "Check the " 
                 + "<a href='" + target + "'>class archive page</a>"
                 + " for a more recent version."
                 + "<\h3>"
                 )
       }
    }


/** Creates a  ma-il-to  link of interest to spam harvesters.
 *  (Since it's generated dynamically, it's harder to harvest?
 *    I wouldn't bank on that, as it should really wait for
 *    a user click, and then somehow generate the ma-il-to action.)
 *     ::: Aha -- for a better example, see:
 *         http://hometown-services.com/links/link_scrambler.htm
 *
 *  Example usge:
 *      meleeToo( "joe@i.dontcare.com", "Contact customer service" )
 *      meleeToo( "secretAgent%40sh%61dow%2Egov", "report suspicious activity" )
 * 
 *
 *  @param target The em-ai-l to send to.  
 *     This string is allowed to contain hex-character-code sequences, like:
 *     '%40' for '@',  '%2E' for '.', '%61' for 'a', and '%41' for 'A'.
 *  @param linkText The body of the tag.
 *  @return An HTML ma-il-to link.
 */
function meleeToo( target, linkText ) {
  // Make sure the code itself doesn't look too obvious, to bots.
  var umpire   = "ref";
  var sickness = "ail";
  document.write("<a h" + umpire + "='m" + sickness + "t" + "o" + "" + ":" + target + "'>" + linkText + "</a>");

  /* It might be nice have this function itself convert some characters to hex-code.
   * (However, be careful not to convert part of an existing 3-letter-charcode-sequence!)
   */
  }
  /* To be super-studly, I should generate slightly different javascript code each time.
   * But until this method generates so many links that they're worth harvesting,
   * I'll let it slide :-)
   */


function toggleVisiblity(me) {
    if (me.style.visibility=="hidden"){
	me.style.visibility="visible";
	}
    else {
        me.style.visibility="hidden";
        }
    }
  // Can call by passing in the div's "id" attr,
  // or document.getElementByID(@@id-value).

