# Find Unique

Given an array of size N where `N = 2*M + 1`. In this M numbers are repeated twice and a number occurs only once.
Find the number

**Example 1:**

**Input:** n = 7, arr = [2, 3, 1, 6, 3, 2]
**Output:** 1

**Example 2:**

**Input:** n = 5, arr = [2, 4, 7, 2, 7]
**Output:** 4

**Example 3:**

**Input:** n = 9, arr = [1, 3, 1, 3, 6, 6, 7, 10, 7]
**Output:** 10

**Constraints:**

-   `0 <= N <= 10^5`


## Approach

### Notes
 `N = 2*M + 1` means N will always be odd. So every case will have this.
 `a ^ a = 0` 
 `0 ^ a = a`

### Steps
1. Initialize `ans = 0`
2. Iterate whole array
3. `ans = ans ^ arr[i]`
4. Return `ans`

