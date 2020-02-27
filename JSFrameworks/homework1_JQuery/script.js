// Initial load function
$(document).ready(function(){
  // Hide the table of concentrations screen
  $("#table").hide();
  // Fetch the JSON of major information
  $.getJSON("majors.json", function(json){
    // For each major in the list
    for (i = 0; i < json.majors.length; i++) { 
      // Add a cooresponding option to the major dropdown menu
      $("#major").append("<option value='" + json.majors[i].id + "'>" + json.majors[i].name 
        + "</option>");
   }
 });
});

// Displays the list of concentrations in the top bar
function showMajorScreen() {
  // Swaps the welcome screen with the concentrations screen
  $("#welcome").hide();
  $("#table").show();
  
  // Get the value of the selected dropdown menu item
  var e = document.getElementById("major");
  var selectedMajor = e.options[e.selectedIndex].value;
  
  // Fetch the JSON of major information
  $.getJSON("majors.json", function(json){
    // Reset the values of the list of concentrations and the description field
    $("#concs").html("");
    $("#desc").text("Click on a concentration above to learn more about it.");
    
    // For each major in the list
    for (i = 0; i < json.majors.length; i++) { 
      // Pick out the selected major from the JSON list
      if (json.majors[i].id == selectedMajor) {
        // Calculate the width of the concentration buttons so that each button is the same size.
        var width = 100.0 / json.majors[i].concs.length;
        
        // For each concentration in the major
        for (j = 0; j < json.majors[i].concs.length; j++) {
          // Add a button to the top bar that calls showCourses()
          $("#concs").append("<button type='button' style='width:" + width 
            + "%;' onclick='showCourses(" + i + ", " + j + ")'>"
            + json.majors[i].concs[j].name + "</button>");
        }
      }
    }
  });
}
  
// Displays the desciption of the selected concentration and lists the three major courses
// i - index of the major in the JSON file
// j - index of the concentration in the JSON file
function showCourses(i, j) {
  // Fetch the JSON of major information
  $.getJSON("majors.json", function(json){
    // Reset the values of the text element that will list the courses
    $("#courses").html("<h3>Courses</h3>");
    // Set the value of description feild with the description in the JSON
    $("#desc").text(json.majors[i].concs[j].desc);
    // For each course in the concentration
    for (k = 0; k < json.majors[i].concs[j].courses.length; k++) { 
      // Add a button to the side bar that calls showDescription)
      $("#courses").append("<button type='button' onclick='showDescription(" 
        + i + ", " + j + ", " + k + ")'>" 
        + json.majors[i].concs[j].courses[k].name + "</button>");
    }
  });
}
  
// Displays the desciption of the selected course
// i - index of the major in the JSON file
// j - index of the concentration in the JSON file
// k - index of the course in the JSON file
function showDescription(i, j, k) {
  // Fetch the JSON of major information
  $.getJSON("majors.json", function(json){
    // Set the value of description feild with the description in the JSON
    $("#desc").text(json.majors[i].concs[j].courses[k].desc);
  });
}