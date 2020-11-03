using GrokkingAlgorithmsExercises;
using NUnit.Framework;

namespace GrokkingAlgorithmsExercisesTests
{
    public class Tests
    {
        [TestCase(new int[] { }, ExpectedResult = 0)]
        [TestCase(new int[] { 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2 }, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 2, 4, 1000000000 }, ExpectedResult = 1000000007)]
        public int Sum(int[] input)
        {
            var ch4 = new Chapter4();

            return ch4.Sum(input);
        }

        [TestCase(new int[] { }, ExpectedResult = 0)]
        [TestCase(new int[] { 0 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 4, 5, 43241 }, ExpectedResult = 5)]
        public int Count(int[] input)
        {
            var ch4 = new Chapter4();

            return ch4.Count(input);
        }

        [TestCase(new int[] { }, ExpectedResult = null)]
        [TestCase(new int[] { 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { 1, 3, 5 }, ExpectedResult = 5)]
        [TestCase(new int[] { 5, 3, 1 }, ExpectedResult = 5)]
        [TestCase(new int[] { 1, 2, 4, 5, 43241 }, ExpectedResult = 43241)]
        [TestCase(new int[] { 1, 2, 6, 4, 5, 1 }, ExpectedResult = 6)]
        [TestCase(new int[] { 1, 1, 1, 1, 6, 1, 2, 3 }, ExpectedResult = 6)]
        public int? Max(int[] input)
        {
            var ch4 = new Chapter4();

            return ch4.Max(input);
        }
    }
}