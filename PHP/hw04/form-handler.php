<?php
/** Handles the form input for skill-form.php.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw04.html
 */

require_once( 'utils.php' );
require_once( 'validate-utils.php' );
require_once('wow-constants.php');

date_default_timezone_set('America/New_York');

$errors = validateAll($_POST, $traitValues, $typeValues, $maxLengths, $minLevel, $maxLevel);
$title = ".W.o.W. Skill Submitted";
$numOfErrors = count($errors);

if ($numOfErrors !== 0){
  $title = "Skill form contained $numOfErrors errors";
}
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
          "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
  <head>
    <title><?php echo $title?></title>
    <link rel="stylesheet" type="text/css" href="form.css">
  </head>
  <body>
    <h1 class="important"><?php echo $title?></h1>
<?php 
if ($numOfErrors !== 0){
  echo "    <p class='error'>\n";
  foreach ($errors as $key => $value){
    echo "      $value<br />\n";
  }
  echo "    </p>\n";
}
?>
    <p>
      <strong>New Skill: <?php echo getInput("skillname") ?></strong>
    </p>
    <p>
      <?=nl2br(getInput("description")) ?>
    </p>
    <p>
      Minimum level required: <?php echo getInput("minlevel") ?> <br />
      Tied to: <?=getInput("trait") ?> <br />
      Available to: <?=getArrayInput("type") ?>
    </p>
    <p class='submit_by'>
      <?php echo getInput("skillname") ?> was submitted by 
      <?php echo getInput("username") ?> on 
      <?php echo date("F d Y H:i.", time()) ?>
    </p>
    <hr />
    <p class='reminder'>
      This file last modified <?php echo date("F d Y H:i.", filemtime("form-handler.php"))?></br>
      Report any concerns to wweston@radford.edu.
    </p>
  </body>
</html>
