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
            int searchOutput = linkedListOperations.Search(30);
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
            int searchOutput = list2.Search(30);
            list2.InsertAtParticularPosition(searchOutput + 1, 40);
            Node temp1 = list1.head;
            Node temp2 = list2.head;
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

    }
}