using System;

namespace leet_code;

public class PalindromeNumber
{
    public bool IsPalindrome(int x) {
        string str = x.ToString();
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
