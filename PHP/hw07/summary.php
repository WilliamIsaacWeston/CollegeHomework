<?php
/** Generates a summary of all the items in the skills table.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw07.html
 */

require_once( 'utils.php' );
require('db-password.php');
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
          "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
  <head>
    <title>Summary</title>
  </head>
  <body>
    <p>
    <?php
      $conn = mysqli_connect('localhost', 'wweston', $password, 'wweston' );
  
      if ($conn->connect_error) {
        throw new Exception("Error: surroundingFunction: database connection failed." );
      }

      $qu = "SELECT * FROM Skills";
      $allRows = mysqli_query($conn, $qu);

      while ($oneRow = mysqli_fetch_array($allRows)) {
        $skillname = $oneRow['skillname'];
        echo hyperlink("form-handler.php?skillName=$skillname", $skillname), ", ";
        echo $oneRow['trait'], ", ", $oneRow['minlevel'], "<br />\n";
      }

      mysqli_close($conn); 
    ?>
    </p>
    <p>
      <?php echo hyperlink("skill-form.php", "Create a new skill")?>
    </p>
  </body>
</html>
