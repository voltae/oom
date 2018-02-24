using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // initialize a new string
            string aFriend = "Franz";
            // concatenate the string with the text output 
            Console.WriteLine("Hello " + aFriend);

            // concatenate two strings together
            string bFriend = "Marian";
            bFriend += " und Helmuth"; 

            // print out the length of the second string
            Console.WriteLine($"Hello {aFriend} and {bFriend.Length}");

            // replace the name 'Helmuth' with the name 'Angela'
            bFriend = bFriend.Replace("Helmuth", "Angela");
            // print out the result
            Console.WriteLine(bFriend);
        }
    }
}
