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

            var uniquesDictionary = GetUniquesCollectionChars(val);

            foreach (var keyValue in uniquesDictionary)
            {
                if (keyValue.Value)
                {
                    return keyValue.Key;
                }
            }

            return null;
        }

        private static Dictionary<char, bool> GetUniquesCollectionChars(string val)
        {
            var countDictionary = new Dictionary<char, bool>();
            foreach (var c in val)
            {
                if (c == ' ') continue;

                if (!countDictionary.ContainsKey(c))
                {
                    countDictionary.Add(c, true);
                }
                else
                {
                    countDictionary[c] = false;
                }
            }

            return countDictionary;
        }
    }
}
