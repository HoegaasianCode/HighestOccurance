using System;

namespace MaxOccurance
{
    class Program
    {
        // https://edabit.com/challenge/vtdfueRCmpRGyLAGs
        // UNFINISHED

        static void Main(string[] args)
        {
            CalcMax calc = new("Computer Science"); // "system admin" ➞ "m, s" | "Computer Science" ➞ "e"
            calc.PopulateDictionary();
            var isReoccuring = calc.IsReoccuring();
            if (isReoccuring) Console.Write("No Reoccurence");
            else
            {
                calc.GetHighValueWithKey();
                var chars = calc.GetChars();
                foreach(var @char in chars)
                {
                    Console.Write(@char);
                }

            }

        }
    }
}
