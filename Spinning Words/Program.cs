using System;

namespace Spinning_Words
{
    class Program
    {
        //Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed(Just like the name of this Kata). 
        //Strings passed in will consist of only letters and spaces.Spaces will be included only when more than one word is present.

        //Examples: 
        //spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
        //spinWords( "This is a test") => returns "This is a test" 
        //spinWords( "This is another test" ) => returns "This is rehtona test"

        static void Main(string[] args)
        {
            var res = SpinWords("Hey fellow warriors");
            Console.Write(res);
            Console.ReadLine();
        }

        public static string SpinWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            var newSentence = "";

            foreach (var word in words)
            {
                if (word.Length >= 5)
                {
                    char[] wordArray = word.ToCharArray();
                    Array.Reverse(wordArray);
                    string backwardsWord = new string(wordArray);
                    newSentence += backwardsWord + " ";
                    continue;
                }
                newSentence += word + " ";
            }

            return newSentence.Trim();
        }
    }
}
