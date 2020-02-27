<?php
   require_once( 'utils.php' );
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
          "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
   <head>
      <title>Silly Page</title>
   </head>
   <body>
      <p id='search'>
         If you need to search for something online, try using 
         <?=hyperlink("http://www.google.com", "Google")?>!
      </p>

      <p id='thumbnail'>
         <?=thumbnail("cat.jpg", 100)?> <br />
         Have a cat!
      </p>

      <p id='list'>
         My favorite fruits are <?=arrayToString(array("apples", "oranges", "pineapples", "cherries"))?>.
      </p>

      <p id='links'>
         Here's some links to everything on this page: 
         <?=toc(array("search", "thumbnail", "list", "links"))?>
      </p>
   </body>
</html>

