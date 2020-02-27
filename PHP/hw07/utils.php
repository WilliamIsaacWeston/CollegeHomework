<?php
/** A set of functions.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw07.html
 */

/** Tests the results of a php function.
 * @param $actual The actual output of the function.
 * @param $expected The expected output of the function. 
 */
function test($actual, $expected) {
  if ($actual === $expected) {
    echo ".";
  }
  else{
    echo "\n!!! Test failed:\n";
    echo "expected: $expected\n";
    echo "actual:   $actual\n";
  }
}

/** Formats a html dropdown menu.
 * @param $name The title of the menu.
 * @param $arr An array of strings.
 * @return A string of html, rendering a dropdown menu with each element in $arr as a item on the 
 *   menu.
 */
function dropdown($name, $arr, $preselected=false) {
  $dropdown = "<select name='$name'>\n";

  foreach ($arr as $key => $value) {
    $dropdown .= "        <option value = '$key'";

    if ($preselected === $key) {
      $dropdown .= " selected='selected' ";
    }

    $dropdown .= ">$value</option>\n";
  }

  $dropdown .= "      </select>\n";

  return $dropdown;
}

/** Formats a series of html checkboxes.
 * @param $name The group name of each checkbox.
 * @param $arr An array of strings.
 * @return A string of html, rendering a group of checkboxes with each element in $arr as a item in
 *   the group.
 */
function checkbox($name, $arr, $selarr=array()) {
  $chboxes = "";
  $i = 0;

  foreach ($arr as $key => $value) {
    if ($i !== 0) {
      $chboxes .= "      ";
    }

    $chboxes .= "<label><input type='checkbox' name='$name" 
              . "[]' value='$value' ";

    if (in_array($value, $selarr)) {
      $chboxes .= "checked='checked' ";
    }

    $chboxes .= "/>$key</label><br>";

    if ($i !== count($arr) - 1) {
      $chboxes .= "\n";
    }

    ++$i;
  }

  return $chboxes;
}

/** Prints a horizontal-rule html tag, a link to an input file with an id attribute, the 
 *    last-modified date, and the result of highligh_file_between on the file.
 * @param $filename The name of the file to be printed.
 * @param $starttime The time the file's contents should first be shown.
 * @param $endtime The time the file's contents should be hidden.
 */
function show_file_info($filename, $starttime, $endtime) {
  if (file_exists($filename)) {
    echo "    <hr />\n";
    echo "    <h3 style='text-align:center;' id='$filename'>\n";
    echo "      " . hyperlink($filename, false) . "\n";
    echo "    </h3>\n";
    echo "    <p>\n";
    echo "      Last modified: " . date("F d Y H:i:s.", filemtime($filename)) . "\n";
    echo "    </p>\n";
    highlight_file_between($filename, $starttime, $endtime);
  }
  else {
    echo "    <p>\n      The specified file does not exist on this server.\n    </p>\n";
  }
}

/** Prints the contents of a file, only shown during a set time peroid.
 * @param $filename The name of the file to be printed.
 * @param $starttime The time the file's contents should first be shown.
 * @param $endtime The time the file's contents should be hidden.
 * @return Either a message indicating the file contents are not yet visable, or the file contents.
 */
function highlight_file_between($filename, $starttime, $endtime) {
  if (strtotime($starttime) <= time() && strtotime($endtime) >= time()) { 
    echo highlight_file($filename, true);
  }
  else {
    echo "    <p>\n      Source files are only viewable between $starttime "
      . "and $endtime.\n    </p>\n";
  }
}

/** Return the input from a user form.
 * @param The field-attribute-name to look up, from the original form.
 * @return the input from a user form,
 */
function getInput($name, $arr){
  $formInput = htmlspecialchars(trim( $arr[$name] ));
  return  get_magic_quotes_gpc() ? stripslashes($formInput) : $formInput ;
}

/** Return array input from a user form.
 * @param The field-attribute-name to look up, from the original form.
 * @return the input from a user form,
 */
function getArrayInput($name, $arr){
  $arrToString = arrayToString($arr[$name]);
  $formInput = htmlspecialchars(trim($arrToString));
  return  get_magic_quotes_gpc() ? stripslashes($formInput) : $formInput ;
}

/** Formats a html hyperlink. 
 * @param $url The hyperlink URL.
 * @param $linkTxt The text for the link.
 * @return A string of a html hyperlink linking to $url with $linkTxt as text.
 */
function hyperlink($url, $linkTxt) {
  if ($linkTxt === false) {
    $link = "<a href='$url'>$url</a>";
  }
  else {
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
function thumbnail($url, $width) {
  return hyperlink($url, "<img src='$url' width='$width'>");
}

/** Takes an array of strings and returns its contents as a single string with proper grammer.
 * @param $arr The array of strings.
 * @return A string of the array contents, with commas inbetween each when grammatically required,
 *   and with an "and" before the last word, if grammatically needed.
 */
function arrayToString($items) {
  $strSoFar = "";
  $i = 0;
  foreach( $items as $item ) {
    $strSoFar .= (($i==0 || count($items)==2) ? "" : ",") 
               . (($i==0) ? "" : " ")
               . (($i < count($items)-1 || count($items) == 1) ? "" : "and ") 
               . $item;
    ++$i;
    }
  return $strSoFar; 
}

/** Takes an array of strings and returns its contents as an unordered list of hyperlinks in html.
 * @param $arr The array of strings.
 * @return A string of html, rendering an unordered list which each element in $arr as a item on 
 *   the list; each item i being a hyperlink to anchors in the document matching $arr[i].
 */
function toc($arr) {
  $unor_list = "<ul>\n";

  foreach ($arr as $key => $value) {
    $anchor = "#" . $value;
    $unor_list .= "        <li>" . hyperlink($anchor, $value) . "</li>\n";
  }

  $unor_list .= "      </ul>\n";

  return $unor_list;
}
?>
