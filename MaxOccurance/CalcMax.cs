using System.Collections.Generic;

namespace MaxOccurance
{
    public class CalcMax
    {
        private readonly string _string;
        private readonly Dictionary<char, int> LetterPairs;
        private readonly List<char> CharList;
        private char HighValueKey;
        private int HighValue;
        private bool IsReoccuring;

        public CalcMax(string @string) // "Computer Science"
        {
            _string = @string;
            LetterPairs = new();
            CharList = new();
            HighValue = 0;
            IsReoccuring = false;
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

        public void IsNoReoccurance()
        {
            if (HighValue > 1) IsReoccuring = true;
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
                    CharList.Add(c);
                }
            }
        }

        public void IsHighestValue()
        {
            bool isEqualValue = false;
            LetterPairs.Remove(HighValueKey);
            foreach(var pair in LetterPairs)
            {
                if (pair.Value == HighValue) isEqualValue = true;
            }
        }


    }
}
