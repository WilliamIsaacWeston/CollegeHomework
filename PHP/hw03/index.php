<?php
/** Generates an html index page, displaying all of the files for hw03.
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
    <title>Index</title>
  </head>
  <body>
    <p>
      Name: Isaac Weston <br />
      Class: ITEC 325
    </p>
    <p>
      <?=hyperlink("skill-form.php", false)?>
    </p>
    <p>
      <?=hyperlink("https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw03.html",
                   "hw03 Assignment page")?>
    </p>
    <p>
      Table of Contents: <br />
      <?php $filelist = array_diff(scandir("."), array(".", "..")); ?>
      <?=toc($filelist)?>
    </p>
    <?php
      foreach ($filelist as $key => $value) {
        show_file_info($value, "2014-Oct-07 00:00", "2014-Dec-21 18:03");
      }
    ?>
    </p>
  </body>
</html>
