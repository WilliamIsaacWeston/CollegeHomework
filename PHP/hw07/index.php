<?php
/** Generates an html index page, displaying all of the files for hw04.
 * @author Isaac Weston
 * @version ITEC 325, Fall 2014
 * @url https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw07.html
 */

require_once( 'utils.php' );
date_default_timezone_set('America/New_York');
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
          "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
  <head>
    <title>Index</title>
  </head>
  <body>
    <p>
      Name: Isaac Weston <br />
      Class: ITEC 325
    </p>
    <p>
      <?php echo hyperlink("summary.php", false)?>
    </p>
    <p>
      <?php echo hyperlink("https://php.radford.edu/~itec325/" . 
        "2014fall-ibarland/Homeworks/hw07-wow-db/wow-db.html",
                   "hw07 Assignment page")?>
    </p>
    <p>
      Table of Contents: <br />
      <?php 
        $filelist = array_diff(scandir("."), array(".", "..", "db-password.php"));
        echo toc($filelist);
      ?>
    </p>
    <?php
      foreach ($filelist as $key => $value) {
        show_file_info($value, "2014-Dec-04 00:00", "2014-Dec-22 00:00");
      }
    ?>
    </p>
  </body>
</html>
