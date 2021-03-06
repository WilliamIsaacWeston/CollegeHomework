<?php
   require_once( 'utils.php' );
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
          "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
   <head>
      <title>Index</title>
   </head>
   <body>
      <p>
         Name: Isaac Weston
      </p>

      <p>
         <?=hyperlink(
            "https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw02.html",
            "hw02 Assignment page"
         )?>

      </p>

      <p>
         <?=hyperlink("silly-page.php", false)?>

      </p>

      <p>
        <?php
           date_default_timezone_set('America/New_York');

           if (strtotime('2014-Sep-18 23:59') <= time()) 
           { 
              echo "The source code for all hw02 files: ";
              echo toc(array("utils.php", "utils-test.php", "silly-page.php", "index.php"));

              // utils.php
              echo "<hr/>";
              echo "<h3 id='utils.php'>", hyperlink("utils.php", false), "</h3>";
              echo highlight_file( 'utils.php', true );
              // utils-test.php
              echo "<hr/>";
              echo "<h3 id='utils-test.php'>", hyperlink("utils-test.php", false), "</h3>";
              echo highlight_file( 'utils-test.php', true );
              // sillypage.php
              echo "<hr/>";
              echo "<h3 id='silly-page.php'>", hyperlink("silly-page.php", false), "</h3>";
              echo highlight_file( 'silly-page.php', true );
              // index.php
              echo "<hr/>";
              echo "<h3 id='index.php'>", hyperlink("index.php", false), "</h3>";
              echo highlight_file( 'index.php', true );
          }
          else 
          {
              echo "Source files will not be viewable until 2014-Sep-19.";
          }
        ?> 
      </p>
   </body>
</html>
