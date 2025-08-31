namespace BubbleSort.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BubbleTest_Null_ReturnNull()
        {
            int[]? arr = null;
            Bubble.sort(arr, 0);
            Assert.That(arr, Is.Null);
        }
        [Test]
        public void BubbleTest_Empty_ReturnEmpty()
        {
            int[] arr = [];
            Bubble.sort(arr, arr.Length);
            Assert.That(arr, Has.Length.EqualTo(0));
        }
        [Test]
        public void BubbleTest_ArrayWithOneElement_ReturnArrayWithOneElement()
        {
            int[] arr = [4];
            Bubble.sort(arr, arr.Length);
            using (Assert.EnterMultipleScope())
            {
                Assert.That(arr, Has.Length.EqualTo(1));
                Assert.That(arr, Has.Exactly(1).EqualTo(4));
            }
        }
        [Test]
        public void BubbleTest_ArrayWithRangeTo10_ReturnSortedArray()
        {
            int[] arr = [0, 9, 1, 8, 2, 7, 3, 6, 4, 5];
            int[] sortedArr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
            Bubble.sort(arr, arr.Length);
            using (Assert.EnterMultipleScope())
            {
                Assert.That(arr, Has.Length.EqualTo(10));
                Assert.That(arr, Is.EqualTo(sortedArr));
            }
        }
    }
}
