using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main (string[] args)
        {
            List<string> list = Names ();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine (list[i]);
            }
        }

        public static int[] RandomArray ()
        {
            int[] randArray = new int[10];
            Random rand = new Random ();

            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = rand.Next (5, 25);
            }

            int min = randArray[0];
            int max = randArray[0];
            int sum = 0;

            for (int i = 0; i < randArray.Length; i++)
            {
                if (randArray[i] > max)
                {
                    randArray[i] = max;
                }
                if (randArray[i] < min)
                {
                    randArray[i] = min;
                }
                sum += randArray[i];
            }

            Console.WriteLine ("Min: " + min);
            Console.WriteLine ("Max: " + max);
            Console.WriteLine ("Sum: " + sum);

            return randArray;
        }

        public static string TossCoin ()
        {
            string result = "";
            Random rand = new Random ();
            int randNum = rand.Next (0, 2);
            Console.WriteLine ("Tossing a Coin!");

            if (randNum == 1)
            {
                Console.WriteLine ("Heads!");
                result = "Heads!";
            }
            else
            {
                Console.WriteLine ("Tails!");
                result = "Tails!";
            }

            return result;
        }

        public static List<string> Names ()
        {
            List<string> nameList = new List<string> ();
            Random rand = new Random ();

            nameList.Add ("Todd");
            nameList.Add ("Tiffany");
            nameList.Add ("Charlie");
            nameList.Add ("Geneva");
            nameList.Add ("Sydney");

            for (int i = 0; i < nameList.Count; i++)
            {
                int randNum = rand.Next (0, nameList.Count);

                if (randNum != i)
                {
                    string temp = nameList[i];
                    nameList[i] = nameList[randNum];
                    nameList[randNum] = temp;
                }
            }

            Console.WriteLine ("*********************");
            for (int i = 0; i < nameList.Count; i++)
            {
                Console.WriteLine (nameList[i]);
            }
            Console.WriteLine ("*********************");

            List<string> newList = new List<string> ();

            for (int i = 0; i < nameList.Count; i++)
            {
                if (nameList[i].Length > 5)
                {
                    newList.Add (nameList[i]);
                }
            }

            return newList;
        }
    }
}