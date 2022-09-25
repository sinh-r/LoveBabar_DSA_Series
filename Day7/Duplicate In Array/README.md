# Duplicate In Array

Given an array of size N. The array contains elements from 1 to N-1. One element of that array is duplicate. Find that duplicate element.

**Example 1:**

**Input:** n = 5, arr = [4, 2, 1, 3, 1]
**Output:** 1

**Example 2:**

**Input:** n = 7, arr = [6, 3, 1, 5, 4, 3, 2]
**Output:** 3

**Example 3:**

**Constraints:**

-   `0 <= N <= 10^5`


## Approach

### Notes
 We know that array will have 1 to N - 1 elements.
 Considering the example `n = 5, arr = [4, 2, 1, 3, 1]`
 If we can XOR every element except that duplicate then we can find the answer.
 To do this we can use another array like `[1, 2, 3, 4]`
 Now  `[4, 2, 1, 3, 1] ^ [1, 2, 3, 4]` every element will get canceled and the duplicate element will remain as `a ^ a ^ a = a`
 Here it is **1**.

### Steps
1. Initialize `ans = 0`
2. Iterate over array and **XOR every element**
3. Run a loop from 1 to N - 1 i.e. `i = 1; i < N` and **XOR with i**
4. `return ans`

