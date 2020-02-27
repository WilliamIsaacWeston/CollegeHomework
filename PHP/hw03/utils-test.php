<?php 
/** Test cases for the functions in utils.php.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw03.html
 */

require_once('utils.php');

echo "Running Tests\n";

echo "Testing dropdown\n";

test(dropdown("Empty", array()), 
     "<select name='Empty'>\n"
     . "      </select>\n");
test(dropdown("One", array("this")), 
     "<select name='One'>\n"
     . "        <option value = '0'>this</option>\n"
     . "      </select>\n");
test(dropdown("Two", array("first" => "this",
                           "second" => "that")), 
     "<select name='Two'>\n"
     . "        <option value = 'first'>this</option>\n"
     . "        <option value = 'second'>that</option>\n"
     . "      </select>\n");

echo "\nTesting checkbox\n";

test(checkbox("Empty", array()), "");
test(checkbox("One", array("First")), 
     "<label><input type='checkbox' name='One[]' value='First' />0</label><br>");
test(checkbox("Two", array("First" => "this",
                           "Second" => "that")), 
     "<label><input type='checkbox' name='Two[]' value='this' />First</label><br>\n"
     . "      <label><input type='checkbox' name='Two[]' value='that' />Second</label><br>");

echo "\nTesting Complete.\n";
?>
