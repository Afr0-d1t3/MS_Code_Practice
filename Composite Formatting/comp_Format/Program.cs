string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string originalLetter = string.Format(@"Dear {0},
As a customer of our {1} offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own {2:N0} shares at a return of {3:P}.

Our new product, {4} offers a return of {5:P2}.  Given your current volume, your potential profit would be {6:C2}.
", customerName, currentProduct, currentShares, currentReturn, newProduct, newReturn, newProfit);

Console.WriteLine(originalLetter);
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);