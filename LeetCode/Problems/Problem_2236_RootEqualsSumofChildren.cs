namespace LeetCode;

public class Problem_2236_RootEqualsSumofChildren
{
    public bool RootEqualsSumofChildren(TreeNode root)
    {
        return root.val.Equals(root.left.val + root.right.val);
    }
}