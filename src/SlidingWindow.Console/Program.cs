using System.Runtime.InteropServices;

namespace SlidingWindow
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 8, 9, 4, 3, 1 };
            var result = GetMaxSumOfSubArray(arr, 3);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Gets the sub-array with maximum sum value using a sliding window
        /// </summary>
        /// <param name="arr">The array</param>
        /// <param name="subArrSize">The sub-array size</param>
        /// <returns>The maximum sum of the sub-arrays</returns>
        public static int GetMaxSumOfSubArray(int[] arr, int subArrSize) 
        {
            // Guard against subArrSize being larger than array length
            if (subArrSize > arr.Length)
            {
                return 0;
            }

            int maxSum = 0;
            int currentWindowSum = 0;
            int currentWindowStart = 0;

            // for loop based on the length of the array
            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                // accumulate the sub-window values
                currentWindowSum += arr[windowEnd];

                // when the full sub-array has been accumulated
                if (windowEnd >= subArrSize - 1)
                {
                    // determine if current window sum is > than maxSum
                    maxSum = Math.Max(maxSum, currentWindowSum);
                    // subtract the value of the current window start value
                    currentWindowSum -= arr[currentWindowStart];
                    // increment the current window start
                    currentWindowStart += 1;
                }
            }

            return maxSum;
        }
    }
}
