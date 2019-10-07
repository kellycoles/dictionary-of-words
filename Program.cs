using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
        
          /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

// Add several more words and their definitions
wordsAndDefinitions.Add("Awesome", "the feeling of students when they are learning C#");
wordsAndDefinitions.Add("cast", "the process of making a variable temporarily behave as if it were a different type.");
wordsAndDefinitions.Add("Emulator", "a device that simulates the operation of some type of hardware.");
wordsAndDefinitions.Add("FORTRAN", "a high level programming lsnguage introduced in the 1950's");

/*
    Use square brackets to get the definition of two of the
    words and then output them to the console
*/
 Console.WriteLine(wordsAndDefinitions["cast"]);
  Console.WriteLine(wordsAndDefinitions["FORTRAN"]);
/*
    Below, loop over the wordsAndDefinitions dictionary to get the following output:
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
*/
Console.WriteLine("---------------------------------------------------------------------------------");
foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
{
    Console.WriteLine($"The definition of {word.Key} is{word.Value}");
}


        }
    }
}
