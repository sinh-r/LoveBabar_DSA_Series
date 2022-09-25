# Intersection Of Two Sorted Arrays

Given **two sorted arrays in non-decreasing order**. You  have to find the intersection of the 2.

**Example 1:**

**Input:** n = 6, arr = [1, 2, 2, 2, 3, 4], m = 4, brr = [2, 2, 3, 3]
**Output:** [2, 2, 3]

**Constraints:**

-   `0 <= N,M <= 10^5`
-   `0 <= arr[i],brr[i] <= 10^5`


## Approach

### Steps
1. Initialize `ans = Empty list, i= 0, j = 0`
2. Run the loop till `i < m and j < m`
3. If `arr[i] > brr[j]` then `j++`
4. Else if `arr[i] < brr[j]` then `i++`
5. Else **add the element to the ans and then `i++; j++;`**
6. `return ans`

