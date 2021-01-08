using LinkedListSolution;
using NUnit.Framework;

namespace LinkedListNUnitTestProject
{
    public class LinledListTestCaseClass
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenLinkedList_WhenSearchParticularValueOfLinkedList_ShouldReturnPosition()
        {
            LinkedListOperations linkedListOperations = new LinkedListOperations();
            linkedListOperations.AddAtHead(56); linkedListOperations.AddAtHead(30); linkedListOperations.AddAtHead(70);
            int searchOutput = LinkedListOperations.Search(30);
            Assert.AreEqual(1, searchOutput);
        }
        [Test]
        public void GivenValue_WhenSearchLinkedList_ShouldReturnTheListWithValueInsertedNextToTheSearchPosition()
        {
            LinkedListOperations list1 = new LinkedListOperations();
            int list1Count = 0, list2Count = 0;
            list1.AddAtHead(56); list1.AddAtHead(30); list1.AddAtHead(40); list1.AddAtHead(70);
            LinkedListOperations list2 = new LinkedListOperations();
            list2.AddAtHead(56); list2.AddAtHead(30); list2.AddAtHead(70);
            int searchOutput = LinkedListOperations.Search(30);
            list2.InsertAtParticularPosition(searchOutput + 1, 40);
            Node temp1 = LinkedListOperations.head;
            Node temp2 = LinkedListOperations.head;
            while (temp1 != null)
            {
                temp1 = temp1.next;
                list1Count++;
            }
            while (temp2 != null)
            {
                temp2 = temp2.next;
                list2Count++;
            }
            Assert.AreEqual(list1Count, list2Count);
        }
        [Test]
        public void GivenParticularValue_WhenDeleteFromLinkedList_ShouldReturnTheListSize()
        {
            LinkedListOperations list = new LinkedListOperations();
            list.AddAtLast(56); list.AddAtLast(30); list.AddAtLast(40); list.AddAtLast(70);
            list.DeleteNodeByValue(40);
            int expected = 3;
            Assert.AreEqual(expected,list.Size());
        }
    }
}