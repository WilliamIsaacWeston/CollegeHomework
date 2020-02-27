<?php

require( 'utils.php' );
require( 'validate-utils.php' );
require('wow-constants.php');

session_start();
if (array_key_exists('username', $_POST) && $_POST["password"] === "skillz")  {
  $_SESSION['previousAuthent'] = time();
  $_SESSION['username'] = $_POST["username"];
}

$errors = array_key_exists('form-was-submitted', $_POST) ? validateAll($_POST, $traitValues, 
            $typeValues, $maxLengths, $minLevel, $maxLevel) : array();
  
if (!$errors && array_key_exists('form-was-submitted', $_POST)) {
  require('form-handler.php');
}
else {
  // this file also prints any $errMsgs:
  require('print-skill-form.php');
}
?>
