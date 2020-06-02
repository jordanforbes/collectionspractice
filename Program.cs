using System;
using System.Collections.Generic;

namespace collectionsPractice {
    class Program {
        static void Main (string[] args) {
            int[] intArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] strArr = { "Tim", "Martin", "Nikki", "Sarah" };
            Boolean[] boolArr = new Boolean[] { true, false, true, false, true, false, true, false, true, false };
            List<string> flavors = new List<string> ();
            Dictionary<string,string> info = new Dictionary<string,string>();
            Random rand = new Random();

            flavors.Add ("Vanilla");
            flavors.Add ("Chocolate");
            flavors.Add ("Strawberry");
            flavors.Add ("Cotton Candy");
            flavors.Add ("Mint Chocolate Chip");
            // Console.WriteLine("random: "+rand.Next(0,5));

            for( int i= 0; i < strArr.Length; i ++)
            {
            int max = rand.Next(0, flavors.Count);
            
            info.Add(strArr[i], flavors[rand.Next(0,max)]);
            Console.WriteLine(strArr[i] +" likes "+info[strArr[i]]);
            }
            

            Iterator (intArr);
            Iterator (strArr);
            Iterator (boolArr);
            Iterator (flavors);

        }

        public static void Iterator (int[] args) {
            for (int i = 0; i < args.Length; i++) {
                Console.WriteLine (i);
            }
        }

        public static void Iterator (string[] args) {
            foreach (string name in args) {
                Console.WriteLine (name);
            }
        }

        public static void Iterator (Boolean[] args) {
            foreach (Boolean arg in args) {
                Console.WriteLine (arg);
            }
        }

        public static void Iterator (List<string> args) {
            Console.WriteLine ($"the list is {args.Count} elements long");
            Console.WriteLine ($"the third element in the list is {args[3]}");
            args.RemoveAt (3);
            Console.WriteLine ($"the list is {args.Count} elements long");

        }

        // public static void makeDict(Dictionary<string,string> dict, string[] strArr, List<string> strList )
        // {
        //     Random rand = new Random();

        //     for (int i = 0; i <strArr.Length; i++)
        //     {
        //         dict.Add(strArr[i]);

        //     }

        // }

    }
}