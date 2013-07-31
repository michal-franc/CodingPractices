using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayString
{
    public static class StringExtensions
    {
        public static string RemoveCharacters(this string inputString, string chars)
        {
            if (string.IsNullOrWhiteSpace(inputString)) return inputString;

            if (chars.Length <= 0) return inputString;

            var charsToRemove = new HashSet<char>();

            chars.All(x => charsToRemove.Add(x));

            var outputString = new StringBuilder();

            foreach (var c in inputString)
            {
                if (!charsToRemove.Contains(c))
                {
                    outputString.Append(c);
                }
            }

            return outputString.ToString();
        }

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
