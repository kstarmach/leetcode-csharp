namespace LeetCode.Test
{
    public static class AssertHelper
    {
        public static void AssertTree(int?[] expected, TreeNode actual)
        {
            if (expected == null || expected.Length == 0) Assert.IsNull(actual);
            var expectedTreeRoot = TestHelper.GenerateTree(expected);

            AssertTree(expectedTreeRoot, actual);
        }

        public static void AssertTree(TreeNode expected, TreeNode actual)
        {
            if (expected == null) Assert.IsNull(actual);

            var stack1 = new Stack<TreeNode>();
            stack1.Push(expected);
            var stack2 = new Stack<TreeNode>();
            stack2.Push(actual);

            while (stack1.Count > 0 && stack2.Count > 0)
            {
                var cur1 = stack1.Pop();
                var cur2 = stack2.Pop();
                Assert.AreEqual(cur1.val, cur2.val);
                if (cur1.left == null)
                {
                    Assert.IsNull(cur2.left);
                }
                else
                {
                    stack1.Push(cur1.left);
                    stack2.Push(cur2.left);
                }
                if (cur1.right == null)
                {
                    Assert.IsNull(cur2.right);
                }
                else
                {
                    stack1.Push(cur1.right);
                    stack2.Push(cur2.right);
                }
            }

            Assert.AreEqual(0, stack1.Count);
            Assert.AreEqual(0, stack2.Count);
        }

        public static void AssertTrees(IList<int?[]> expected, IList<TreeNode> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count, "count not match");
            for (int i = 0; i < expected.Count; i++)
            {
                AssertTree(expected[i], actual[i]);
            }
        }
    }
}