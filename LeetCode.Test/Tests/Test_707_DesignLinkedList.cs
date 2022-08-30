namespace LeetCode.Test;

[TestClass]
public class Test_707_DesignLinkedList
{
    [TestMethod]
    public void TestAllMethods()
    {
        MyLinkedList myLinkedList = new MyLinkedList();
        myLinkedList.AddAtHead(1);
        myLinkedList.AddAtTail(3);
        myLinkedList.AddAtIndex(1, 2);    // linked list becomes 1->2->3
        Assert.AreEqual(2, myLinkedList.Get(1));              // return 2
        myLinkedList.DeleteAtIndex(1);    // now the linked list is 1->3
        Assert.AreEqual(3, myLinkedList.Get(1));              // return 3
    }
}