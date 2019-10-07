using System;
using System.Collections.Generic;

namespace dictionary {
    class Program {
        static void Main (string[] args) {

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
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }

            // Part 2==========================================================================================================================================
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>> ();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string> ();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add ("word", "excited");
            excitedWord.Add ("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add ("part of speech", "adjective");
            excitedWord.Add ("example sentence", "I am excited to learn C#!");
            // Add Dictionary to your `dictionaryOfWords` list
            Dictionary<string, string> stressedWord = new Dictionary<string, string> ();
            stressedWord.Add ("word", "stressed");
            stressedWord.Add ("definition", "experiencing mental or emotional strain or tension.");
            stressedWord.Add ("part of speech", "adjective");
            stressedWord.Add ("example sentence", "I am stressed about learning C#!");
            // create another Dictionary and add that to the list
            Dictionary<string, string> goodWord = new Dictionary<string, string> ();
            goodWord.Add ("word", "good");
            goodWord.Add ("definition", "of high quality; excellent.");
            goodWord.Add ("part of speech", "adjective");
            goodWord.Add ("example sentence", "I hope I am good at learning C#!");

dictionaryOfWords.Add(excitedWord);
dictionaryOfWords.Add(stressedWord);
dictionaryOfWords.Add(goodWord);
            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> words in dictionaryOfWords) {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> kvp in words) {
                    Console.WriteLine ($"{kvp.Key}: {kvp.Value}");
                }
            }

        }
    }
}