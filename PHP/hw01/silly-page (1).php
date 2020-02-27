<?php
/* @author Isaac Weston
 * @class ITEC 325 Fall 2014
 * @see https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw01.html
 */

require_once( 'utils.php' );

echo '<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"', "\n";
echo '          "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">', "\n";
echo '<html>', "\n";
echo '    <head>', "\n";
echo '        <title>Silly Page</title>', "\n";
echo '    </head>', "\n";
echo '    <body>', "\n";
echo '        <p>', "\n";
echo '            There are ', pluralize(5, "hat"), " for every ", pluralize(1, "cat"), ",", "\n";
echo '            but there are ', pluralize(2, "mat"), " for every ", pluralize(6, "rat"), "!", "\n";
echo '        </p>', "\n";
echo '', "\n";
echo '    </body>', "\n";
echo '</html>', "\n";
?>
