using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var aFriend = "Steve";
            Console.WriteLine($"Hello {aFriend}!");
            Console.WriteLine($"The name {aFriend} has {aFriend.Length} characters.");
            //
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");
            //
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
            //
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());
            //
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            //
            string songLyrics2 = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics2.StartsWith("You"));
            Console.WriteLine(songLyrics2.EndsWith("greetings"));
        }
    }
}
