using Sorting;
using Xunit;

namespace Tests
{
    public class SortingTest
    {
        [Fact]
        public void Bubble_MassiveIsSorted()
        {
            //Arange
            var actualArray = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
            var expectedArray = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };

            //Action
            Bubble.SortWithBubble(actualArray);

            //Assert
            Assert.Equal(expectedArray, actualArray);
        }

        [Fact]
        public void Bubble_MassiveIsMirrored()
        {
            //Arange
            var actualArray = new double[] { 5.0, 4.0, 3.0, 2.0, 1.0 };
            var expectedArray = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };

            //Action
            Bubble.SortWithBubble(actualArray);

            //Assert
            Assert.Equal(expectedArray, actualArray);
        }

        [Fact]
        public void Bubble_MassiveIsNOTSorted()
        {
            //Arange
            var actualArray = new double[] { 4.0, 3.0, 1.0, 5.0, 2.0 };
            var expectedArray = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };

            //Action
            Bubble.SortWithBubble(actualArray);

            //Assert
            Assert.Equal(expectedArray, actualArray);
        }

        [Fact]
        public void Quick_MassiveIsSorted()
        {
            //Arange
            var actualArray = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
            var expectedArray = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };

            //Action
            Quick.SortWithQuick(actualArray, 0, actualArray.Length - 1);

            //Assert
            Assert.Equal(expectedArray, actualArray);
        }

        [Fact]
        public void Quick_MassiveIsMirrored()
        {
            //Arange
            var actualArray = new double[] { 5.0, 4.0, 3.0, 2.0, 1.0 };
            var expectedArray = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };

            //Action
            Quick.SortWithQuick(actualArray, 0, actualArray.Length - 1);

            //Assert
            Assert.Equal(expectedArray, actualArray);
        }

        [Fact]
        public void Quick_MassiveIsNOTSorted()
        {
            //Arange
            var actualArray = new double[] { 4.0, 3.0, 1.0, 5.0, 2.0 };
            var expectedArray = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };

            //Action
            Quick.SortWithQuick(actualArray, 0, actualArray.Length - 1);

            //Assert
            Assert.Equal(expectedArray, actualArray);
        }
    }
}
