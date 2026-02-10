// Search for "You" or "goodbye" at the beginning of a string. Search for "You" or "goodbye" at the end of a string.

string compliment = "You are pretty, goodbye";
Console.WriteLine(compliment.StartsWith("You")); // return true
Console.WriteLine(compliment.StartsWith("goodbye")); // return false

Console.WriteLine(compliment.EndsWith("You")); // return false
Console.WriteLine(compliment.EndsWith("goodbye")); // return true