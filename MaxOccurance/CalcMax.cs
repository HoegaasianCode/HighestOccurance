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

        public CalcMax(string @string) // "system admin" ➞ "m, s"
        {
            _string = @string;
            LetterPairs = new();
            CharList = new();
            HighValue = 0;
        }

        public void PopulateDictionary()
        {
            for(int i = 0; i < _string.Length; i++)
            {
                char c = _string[i];
                if (!LetterPairs.ContainsKey(c)) LetterPairs.Add(c, 1);
                else LetterPairs[c]++;
            }
        }

        public void GetHighValueWithKey()
        {
            foreach(var pair in LetterPairs)
            {
                int x = pair.Value;
                char c = pair.Key;
                if (x > HighValue || x == HighValue && HighValue > 1)
                {
                    HighValue = x;
                    HighValueKey = c;
                    CharList.Add(HighValueKey);
                }
            }
        }

        public bool IsReoccuring()
        {
            if (HighValue > 1) return true;
            else return false;
        }

        public List<char> GetChars() => CharList;
    }
}
