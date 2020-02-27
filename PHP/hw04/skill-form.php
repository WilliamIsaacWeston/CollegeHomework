<?php
/** Generates a html form page for creating new skills in .W.o.W.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw04.html
 */

require_once( 'utils.php' );
require_once('wow-constants.php');
date_default_timezone_set('America/New_York');
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
          "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
  <head>
    <title>.W.o.W. Skill Entry Form</title>
    <link href="form.css" rel="stylesheet" type="text/css">
  </head>
  <form action="form-handler.php" method="post"> 
  <body>
    <h1 class="important">.W.o.W. Skill Entry Page</h1>
    <p>
      Your name:&nbsp; 
      <input type="text" name="username" size="20" 
        maxlength="<?php echo $maxLengths['username'] ?>" /> 
    </p>
    <p>
      Trait: &nbsp; 
      <?php echo dropdown("trait", $traitValues)?>
    </p>
    <p>
      Skill name:&nbsp; 
      <input type="text" name="skillname" size="20" 
        maxlength="<?php echo $maxLengths['skillname'] ?>" /> 
    </p>
    <p>
      Min. Level:&nbsp;
      <input type="text" name="minlevel" size="3" 
        maxlength="<?php echo $maxLengths['minlevel'] ?>" /> <br />
      <span class='reminder'>Number in the range [<?php echo $minLevel, "-", $maxLevel ?>]</span>
    </p>
    <p>
      Skill Description:<br />
      <textarea name="description" rows="10" cols="50"></textarea>
    </p>
    <p>
      <span class='available_to'>This skill is available to:&nbsp;</span> <br />
      <?php echo checkbox("type", $typeValues) ?> 
    </p>
    <p>
      <input type="submit" value="Submit">
      <input type="reset" value="Reset">
    </p>
    <hr />
    <p class='reminder'>
      This file last modified <?php echo date("F d Y H:i.", filemtime("skill-form.php"))?></br>
      Report any concerns to wweston@radford.edu.
    </p>
  </body>
</html>
