<?php
/** Handles the form input for skill-form.php.
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
    <title>.W.o.W. Skill Submitted</title>
  </head>
  <body>
    <p>
      <strong>New Skill: <?=getInput("skillname") ?></strong>
    </p>
    <p>
      <?=nl2br(getInput("description")) ?>
    </p>
    <p>
      Minimum level required: <?=getInput("minlevel") ?> <br />
      Tied to: <?=getInput("trait") ?> <br />
      Available to: <?=getArrayInput("type") ?>
    </p>
    <p>
      <em> <?=getInput("skillname") ?> was submitted by 
      <?=getInput("username") ?> on 
      <?=date("F d Y H:i.", time()) ?> </em>
    </p>
    <hr />
    <p style='text-align:center;'>
      <em>This file last modified <?=date("F d Y H:i.", filemtime("form-handler.php"))?></br>
      Report any concerns to wweston@radford.edu.</em>
    </p>
  </body>
</html>
