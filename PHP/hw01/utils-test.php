<?php
/* @author Isaac Weston
 * @class ITEC 325 Fall 2014
 * @see https://php.radford.edu/~itec325/2014fall-ibarland/Homeworks/hw01.html
 */

require_once("utils.php");
  
// Run our tests:
echo "\nactual: ", pluralize(5, "a");
echo "\nexpect: ", "5 as";

echo "\nactual: ", pluralize(1, "a");
echo "\nexpect: ", "1 a";
    
echo "\nactual: ", pluralize(2, "shoe");
echo "\nexpect: ", "2 shoes";
    
echo "\nactual: ", pluralize(1, "duck");
echo "\nexpect: ", "1 duck";
    
echo "\nactual: ", pluralize(0, "light");
echo "\nexpect: ", "0 lights";
    
echo "\nactual: ", pluralize(1, "mouse");
echo "\nexpect: ", "1 mouse";
    
echo "\nactual: ", pluralize(2, "mouse");
echo "\nexpect: ", "2 mice";
    
echo "\nactual: ", pluralize(1, "puppy");
echo "\nexpect: ", "1 puppy";
    
echo "\nactual: ", pluralize(6, "puppy");
echo "\nexpect: ", "6 puppies";
    
echo "\nactual: ", pluralize(-2, "dog");
echo "\nexpect: ", "-2 dogs";
    
echo "\nactual: ", pluralize(1.5, "bird");
echo "\nexpect: ", "1.5 birds";
    
echo "\nactual: ", pluralize(0.5, "toaster");
echo "\nexpect: ", "0.5 toaster";

echo "\n";
?>
