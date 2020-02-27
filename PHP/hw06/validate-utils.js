/** A set of form validation functions.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw06.html
 */

function reportError(field, message){
  var somePara = document.getElementById(field);
  somePara.innerHTML += message;
}

function clearError(field){
  var somePara = document.getElementById(field);
  somePara.innerHTML = "";
}

function checkForNonempty(input){
  return !(input === "" || input === " ");
}

function checkForNoNewlines(input){
  return !(/\n/.test(input));
}

function checkForLetters(input){
  return /[a-zA-Z]/.test(input);
}

function checkLength(input, limit){
  return (input.length <= limit); 
}

function checkLevelRange(input, lower, upper){
  return (!isNaN(input) && input >= lower && input <= upper); 
}

function validateUsername(){
  var somePara = document.getElementById("username");
  var name  = somePara.value;
  var valid = true;

  clearError("usernameErr");

  if (!checkForNonempty(name)){
    valid = false;
    reportError("usernameErr", "Username must be non-empty<br />");
  }
  if (!checkForNoNewlines(name)){
    valid = false;
    reportError("usernameErr", "Username must not contain the newline character<br />");
  }
  if (!checkForLetters(name)){
    valid = false;
    reportError("usernameErr", "Username must contain letters<br />");
  }
  if (!checkLength(name, 20)){
    valid = false;
    reportError("usernameErr", "Username must be no more than 20 characters long<br />");
  }

  return valid;
}

function validateSkillname(){
  var somePara = document.getElementById("skillname");
  var name  = somePara.value;
  var valid = true;

  clearError("skillnameErr");

  if (!checkForNonempty(name)){
    valid = false;
    reportError("skillnameErr", "Skillname must be non-empty<br />");
  }
  if (!checkForNoNewlines(name)){
    valid = false;
    reportError("skillnameErr", "Skillname must not contain the newline character<br />");
  }
  if (!checkForLetters(name)){
    valid = false;
    reportError("skillnameErr", "Skillname must contain letters<br />");
  }
  if (!checkLength(name, 20)){
    valid = false;
    reportError("skillnameErr", "Skillname must be no more than 20 characters long<br />");
  }

  return valid;
}

function validateMinlevel(){
  var somePara = document.getElementById("minlevel");
  var name  = somePara.value;
  var valid = true;

  clearError("minlevelErr");

  if (!checkForNonempty(name)){
    valid = false;
    reportError("minlevelErr", "Min Level must be non-empty<br />");
  }
  if (!checkForNoNewlines(name)){
    valid = false;
    reportError("minlevelErr", "Min Level must not contain the newline character<br />");
  }
  if (!checkLevelRange(name, 30, 100)){
    valid = false;
    reportError("minlevelErr", "Min Level must be between 30 and 100<br />");
  }
  if (!checkLength(name, 3)){
    valid = false;
    reportError("minlevelErr", "Min Level must be no more than 3 characters long<br />");
  }

  return valid;
}

function validateDescription(){
  var somePara = document.getElementById("description");
  var name  = somePara.value;
  var valid = true;

  clearError("descriptionErr");

  if (!checkForNonempty(name)){
    valid = false;
    reportError("descriptionErr", "Description must be non-empty<br />");
  }
  if (!checkForNoNewlines(name)){
    valid = false;
    reportError("descriptionErr", "Description must not contain the newline character<br />");
  }
  if (!checkForLetters(name)){
    valid = false;
    reportError("descriptionErr", "Description must contain letters<br />");
  }
  if (!checkLength(name, 500)){
    valid = false;
    reportError("descriptionErr", "Description must be no more than 500 characters long<br />");
  }

  return valid;
}

function validateTypes(){
  var fields = document.getElementsByTagName("input");
  var valid = false;

  clearError("typeErr");

  for (var i = 0; i < fields.length; i++){
    if (fields[i].type == "checkbox" && fields[i].checked){
      valid =  true;
    }
  }

  if (!valid){
    reportError("typeErr", "At least one checkbox must be checked<br />")
  }

  return valid;
}

function validateAll(){
  var valid = true;

  if (!validateUsername()){
    valid = false;
  }
  if (!validateSkillname()){
    valid = false;
  }
  if (!validateMinlevel()){
    valid = false;
  }
  if (!validateDescription()){
    valid = false;
  }
  if (!validateTypes()){
    valid = false;
  }

  return valid;
}
