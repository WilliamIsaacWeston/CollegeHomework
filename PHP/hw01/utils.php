<?php
/* @author Isaac Weston
 * @class ITEC 325 Fall 2014
 * @see https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw01.html
 */

/** Returns a user-friendly version of a number and a noun:
 * @param $num The quantity (a number) of $noun, must be positive.
 * @param $noun The name of the represented object.
 * @return a string begining with $num, followed by a space, then $noun, ending
 *    with the character 's', if $num is not 1. 
 */
function pluralize($num, $noun) 
{
   $result = $num . " " . $noun;
   if ($num <= 0 || $num > 1)
   {
      $result = $result . "s";
   }
   return $result;
}
?>
