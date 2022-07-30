namespace LeetCode;

public class Problem_383_RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
            return false;

        List<char> ransomNote_list = new List<char>(ransomNote.Select(c => c));

        for (int i = 0; i < magazine.Length; i++)
        {
            ransomNote_list.Remove(magazine[i]);
        }

        return ransomNote_list.Count() == 0;
    }
}