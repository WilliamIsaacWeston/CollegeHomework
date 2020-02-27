<?php
/** Shared values between skill-form.php and validate-utils.php.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw04.html
 */

$traitValues = array("Strength"     => "Strength", 
                    "Intelligence" => "Intelligence", 
                    "Wisdom"       => "Wisdom", 
                    "Dexterity"    => "Dexterity", 
                    "Constitution" => "Constitution", 
                    "Charisma"     => "Charisma");

$typeValues = array("Warrior" => "Warrior",
                   "Mage"    => "Mage",
                   "Priest"  => "Priest",
                   "Rogue"   => "Rogue");

$maxLengths = array("skillname" => 80,
                   "description" => 500,
                   "username" => 80,
                   "minlevel" => 3);

$minLevel = 30;
$maxLevel = 100;
?>
