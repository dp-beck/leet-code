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
        int index1 = 0;
        int index2 = 0;

        while (index1 < str1.Length && index2 < str2.Length)
        {
            if (str1[index1] != str2[index2])
            {
                if (index1 != index2) return false;
                index2++;
            } else
            {
                index1++;
                index2++;
            }
        }

        return true;
    }

}
