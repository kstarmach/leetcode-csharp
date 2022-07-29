namespace LeetCode;

public class Problem_226_InvertBinaryTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;

        var temp = root.left;

        root.left = InvertTree(root.right);
        root.right = InvertTree(temp);

        return root;
    }
}