using System;
using Xunit;

namespace ArrayExercises.Tests
{
    public class ArrayHelperTests
    {
        [Fact]
        public void Frequencies_WhenInputArrayIsNull_ReturnsAnEmptyArray()
        {
            // prepare data
            int[] input = null;

            // act
            int[] result = ArrayHelper.Frequencies(input);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void Frequencies_WhenInputArrayIsEmptyArray_ReturnsAnEmptyArray()
        {
            // prepare data
            int[] input = new int[0];

            // act
            int[] result = ArrayHelper.Frequencies(input);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void Frequencies_WhenInputArrayIsSpecified_ReturnsExpectedResults()
        {
            int[] input = { 1, 2, 3, 1, 5, 3, 3, 2, 10 };
            int[] expectedResult = { 2, 2, 3, 2, 1, 3, 3, 2, 1 };

            // act
            int[] result = ArrayHelper.Frequencies(input);

            // assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Frequencies_WhenInputArrayIsSpecified_ReturnsExpectedResults2()
        {
            int[] input = { 1, 1, 1 };
            int[] expectedResult = { 3, 3, 3 };

            // act
            int[] result = ArrayHelper.Frequencies(input);

            // assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CartesianProduct_WhenBothOfTheInputsAreNull_ReturnsAnEmptyArray()
        {
            int[] array1 = null;
            int[] array2 = null;

            // act
            int[][] result = ArrayHelper.CartesianProduct(array1, array2);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void CartesianProduct_WhenInput1IsNullAndInput2IsNotNull_ReturnsAnEmptyArray()
        {
            int[] array1 = null;
            int[] array2 = { 4, 5, 6 } ;

            // act
            int[][] result = ArrayHelper.CartesianProduct(array1, array2);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void CartesianProduct_WhenInput1IsNotNullAndInput2IsNull_ReturnsAnEmptyArray()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = null;

            // act
            int[][] result = ArrayHelper.CartesianProduct(array1, array2);

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void CartesianProduct_WhenInput1IsNotNullAndInput2IsNotNull_ReturnsExpectedResults()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[][] expected = new int[9][]
            {
                new[] { 1, 4 },
                new[] { 1, 5 },
                new[] { 1, 6 },
                new[] { 2, 4 },
                new[] { 2, 5 },
                new[] { 2, 6 },
                new[] { 3, 4 },
                new[] { 3, 5 },
                new[] { 3, 6 },
            };

            // act
            int[][] result = ArrayHelper.CartesianProduct(array1, array2);

            // assert
            Assert.Equal(expected, result);
        }

    }
}
