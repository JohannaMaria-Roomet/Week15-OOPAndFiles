using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Present
        {
            string character;
            string christmasPresent;

            public Present(string _character, string _christmasPresent)
            {
                character = _character;
                christmasPresent = _christmasPresent;
            }

            //getters for Present

            public string Character
            {
                get { return character; }
            }

            public string ChristmasPresent
            {
                get { return christmasPresent; }
            }
        }
        static void Main(string[] args)
        {
            List<Present> myPresents = new List<Present>();
            string[] presentsFromFile = GetDataFromFile();

            foreach (string line in presentsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Present newPresent = new Present(tempArray[0], tempArray[1]);
                myPresents.Add(newPresent);
            }

            foreach (Present presentFromList in myPresents)
            {
                Console.WriteLine($"{presentFromList.Character} wants {presentFromList.ChristmasPresent} for Christmas.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"...";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
