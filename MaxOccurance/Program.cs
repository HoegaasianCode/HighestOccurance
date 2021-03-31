using System;

namespace MaxOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcMax calc = new("Computer Science");
            calc.PopulateDictionary();
            Console.Write(calc.CalculateMax());

        }
    }
}
