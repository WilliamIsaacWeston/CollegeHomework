<?php
/** Generates a html form page for creating new skills in .W.o.W.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw03.html
 */

require_once( 'utils.php' );
date_default_timezone_set('America/New_York');
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
          "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
  <head>
    <title>.W.o.W. Skill Entry Form</title>
  </head>
  <form action="form-handler.php" method="post"> 
  <body>
    <h1>.W.o.W. Skill Entry Page</h1>
    <p>
      Your name:&nbsp; 
      <input type="text" name="username" size="20" maxlength="30" /> 
    </p>
    <p>
      Trait: &nbsp; 
      <?=dropdown("trait", array("Strength"     => "Strength", 
                                  "Intelligence" => "Intelligence", 
                                  "Wisdom"       => "Wisdom", 
                                  "Dexterity"    => "Dexterity", 
                                  "Constitution" => "Constitution", 
                                  "Charisma"     => "Charisma"))?>
    </p>
    <p>
      Skill name:&nbsp; 
      <input type="text" name="skillname" size="20" maxlength="30" /> 
    </p>
    <p>
      Min. Level (30-100):&nbsp; 
      <input type="text" name="minlevel" size="3" maxlength="3" /> <br />
    </p>
    <p>
      Skill Description:<br />
      <textarea name="description" rows="10" cols="50"></textarea>
    </p>
    <p>
      <strong>This skill is available to:</strong>&nbsp; <br />
      <?=checkbox("type", array("Warrior" => "Warrior",
                                "Mage"    => "Mage",
                                "Priest"  => "Priest",
                                "Rogue"   => "Rogue")) ?> 
    </p>
    <p>
      <input type="submit" value="Submit">
      <input type="reset" value="Reset">
    </p>
    <hr />
    <p style='text-align:center;'>
      <em>This file last modified <?=date("F d Y H:i.", filemtime("skill-form.php"))?></br>
      Report any concerns to wweston@radford.edu.</em>
    </p>
  </body>
</html>
