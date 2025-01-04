using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leet_code
{
    // Given two strings ransomNote and magazine, return true if ransomNote 
    // can be constructed by using the letters from magazine and false otherwise.

    // Each letter in magazine can only be used once in ransomNote.

 
    public class RansomNote
    {
        public bool CanConstruct (string ransomNote, string magazine)
        {
            Dictionary<char, int> magazineDict = new Dictionary<char, int>();
            foreach (char c in magazine)
            {
                if (magazineDict.ContainsKey(c))
                {
                    magazineDict[c]++;
                }
                else
                {
                    magazineDict.Add(c, 1);
                }
            }

           
            foreach (char c in ransomNote)
            {
                if (magazineDict.ContainsKey(c))
                {
                    if (magazineDict[c] <= 0) return false;
                    magazineDict[c]--;
                }
                else
                {
                    return false;
                }
            }

            return true; 

        }   
    }
}