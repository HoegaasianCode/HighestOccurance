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

        public CalcMax(string @string) // "Computer Science"
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

        public bool IsReoccuring()
        {
            if (HighValue > 1) return true;
            else return false;
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
            bool isEqualValue = true;
            while (isEqualValue)
            {
                LetterPairs.Remove(HighValueKey);
                if (LetterPairs.ContainsValue(HighValue)) CharList.Add(HighValueKey);
                else isEqualValue = false;
            }
        }

        public List<char> GetChars() => CharList;
    }
}
