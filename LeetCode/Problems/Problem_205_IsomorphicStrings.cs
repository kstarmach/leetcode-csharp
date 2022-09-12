namespace LeetCode;

public class Problem_205_IsomorphicStrings
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var s_dict = new Dictionary<char, char>();
        var t_dict = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s_dict.ContainsKey(s[i]) && s_dict[s[i]] != t[i])
            {
                return false;
            }

            if (t_dict.ContainsKey(t[i]) && t_dict[t[i]] != s[i])
            {
                return false;
            }

            s_dict[s[i]] = t[i];
            t_dict[t[i]] = s[i];
        }

        return true;
    }
}