using NUnit.Framework;

namespace MergeSort.Tests
{
    [TestFixture]
    public class MergeSortTest
    {
        [Test]
        public void MergeSort_GivenUnsortedArray_ArrayIsSorted()
        {
            int[] array = { 7, 54, 11, 5, 64, 48, 3, 76, 1, 21, 19 };
            
            MergeSort1.MergeSort(array);

            Assert.That(array, Is.Ordered);
        }

        [Test]
        public void MergeSort_GivenArrayOfSingleElement_DoNothing()
        {
            int[] array = {0};

            MergeSort1.MergeSort(array);

            Assert.That(array, Has.Exactly(1).EqualTo(0));
        }

        [Test]
        public void MergeSort_GivenEmptyArray_ArrayStillEmpty()
        {
            int[] array = new int[0];

            MergeSort1.MergeSort(array);

            Assert.That(array, Is.Empty);
        }

        [Test]
        public void MergeSort_AlreadySortedArray_ArrayDoesNotChange()
        {
            int[] initialArray = { 1, 2, 3, 4, 5, 6, 7 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };

            MergeSort1.MergeSort(initialArray);

            Assert.That(initialArray, Is.EquivalentTo(expected));
        }
    }
}
