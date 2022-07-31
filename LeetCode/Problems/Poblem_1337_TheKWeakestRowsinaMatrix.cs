namespace LeetCode;

public class Poblem_1337_TheKWeakestRowsinaMatrix
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        return mat
                 .Select(arr => arr.Count(s => s == 1))
                 .Select((v, i) => (v, i))
                 .OrderBy(t => t.v)
                 .Take(k)
                 .Select(t => t.i)
                 .ToArray();

    }

}