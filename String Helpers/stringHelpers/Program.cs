// /* Find whats in the paratheses */
// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');  // Position of first
// int closingPosition = message.IndexOf(')');  // Position of second

// openingPosition++;  // Iterate because substring function starts at first position

// int length = closingPosition - openingPosition;  // Find length between
// Console.WriteLine(message.Substring(openingPosition, length));  // Substring takes from the original message

/* For long containers */
// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";  
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);  // Will find where the whole string is
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;  // Add the whole length of the opening string
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

/* Retrieve last occurence of string */
// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');  // Finds last time this char is used

// openingPosition += 1;  // Iterate starting
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

/* Retrieve all occurences of strings */
// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }

// /* Working with more than one symbol */
//  string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

/* Remove Method */
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);  // Straight up removes chars at that index range
Console.WriteLine(updatedData);

/* Replace Method */
// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");  // Replaces characters no matter where they are
// message = message.Replace("-", "");
// Console.WriteLine(message);

/* Challenge */ 
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string message = "What is the value <span>between the tags</span>?";
string openSpan = "<span>";  
string closeSpan = "</span>";

// Find positions of the tags
int openingPosition = input.IndexOf(openSpan);  // Will find where the whole string section is
int closingPosition = input.IndexOf(closeSpan);

// Find the length between the tags
openingPosition += openSpan.Length;  // Add the whole length of the opening string
int length = closingPosition - openingPosition;

// Assign the string to quantity
string quantity = input.Substring(openingPosition, length);  // Extract text between spans

// Find output
// Assign the tag containers
openSpan = "<div>";  
closeSpan = "</div>";

// Find positions of the tags
openingPosition = input.IndexOf(openSpan);  // Will find where the whole string section is
closingPosition = input.IndexOf(closeSpan);

// Find the length between the tags
openingPosition += openSpan.Length;  // Add the whole length of the opening string
length = closingPosition - openingPosition;

// Assign the string to output
string output = input.Substring(openingPosition, length);;  // Remove div tags, replace &trade with &reg

// Replace the &trade
output = output.Replace("&trade","&reg");

Console.WriteLine(quantity);
Console.WriteLine(output);