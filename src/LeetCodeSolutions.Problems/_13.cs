namespace LeetCodeSolutions.Problems._13;

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanValues = new Dictionary<char, int>(){
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int output = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i == s.Length - 1 || romanValues[s[i]] >= romanValues[s[i+1]])
                output += romanValues[s[i]];
            else output -= romanValues[s[i]];
        }

        return output;

    }
}
