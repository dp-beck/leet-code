using System;

namespace leet_code;

public class OneAway
{
    public bool OneAwaySolution(string str1, string str2)
    {
        if (str1.Length == str2.Length) return OneEditReplace(str1, str2);
        if (str1.Length + 1 == str2.Length) return OneEditInsert(str1, str2);
        if (str1.Length -1 == str2.Length) return OneEditInsert(str2, str1);
        return false;
    }

    public bool OneEditReplace(string str1, string str2)
    {
        bool foundDifference = false;
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                if (foundDifference) return false;
                foundDifference = true;
            }
        }
        
        return true;
    }

    public bool OneEditInsert(string str1, string str2)
    {
        
        return false;
    }

}
