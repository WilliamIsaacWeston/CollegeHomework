<?php 
/** Test cases for the functions in utils.php.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw04.html
 */

require_once('utils.php');
require_once( 'validate-utils.php' );
require_once('wow-constants.php');

echo "Running Tests\n";

echo "Testing collapseWhitespace\n";

test(collapseWhitespace("       test string"), "test string");
test(collapseWhitespace("test string          "), "test string");
test(collapseWhitespace("test             string"), "test string");
test(collapseWhitespace("       test      string       "), "test string");

echo "\nTesting checkForNonempty\n";

test(checkForNonempty("", "empty"), "empty: Text fields must be non-empty.");
test(checkForNonempty("skdhfakjgf", "empty"), false);

echo "\nTesting checkForNoNewlines\n";

test(checkForNoNewlines("pudd\ning", "something"), "something: No newlines can be in this field.");
test(checkForNoNewlines("skdhfakjgf", "something"), false);

echo "\nTesting checkForLetters\n";

test(checkForLetters("8934 610289&*!@$ &!%\n#)", "text"), 
                     "text: must contain at least one letter.");
test(checkForLetters("skdhf23ak@7jgf444", "test"), false);

echo "\nTesting checkLength\n";

test(checkLength("A string", 5, "book"), "book: Invalid legnth.");
test(checkLength("skdhfakjgf", 20, "book"), false);

echo "\nTesting checkLevelRange\n";

test(checkLevelRange("A string", 5, 15, "level"), "level: not within the specified range.");
test(checkLevelRange(2, 5, 15, "level"), "level: not within the specified range.");
test(checkLevelRange(20, 5, 15, "level"), "level: not within the specified range.");
test(checkLevelRange(15, 5, 20, "level"), false);

echo "\nTesting checkDropbox\n";

test(checkDropbox("Wisdom", array("Strength"     => "Strength", 
                    "Intelligence" => "Intelligence", 
                    "Wisdom"       => "Wisdom", 
                    "Dexterity"    => "Dexterity", 
                    "Constitution" => "Constitution", 
                    "Charisma"     => "Charisma"), "trait"), false);
test(checkDropbox("Chicken", array("Strength"     => "Strength", 
                    "Intelligence" => "Intelligence", 
                    "Wisdom"       => "Wisdom", 
                    "Dexterity"    => "Dexterity", 
                    "Constitution" => "Constitution", 
                    "Charisma"     => "Charisma"), "trait"), "trait: invalid value.");

echo "\nTesting checkCheckboxSelected\n";

test(checkCheckboxSelected(array(), "book"), "book: At least one checkbox must be selected.");
test(checkCheckboxSelected(array("something" => "anything"), 20, "book"), false);

echo "\nTesting checkCheckboxesValid\n";

test(checkCheckboxesValid(array("Mage"    => "Maged"), array("Warrior" => "Warrior",
                   "Mage"    => "Mage",
                   "Priest"  => "Priest",
                   "Rogue"   => "Rogue"), "book"), "book: invalid value.");
test(checkCheckboxesValid(array("Mage"    => "Mage"), array("Warrior" => "Warrior",
                   "Mage"    => "Mage",
                   "Priest"  => "Priest",
                   "Rogue"   => "Rogue"), 20, "book"), false);

echo "\nTesting validateAll\n";

test(count(validateAll(array("username"    => "",
               "trait"       => "",
               "skillname"   => "",
               "minlevel"    => "",
               "description" => "",
               "type" => array()), $traitValues, $typeValues, $maxLengths, 
							   $minLevel, $maxLevel)), 
           9);
test(count(validateAll(array("username"    => "ventra99",
               "trait"       => "Wisdom",
               "skillname"   => "Ventriloquism",
               "minlevel"    => "42",
               "description" => "Ventriloquism allows a character to trick others into thinking a "
                              . "sound is coming from any target location within 2 meters/level. "
                              . "The sound can be any sound made by the character: speech, "
                              . "clapping, gargling, etc.\n\n"
                              . "If another character's Listen check beats your Ventriloquism "
                              . "check, that character is aware that you are the sound's true"
                              . "orgin, as well as what the sound's intended location is.",
               "type" => array("Mage"  => "Mage",
                               "Rogue" => "Rogue")), $traitValues, $typeValues, $maxLengths, 
							   $minLevel, $maxLevel)), 
           0);

echo "\nTesting Complete.\n";
?>
