string aFriend = "Michael";
Console.WriteLine(aFriend);

aFriend = "Toni";
Console.WriteLine("Hello " + aFriend);


Console.WriteLine("\n----------------------------\n");


// string interpolation

Console.WriteLine($"Hello {aFriend}");


Console.WriteLine("\n----------------------------\n");


// work with strings

string firstFriend = "John";
string secondFriend = "Maria";

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");


Console.WriteLine("\n----------------------------\n");


// string length

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters. ");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters. ");


Console.WriteLine("\n----------------------------\n");


// replace text

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());


Console.WriteLine("\n----------------------------\n");


// search text

string phrase = "Today is raining outside";
Console.WriteLine(phrase.Contains("raining")); // return true
Console.WriteLine(phrase.Contains("sunnny")); // return false

if (phrase.Contains("raining"))
{
    Console.WriteLine("The word has been found");
}
else
{
    Console.WriteLine("The word has NOT been found");
}