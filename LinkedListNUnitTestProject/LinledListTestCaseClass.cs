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
    }
}