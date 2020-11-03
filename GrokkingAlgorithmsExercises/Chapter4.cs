namespace GrokkingAlgorithmsExercises
{
    /// <summary>
    /// Quick sort.
    /// </summary>
    public class Chapter4
    {
        /// <summary>
        /// Exercise 4.1. Recursive summation.
        /// </summary>
        /// <param name="nums">Input array of ints.</param>
        /// <returns>Sum.</returns>
        public int Sum(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }
            else
            {
                return nums[0] + Sum(nums[1..]);
            }
        }

        /// <summary>
        /// Exercise 4.2. Recursive counting items in a list.
        /// </summary>
        /// <param name="nums">Input array of ints.</param>
        /// <returns>Count of items.</returns>
        public int Count(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return 1;
            }
            else
            {
                return 1 + Count(nums[1..]);
            }
        }

        /// <summary>
        /// Exercise 4.3. Maximum number.
        /// </summary>
        /// <param name="nums">Input array of ints.</param>
        /// <returns>Maximum number.</returns>
        public int? Max(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }
            else if (nums.Length == 2)
            {
                return nums[0] > nums[1] ? nums[0] : nums[1];
            }
            else
            {
                var max = Max(nums[1..]);
                return nums[0] > max ? nums[0] : max;
            }
        }
    }
}
