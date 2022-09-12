namespace LeetCode;

public class Problem_392_IsSubsequence
{
    public bool IsSubsequence(string s, string t)
    {
        if (t.Length < s.Length) return false;

        int j = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == s[j]) j++;
            if (j == s.Length) return true;
        }

        return j == s.Length;
    }
}