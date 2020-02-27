<?php
/** A set of functions that return text.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw02.html
 */


/** Formats a html hyperlink. 
 * @param $url The hyperlink URL.
 * @param $linkTxt The text for the link.
 * @return A string of a html hyperlink linking to $url with $linkTxt as text.
 */
function hyperlink($url, $linkTxt) 
{
  if($linkTxt === false)
  {
    $link = "<a href='$url'>$url</a>";
  }
  else
  {
    $link = "<a href='$url'>$linkTxt</a>";
  }

  return $link;
}

/** Formats a html thumbnail hyperlink. 
 * @param $url The image URL.
 * @param $width The width in pixels of the thumbnail.
 * @return A string of a html hyperlink displaying the picture at $url with a width of $width,
 *   linking to the same image.
 */
function thumbnail($url, $width) 
{
  return hyperlink($url, "<img src='$url' width='$width'>");
}

/** Takes an array of strings and returns its contents as a single string with proper grammer.
 * @param $arr The array of strings.
 * @return A string of the array contents, with commas inbetween each when grammatically required,
 *   and with an "and" before the last word, if grammatically needed.
 */
function arrayToString($arr) 
{
  if (count($arr) === 0)
  {
    $str_list = "";
  }
  elseif (count($arr) === 1)
  {
    $str_list = $arr[0];
  }
  elseif (count($arr) === 2)
  {
    $str_list = $arr[0] . " and " . $arr[1];
  }
  else
  {
    $str_list = "";

    foreach ($arr as $i => $str_i)
    {
      $str_list .= $arr[$i];

      if ($i !== count($arr) - 1)
      {
        $str_list .= ", ";

        if ($i === count($arr) - 2)
        {
          $str_list .= "and ";
        }
      }
    }
  }

  return $str_list;
}

/** Takes an array of strings and returns its contents as an unordered list of hyperlinks in html.
 * @param $arr The array of strings.
 * @return A string of html, rendering an unordered list which each element in $arr as a item on the 
 *   list; each item i being a hyperlink to anchors in the document matching $arr[i].
 */
function toc($arr) 
{
  $unor_list = "<ul>\n";

  foreach ($arr as $i => $str_i)
  {
    $anchor = "#" . $arr[$i];
    $unor_list .= "            <li>" . hyperlink($anchor, $arr[$i]) . "</li>\n";
  }

  $unor_list .= "         </ul>\n";

  return $unor_list;
}
?>
