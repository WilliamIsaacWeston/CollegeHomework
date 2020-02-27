<?php
/** Generates a html form page for creating new skills in .W.o.W.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw07.html
 */

require_once( 'utils.php' );
require_once('wow-constants.php');
date_default_timezone_set('America/New_York');
$numOfErrors = count($errors);
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
          "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
  <head>
    <title>.W.o.W. Skill Entry Form</title>
    <link href="form.css" rel="stylesheet" type="text/css">
  </head>
  <form action="skill-form.php" method="post" onsubmit="return validateAll()"> 
  <body>
    <p class='login'>
<?php
if (time() - $_SESSION['previousAuthent'] < 30) {
  echo "Hello " . $_SESSION['username'];
}
else {
  echo "Not logged in";
}
?>
    </p>
    <script src="validate-utils.js"></script>
    <h1 class="important">.W.o.W. Skill Entry Page</h1>
    <p id="usernameErr" class='error'></p>
    <p id="skillnameErr" class='error'></p>
    <p id="minlevelErr" class='error'></p>
    <p id="descriptionErr" class='error'></p>
    <p id="typeErr" class='error'></p>
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
      Your name:&nbsp; 
      <input type="text" name="username" id ="username" size="20" 
        value="<?php echo $_POST['username']?>"
        maxlength="<?php echo $maxLengths['username'] ?>" onchange="validateUsername()"/> 
    </p>
    <p>
      Password:&nbsp;
      <input type="password" name="password" size="20" maxlength="20"/></input>
    </p>
    <p>
      Trait: &nbsp; 
      <?php echo dropdown("trait", $traitValues, $_POST['trait'])?>
    </p>
    <p>
      Skill name:&nbsp; 
      <input type="text" name="skillname" id="skillname" size="20" 
        value="<?php echo $_POST['skillname']?>"
        maxlength="<?php echo $maxLengths['skillname'] ?>" onchange="validateSkillname()"/> 
    </p>
    <p>
      Min. Level:&nbsp;
      <input type="text" name="minlevel" id="minlevel" size="3" 
        value="<?php echo $_POST['minlevel']?>"
        maxlength="<?php echo $maxLengths['minlevel'] ?>" onchange="validateMinlevel()"/> <br />
      <span class='reminder'>Number in the range [<?php echo $minLevel, "-", $maxLevel ?>]</span>
    </p>
    <p>
      Skill Description:<br />
      <textarea name="description" id="description" rows="10" cols="50" 
        onchange="validateDescription()"><?php echo $_POST['description']?></textarea>
    </p>
    <p>
      <span class='available_to'>This skill is available to:&nbsp;</span> <br />
      <?php echo checkbox("type", $typeValues, $_POST["type"])?> 
    </p>
    <p>
      <input type="submit" name="form-was-submitted" value="Submit">
      <input type="reset" value="Reset">
    </p>
    <hr />
    <p class='reminder'>
      This file last modified <?php echo date("F d Y H:i.", filemtime("print-skill-form.php"))?></br>
      Report any concerns to wweston@radford.edu.
    </p>
  </body>
</html>
