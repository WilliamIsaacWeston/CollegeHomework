<?php
/** A set of form validation functions.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw04.html
 */

require_once('wow-constants.php');

/** Validates all of the fields in an array.
 * @param $arr The array to be validated.
 * @param $traitValues All possible values of trait.
 * @param $typeValues All possible values of type.
 * @param $maxLengths Maximum lengths of all text fields.
 * @param $minLevel Minimum lengths of all text fields.
 * @param $maxLevel Maximum value of level.
 * @return An array containing zero or more string error messages.
 */
function validateAll($arr, $traitValues, $typeValues, $maxLengths, $minLevel, $maxLevel){
  $errors = array();
  
  if (checkForNonempty(collapseWhitespace($arr["username"]), "username") !== false){
    $errors["username-empty"] = 
	checkForNonempty(collapseWhitespace($arr["username"]), "username");
  }
  if (checkForNoNewlines(collapseWhitespace($arr["username"]), "username") !== false){
    $errors["username-newlines"] = 
	checkForNoNewlines(collapseWhitespace($arr["username"]), "username");
  }
  if (checkForLetters(collapseWhitespace($arr["username"]), "username") !== false){
    $errors["username-letters"] = 
	checkForLetters(collapseWhitespace($arr["username"]), "username");
  }
  if (checkLength(collapseWhitespace($arr["username"]), $maxLengths["username"], "username") 
          !== false){
    $errors["username-length"] = 
	checkLength(collapseWhitespace($arr["username"]), $maxLengths["username"]);
  }
  if (checkDropbox($arr["trait"], $traitValues, "trait") !== false){
    $errors["trait-invalid"] = 
	checkDropbox($arr["trait"], $traitValues, "trait");
  }
  if (checkForNonempty(collapseWhitespace($arr["skillname"]), "skillname") !== false){
    $errors["skillname-empty"] = 
	checkForNonempty(collapseWhitespace($arr["skillname"]), "skillname");
  }
  if (checkForNoNewlines(collapseWhitespace($arr["skillname"]), "skillname") !== false){
    $errors["skillname-newlines"] = 
	checkForNoNewlines(collapseWhitespace($arr["skillname"]));
  }
  if (checkForLetters(collapseWhitespace($arr["skillname"]), "skillname") !== false){
    $errors["skillname-letters"] = 
	checkForLetters(collapseWhitespace($arr["skillname"]), "skillname");
  }
  if (checkLength(collapseWhitespace($arr["skillname"]), $maxLengths["skillname"], "skillname") 
        !== false){
    $errors["skillname-length"] = 
	checkLength(collapseWhitespace($arr["skillname"]), $maxLengths["skillname"]);
  }
  if (checkLevelRange(collapseWhitespace($arr["minlevel"]), $minLevel, $maxLevel, "minlevel") 
        !== false){
    $errors["minlevel-range"] = 
	checkLevelRange(collapseWhitespace($arr["minlevel"]), $minLevel, $maxLevel, "minlevel");
  }
  if (checkLength(collapseWhitespace($arr["minlevel"]), $maxLengths["minlevel"], "minlevel") 
        !== false){
    $errors["minlevel-length"] = 
	checkLength(collapseWhitespace($arr["minlevel"]), $maxLengths["minlevel"]);
  }
  if (checkForNonempty(collapseWhitespace($arr["description"]), "description") !== false){
    $errors["description-empty"] = 
	checkForNonempty(collapseWhitespace($arr["description"]), "description");
  }
  if (checkForLetters(collapseWhitespace($arr["description"]), "description") !== false){
    $errors["description-letters"] = 
	checkForLetters(collapseWhitespace($arr["description"]), "description");
  }
  if (checkLength(collapseWhitespace($arr["description"]), $maxLengths["description"], 
                                     "description") !== false){
    $errors["description-length"] = 
	checkLength(collapseWhitespace($arr["description"]), $maxLengths["description"]);
  }
  if (checkCheckboxSelected($arr["type"], "type") !== false){
    $errors["type-not-selected"] = 
	checkCheckboxSelected($arr["type"], "type");
  }
  if (checkCheckboxesValid($arr["type"], $typeValues, "type") !== false){
    $errors["type-invalid"] = 
	checkCheckboxesValid($arr["type"]);
  }
  return $errors;
}

/** Removes any multiple horizonal whitespace in a string.
 * @param $input The string with whitespace.
 * @return The same string minus whitespace.
 */
function collapseWhitespace($input){
  return trim(preg_replace('/\p{Z}+/', ' ', $input));
}

/** Checks if a string is empty or not.
 * @param $input The string to be validated.
 * @param $name Reference name of the string.
 * @return Either an error message or false.
 */
function checkForNonempty($input, $name){
  $error = false;

  if ($input === "" || $input === " "){
    $error = "$name: Text fields must be non-empty.";
  }

  return $error;
}

/** Checks if a string contains newlines.
 * @param $input The string to be validated.
 * @param $name Reference name of the string.
 * @return Either an error message or false.
 */
function checkForNoNewlines($input, $name){
  $error = false;

  if (preg_match('/\n/', $input)){
    $error = "$name: No newlines can be in this field.";
  }

  return $error;
}

/** Checks if a string contains letters.
 * @param $input The string to be validated.
 * @param $name Reference name of the string.
 * @return Either an error message or false.
 */
function checkForLetters($input, $name){
  $error = "$name: must contain at least one letter.";

  if (preg_match('/\p{L}+/', $input)){
    $error = false;
  }

  return $error;
}

/** Checks if a string length is less than a maximum length.
 * @param $input The string to be validated.
 * @param $maxLength The maximum length of the string.
 * @param $name Reference name of the string.
 * @return Either an error message or false.
 */
function checkLength($input, $maxLength, $name){
  $error = false;

  if (strlen($input) > $maxLength){
    $error = "$name: Invalid legnth.";
  }

  return $error;
}

/** Checks if a number is in between two other numbers.
 * @param $input The number to be validated.
 * @param $upper The upper bound.
 * @param $upper The lower bound.
 * @param $name Reference name of the number.
 * @return Either an error message or false.
 */
function checkLevelRange($input, $lower, $upper, $name){
  $error = "$name: not within the specified range.";

  if (is_numeric($input) && $input >= $lower && $input <= $upper){
    $error = false;
  }
   
  return $error; 
}

/** Checks if a string matches one of several values.
 * @param $input The string to be validated.
 * @param $values Array of possible values of $input.
 * @param $name Reference name of the string.
 * @return Either an error message or false.
 */
function checkDropbox($input, $values, $name){
  $error = false;

  if (!in_array($input, $values)){
    $error = "$name: invalid value.";
  }

  return $error;
}

/** Checks if an array has at least one value.
 * @param $arr The array to be validated.
 * @param $name Reference name of the array.
 * @return Either an error message or false.
 */
function checkCheckboxSelected($arr, $name){
  $error = false;

  if (count($arr) === 0){
    $error = "$name: At least one checkbox must be selected.";
  }

  return $error;
}

/** Checks if a series of strings matches several values.
 * @param $input The array of strings to be validated.
 * @param $values Array of possible values of $input.
 * @param $name Reference name of the string.
 * @return Either an error message or false.
 */
function checkCheckboxesValid($arr, $values, $name){
  $error = false;

  foreach ($arr as $key => $value){
    if (!in_array($value, $values)){
      $error = "$name: invalid value.";
    }
  }

  return $error;
}
?>
