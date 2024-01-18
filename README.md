# C# Sliding Window Demo

 Find the Sub-Array with Maximum Sum

This repository contains a C# implementation of the GetMaxSumOfSubArray function, which efficiently finds the sub-array with the maximum sum within a given array.

## Overview

The GetMaxSumOfSubArray function employs a sliding window technique to traverse the array and track the sub-array with the highest sum. Here's a breakdown of its key steps:

Code:

```csharp
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
```

1. **Initialization:**
   - Sets a maximum sum variable `maxSum` to 0.
   - Initializes a current window sum variable `currentWindowSum` to 0.
   - Determines the starting index of the current window (`currentWindowStart`).

2. **Sliding Window:**
   - Iterates through the array using a `for` loop.
   - In each iteration:
     - Adds the current element to `currentWindowSum`.
     - If the window size has been reached:
       - Compares `currentWindowSum` with `maxSum` and updates `maxSum` if necessary.
       - Subtracts the element at the beginning of the window from `currentWindowSum`.
       - Advances the window start index (`currentWindowStart`).

3. **Return Result:**
   - Returns the `maxSum` value, representing the maximum sum found within any sub-array.

## Complexity

- Time Complexity: O(n), where n is the length of the array.
- Space Complexity: O(1), as it uses a constant amount of extra space.
