using System.Collections.Generic;

namespace ArrayString
{
    public static class StringExtensions
    {
        public static char? FirstNonRepeatedChar(this string val)
        {
            if (string.IsNullOrWhiteSpace(val)) return null;

            val  = val.Trim();

            if (val.Length <= 1) return val[0];

            var countDictionary = CountChars(val);

            foreach (var keyValue in countDictionary)
            {
                if (keyValue.Value <= 1)
                {
                    return keyValue.Key;
                }
            }

            return null;
        }

        private static Dictionary<char, int> CountChars(string val)
        {
            var countDictionary = new Dictionary<char, int>();
            foreach (var c in val)
            {
                if (c == ' ') continue;

                if (!countDictionary.ContainsKey(c))
                {
                    countDictionary.Add(c, 1);
                }
                else
                {
                    countDictionary[c]++;
                }
            }

            return countDictionary;
        }
    }
}
