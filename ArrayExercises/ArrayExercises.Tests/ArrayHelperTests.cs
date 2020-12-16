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

    }
}
