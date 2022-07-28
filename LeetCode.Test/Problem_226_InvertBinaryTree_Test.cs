namespace LeetCode.Test
{
    [TestClass]
    public class Problem_226_InvertBinaryTree_Test
    {
        [TestMethod]
        public void InvertTreeTest()
        {
            var root = TestHelper.GenerateTree(new int?[] { 4, 2, 7, 1, 3, 6, 9 });
            var solution = new Problem_226_InvertBinaryTree();
            var newRoot = solution.InvertTree(root);
            AssertHelper.AssertTree(new int?[] { 4, 7, 2, 9, 6, 3, 1 }, newRoot);
        }
    }
}