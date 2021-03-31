using System.Collections.Generic;

namespace MaxOccurance
{
    public class CalcMax
    {
        private readonly string _string;
        private readonly Dictionary<char, int> LetterPairs;
        private char HighValueKey;
        private int HighValue;

        public CalcMax(string @string) // "Computer Science"
        {
            _string = @string;
            LetterPairs = new();
            HighValue = 0;
        }

        public void PopulateDictionary()
        {
            for(int i = 0; i < _string.Length; i++)
            {
                char c = _string[i];
                if (!LetterPairs.ContainsKey(c)) LetterPairs.Add(c, 1);
                else if (LetterPairs.ContainsKey(c)) LetterPairs[c]++ ;
            }
        }

        public void GetHighValueWithKey()
        {
            foreach(var pair in LetterPairs)
            {
                int x = pair.Value;
                char c = pair.Key;
                if (x > HighValue)
                {
                    HighValue = x;
                    HighValueKey = c;
                }
            }
        }

        public void IsHighestValue()
        {
            LetterPairs.Remove(HighValueKey);
            foreach(var pair in LetterPairs)
            {

            }
        }

        public void IsNoReoccurance()
        {

        }
    }
}
