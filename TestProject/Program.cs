using System;
using System.Collections.Generic;
using RTSLabsExercise;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Above Below:");
            foreach(KeyValuePair<string, int> keyval in InputChecker.AboveBelow(new List<int>() { 1, 5, 2, 1, 10 }, 6))
                Console.WriteLine(keyval.Key + ": " + keyval.Value);


            Console.WriteLine("String rotations");
            // original rotation
            Console.WriteLine(InputChecker.StringRotation("MyString", 2));
            // rotation past total string length
            Console.WriteLine(InputChecker.StringRotation("MyString", 10));
        }
    }
}
