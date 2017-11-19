using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingExample
{
    public class Checking
    {
        public List<string> CheckSentence(string sentence)
        {
            List<string> result = new List<string>();
            if (sentence.Length == 0 || sentence == null) return result;

            Dictionary<string, int> map = new Dictionary<string, int>();

            // Replace with Regex
            string[] words = Regex.Replace(sentence, "[^0-9a-zA-Z]+", " ").Trim().ToLower().Split(' ');

            foreach (string word in words)
            {   //check if word exists in dictionary 
                if (map.ContainsKey(word))
                {
                    int count;
                    map.TryGetValue(word, out count);
                    count++;
                    map.Remove(word);
                    map.Add(word, count);
                }
                else
                {
                    map.Add(word, 1);
                }
            }

            // Get Map List with linq
            result = map.Select(v => v.Key + " - " + v.Value.ToString()).ToList();

            return result;
        }
    }
}
