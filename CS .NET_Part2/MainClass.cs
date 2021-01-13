using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.NET_Part2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //char[] simplePunctuationMarks = { ' ', ',', '-', '.', '/', '"', '\'', '@', '!', '?', '(', ')', '[', ']', '{', '}', ':', ';' };
            char[] simplePunctuationMarks = { ' ' };
            //string doubleQuotesMark = @"""";
            //string triplePeriodMark = "...";
            //string leftSlashMark = @"\";
            //string @else = "<>";

            // string[] complexPunctuations = { doubleQuotesMark, triplePeriodMark, leftSlashMark, @else };
            // DisplayAnArray(simplePunctuationMarks);
            // DisplayAnArray(complexPunctuations);
            // Console.ReadKey();

            Console.WriteLine("Give us some words for a sentence! (please)");
            string inputFromConsoleString = Console.ReadLine();
            // DisplayNumberOfCharsInString(inputFromConsoleString);
            //Console.ReadKey();

            //Console.WriteLine("The words in the sentence are: ");
            //DisplayAnArray(SplitStringInWords(inputFromConsoleString, simplePunctuationMarks));
            //Console.WriteLine();
            //Console.ReadKey();

            //char sentenceDecorator = '*';
            //Console.WriteLine("Some STARS added in the sentence: {0}",
            //    BeautifySentence(SplitStringInWords(inputFromConsoleString, simplePunctuationMarks), sentenceDecorator));
            //Console.ReadKey();

            //PutPunctuationForSentence(ref inputFromConsoleString);
            //Console.WriteLine(inputFromConsoleString);
            //Console.ReadKey();

            //string keepItSimple = "simple ";
            //char[] notSimpleWords = new char[] { 't', 'o', 'o', 'h', 'a', 'r', 'd', 'w', 'o', 'r', 'k' };
            //DisplayAnArray(notSimpleWords);
            //keepItSimple.CopyTo(0, notSimpleWords, 0, keepItSimple.Length);
            //Console.WriteLine();
            //DisplayAnArray(notSimpleWords);
            //Console.ReadKey();

            //int[,] intArray = new int[,] { { 1, 2 }, { 2, 3 }, { 3, 4 } };
            //DisplayMultidimesionalArrays(intArray);
            //Console.ReadKey();


            Console.WriteLine("The words in the sentence are: ");
            DisplayCorectSentence(inputFromConsoleString);
            //Console.WriteLine();
            Console.ReadKey();
        }

        //public static void DisplayNumberOfCharsInString(string inputString)
        //{
        //    Console.WriteLine("The length of the sentence is: {0} characters.", inputString.Length);
        //}

        //public static void PutPunctuationForSentence(ref string inputString)
        //{
        //    Console.WriteLine("The sentence with punctuation is:  {0}", inputString = inputString
        //        .Insert(inputString.Length, "!")
        //        .PadLeft(inputString.Length + 3, '-'));
        //}

        //public static string[] SplitStringInWords(string inputString, char[] separators)
        //{
        //    string[] listOfWords = inputString.Split(separators, inputString.Length / 2, StringSplitOptions.RemoveEmptyEntries);
        //    return listOfWords;
        //}

        void DisplayCorectSentence(string inputSentence)
        {
            DisplayWords(SplitStringInWords(inputSentence));
        }
        string[] SplitStringInWords(string inputString)
        {
            char[] separators = new char[] { ' ' };
            string[] listOfWords = inputString.Split(separators, inputString.Length / 2, StringSplitOptions.RemoveEmptyEntries);
            return listOfWords;
        }
        void DisplayWords(string[] inputWords)
        {
            string[] simplePunctuationMarks = { ",", ".", "!", "?" };
            for (int i = 0; i < inputWords.Length - 1; i++)
            {
                if (simplePunctuationMarks.Contains(inputWords[i + 1]))
                {
                    Console.Write("{0}", inputWords[i]);
                }
                else
                {
                    Console.Write("{0} ", inputWords[i]);
                }
            }
            Console.Write("{0}", inputWords[inputWords.Length - 1]);
        }
        //public static void DisplayAnArray(char[] inputArray)
        //{
        //    foreach (char s in inputArray)
        //    {
        //        Console.Write("{0} ", s);
        //    }
        //}
        //public static StringBuilder BeautifySentence(string[] inputSentence, char decorator)
        //{
        //    StringBuilder beautifiedSentence = new StringBuilder(decorator);
        //    foreach (string s in inputSentence)
        //    {
        //        beautifiedSentence.Append(s).Append(decorator);
        //    }
        //    return beautifiedSentence;
        //}

        //public static void DisplayMultidimesionalArrays(int[,] inputArray)
        //{
        //    for(int i=0; i < inputArray.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < inputArray.GetLength(1); j++)
        //        {
        //            Console.Write(inputArray[i, j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
