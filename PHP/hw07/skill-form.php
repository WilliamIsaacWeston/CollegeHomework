<?php
/** Generates either the skill form or the handler.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw07.html
 */

require( 'utils.php' );
require( 'validate-utils.php' );
require('wow-constants.php');
require('db-password.php');

session_start();
if (array_key_exists('username', $_POST) && $_POST["password"] === "skillz")  {
  $_SESSION['previousAuthent'] = time();
  $_SESSION['username'] = $_POST["username"];
}

$errors = array_key_exists('form-was-submitted', $_POST) ? validateAll($_POST, $traitValues, 
            $typeValues, $maxLengths, $minLevel, $maxLevel) : array();
  
if (!$errors && array_key_exists('form-was-submitted', $_POST)) {
  $conn = mysqli_connect('localhost', 'wweston', $password, 'wweston' );
  
  if ($conn->connect_error) {
    throw new Exception("Error: surroundingFunction: database connection failed." );
  }

  $query = "insert into Skills" .
    "(skillname,minlevel,description,username,trait) values('" . 
    mysqli_real_escape_string($conn, getInput("skillname", $_POST)) . "'," . 
    mysqli_real_escape_string($conn,getInput("minlevel", $_POST)) . ",'" .
    mysqli_real_escape_string($conn,getInput("description", $_POST)) . "','" .
    mysqli_real_escape_string($conn,getInput("username", $_POST)) . "','" .
    mysqli_real_escape_string($conn,getInput("trait", $_POST)) . "')";

  $result = mysqli_query($conn, $query);

  mysqli_close($conn); 
  require('form-handler.php');
}
else {
  // this file also prints any $errMsgs:
  require('print-skill-form.php');
}
?>
