<?php
/** Test case for form-handler.php.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw06.html
 */

$_POST = array("username"    => "ventra99",
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
                               "Rogue" => "Rogue"),
               "form-was-submited" => "Submit");

require_once("skill-form.php");
?>
