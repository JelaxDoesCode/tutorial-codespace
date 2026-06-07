Console.WriteLine("Hello, World");
string aFriend="Bill";
Console.WriteLine("Hello"+ aFriend);
aFriend="Maira";
Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Nils";
string secondFriend="Paul";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($" The name {secondFriend} has {secondFriend.Length} letters");


// Leerzeichen weg cutten
string greeting ="       Hello Wolrd!        "; // Leerzeichen noch da
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();// Leerzeichen nur vor dem Text getrimmt
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting=greeting.TrimEnd();// Leerzeichen nur naxch demm text getrimmt
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();// alle Leerzeichen weg
Console.WriteLine($"[{trimmedGreeting}]");

string sayHello="Hello World!";
Console.WriteLine(sayHello);
sayHello=sayHello.Replace("Hello", "Greetings"); // das erste Wort wird durch das zweite ersetzt in dem Text
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper()); // Text in Caps
Console.WriteLine(sayHello.ToLower());// Text alles klaein geschrieben

string songLyrics= "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye")); // Abfrage ob in den Lyrics das Wort goodbye vorkommt
Console.WriteLine(songLyrics.Contains("greetings")); // Abfrage ob in den Lyrics das Wort greetings vorkommt


Console.WriteLine(songLyrics.StartsWith("You")); // Abfrage ob am Anfang der Lyrics You steht
Console.WriteLine(songLyrics.EndsWith("hello"));// Abfrage ob am Anfang der Lyrics hello steht