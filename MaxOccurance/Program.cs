using System;

namespace MaxOccurance
{
    class Program
    {
        // https://edabit.com/challenge/vtdfueRCmpRGyLAGs
        // UNFINISHED

        static void Main(string[] args)
        {
            CalcMax calc = new("Computer Science"); // "EDABIT" -> no-reoccurence-test
            calc.PopulateDictionary();
            if (!calc.IsReoccuring()) Console.Write("No Reoccurence");
            else
            {
                calc.GetHighValueWithKey();
                calc.IsHighestValue();
                var chars = calc.GetChars();
                foreach(var @char in chars)
                {
                    Console.Write(@char);
                }

            }

        }
    }
}
