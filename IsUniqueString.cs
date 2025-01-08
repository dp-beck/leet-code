using System;
using System.Collections.Concurrent;

namespace leet_code;

public class IsUniqueStringSolution
{

    // Implement a function to determine if a string has all unique characters.
    public bool IsUniqueString(string str)
    {
        var charDict = new Dictionary<char, int>();
        foreach (var character in str)
        {
            if (charDict.ContainsKey(character))
            {
                return false;
            }
            else
            {
                charDict[character] = 1;
            }
        }
        return true;
    }
}
