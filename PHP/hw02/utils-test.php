<?php 

require_once('utils.php');


echo "Running Tests";

echo "\nTesting hyperlink\n";

if (hyperlink("http://www.gutenberg.org", "free books!") === 
              "<a href='http://www.gutenberg.org'>free books!</a>") 
{
  echo ".";
}
else 
{
  echo "!!! Test failed:\n";
  echo "expected: ", "<a href='http://www.gutenberg.org'>free books!</a>", "\n";
  echo "actual:   ", hyperlink("http://www.gutenberg.org", "free books!"), "\n";
}

if (hyperlink("myLocalFile.html", false) === "<a href='myLocalFile.html'>myLocalFile.html</a>") 
{
  echo ".";
}
else 
{
  echo "!!! Test failed:\n";
  echo "expected: ", "<a href='myLocalFile.html'>myLocalFile.html</a>", "\n";
  echo "actual:   ", hyperlink("myLocalFile.html", false), "\n";
}

// 2a. <img src='pony.jpg' width='300'>
// 2b. <a href='pony.jpg'><img src='pony.jpg' width='300'></a>

echo "\nTesting thumbnail\n";

if (thumbnail("pony.jpg",300) === "<a href='pony.jpg'><img src='pony.jpg' width='300'></a>") 
{
  echo ".";
}
else 
{
  echo "!!! Test failed:\n";
  echo "expected: ", "<a href='pony.jpg'><img src='pony.jpg' width='300'></a>", "\n";
  echo "actual:   ", thumbnail("pony.jpg", 300), "\n";
}

echo "\nTesting arrayToString\n";

if (arrayToString(array()) === "") 
{
  echo ".";
}
else 
{
  echo "!!! Test failed:\n";
  echo "expected: ", "", "\n";
  echo "actual:   ", arrayToString(array()), "\n";
}

if (arrayToString(array("red")) === "red") 
{
  echo ".";
}
else 
{
  echo "!!! Test failed:\n";
  echo "expected: ", "red", "\n";
  echo "actual:   ", arrayToString(array("red")), "\n";
}

if (arrayToString(array("red", "blue")) === "red and blue") 
{
  echo ".";
}
else 
{
  echo "!!! Test failed:\n";
  echo "expected: ", "red and blue", "\n";
  echo "actual:   ", arrayToString(array("red", "blue")), "\n";
}

if (arrayToString(array("red", "blue", "green")) === "red, blue, and green") 
{
  echo ".";
}
else 
{
  echo "!!! Test failed:\n";
  echo "expected: ", "red, blue, and green", "\n";
  echo "actual:   ", arrayToString(array("red", "blue", "green")), "\n";
}

echo "\nTesting toc\n";

if (toc(array()) === "<ul>\n" .
                     "         </ul>\n") 
{
  echo ".";
}
else 
{
  echo "!!! Test failed:\n";
  echo "expected: ", "<ul>\n" . 
                     "         </ul>\n", "\n";
  echo "actual:   ", toc(array()), "\n";
}

if (toc(array("thumbnail-problem")) === 
              "<ul>\n" . 
              "            <li><a href='#thumbnail-problem'>thumbnail-problem</a></li>\n" . 
              "         </ul>\n") 
{
  echo ".";
}
else 
{
  echo "!!! Test failed:\n";
  echo "expected: ", "<ul>\n" . 
                     "            <li><a href='#thumbnail-problem'>thumbnail-problem</a></li>\n" . 
                     "         </ul>\n", "\n";
  echo "actual:   ", toc(array("thumbnail-problem")), "\n";
}

if (toc(array("thumbnail-problem", "commaList-problem")) === 
              "<ul>\n" . 
              "            <li><a href='#thumbnail-problem'>thumbnail-problem</a></li>\n" . 
              "            <li><a href='#commaList-problem'>commaList-problem</a></li>\n" .
              "         </ul>\n") 
{
  echo ".";
}
else 
{
  echo "!!! Test failed:\n";
  echo "expected: ", "<ul>\n" . 
                     "            <li><a href='#thumbnail-problem'>thumbnail-problem</a></li>\n" . 
                     "            <li><a href='#commaList-problem'>commaList-problem</a></li>\n" . 
                     "         </ul>\n", "\n";
  echo "actual:   ", toc(array("thumbnail-problem", "commaList-problem")), "\n";
}

if (toc(array("thumbnail-problem", "commaList-problem", "due-date")) === 
              "<ul>\n" . 
              "            <li><a href='#thumbnail-problem'>thumbnail-problem</a></li>\n" . 
              "            <li><a href='#commaList-problem'>commaList-problem</a></li>\n" .
              "            <li><a href='#due-date'>due-date</a></li>\n" . 
              "         </ul>\n") 
{
  echo ".";
}
else 
{
  echo "!!! Test failed:\n";
  echo "expected: ", "<ul>\n" .
                     "            <li><a href='#thumbnail-problem'>thumbnail-problem</a></li>\n" . 
                     "            <li><a href='#commaList-problem'>commaList-problem</a></li>\n" .
                     "            <li><a href='#due-date'>due-date</a></li>" .
                     "         </ul>\n", "\n";
  echo "actual:   ", toc(array("thumbnail-problem", "commaList-problem", "due-date")), "\n";
}

echo "\nTesting Complete.\n";
?>
