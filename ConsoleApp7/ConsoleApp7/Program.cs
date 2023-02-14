using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseCase-1
            var dict = new string[]{"cat", "offers", "office", "salvages", "police", "salvages",
            "slaves"};
            var note1 = "iecffo";
            Console.WriteLine(FindWordInNotes(dict, note1));
            var note2 = "sslaavge";
            Console.WriteLine(FindWordInNotes(dict, note2));
            var note3 = "tbaykkjlga";
            Console.WriteLine(FindWordInNotes(dict, note3));


            //UseCase-2
            int[,] arr = { { 2, 3, 1 },{ 1, 2, 3 },
                { 3, 1, 2 }};
            int arrLen = arr.GetLength(0);

            Console.WriteLine(VerifyMatrix(arr, arrLen) == 1 ? "true" : "false");
            int[,] arr2 = { { 1, 2, 3 },{ 3, 2, 1 },
                { 3, 1, 2 }};
            int arrLen2 = arr.GetLength(0);

            Console.WriteLine(VerifyMatrix(arr2, arrLen2) == 1 ? "true" : "false");
        }

        static string FindWordInNotes(string[] arr, string scrambledWord)
        {
            var matchingWord = "_";
            var wordInNote = string.Join("", scrambledWord.OrderBy(x=>x));
            foreach (var word in arr)
            {
                var wordInArr = string.Join("", word.OrderBy(x => x));

                if (wordInArr.Length == wordInNote.Length && wordInArr.Contains(wordInNote))
                {
                    matchingWord = word;
                    break;
                }
            }
            return matchingWord;

        }
        static int VerifyMatrix(int[,] arr,int arrLen)
        {
            var row = new HashSet<int>();
            var col = new HashSet<int>();

            var flag = 1;
            for (var i = 0; i < arrLen; i++)
            {
                row.Clear();
                col.Clear();
                for (var j = 0; j < arrLen; j++)
                {
                    col.Add(arr[j, i]);
                    row.Add(arr[i, j]);
                }
                
                if (col.Count != arrLen
                    || row.Count != arrLen )
                    flag = 0;
            }
            return flag;
        }

        
    }
}
