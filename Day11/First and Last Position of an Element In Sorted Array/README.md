# First and Last Position of an Element In Sorted Array

Given a sorted array in increasing order. The array may also contain repeated elements.
Find the first and last occurrence of that element of that array.

**Example 1:**

**Input:** n = 6, x = 3,  arr = [0, 5, 5, 6, 6, 6]
**Output:** -1, -1

**Example 2:**

**Input:** n = 8, x = 2,  arr = [0, 0, 1, 1, 2, 2, 2, 2]
**Output:** 4, 7

**Constraints:**

-   `1 <= N <= 10^6`
-   `0 <= A[i] <= 10^5`


## Approach

### Steps
1. Initialize `beg = 0` , `end = n - 1` and `ans = -1`
2. Run loop till `beg <= end`
3. Find mid by `int  mid  =  beg  + ((end  -  beg)/  2);`
4. `if(arr[mid] ==  x)` then `ans  =  mid` and `end  =  mid  -  1` if you want to find first element else `beg  =  mid  +  1`
5. `if(arr[mid] >  x)` then `end  =  mid  -  1`
6. `else` then `beg  =  mid  +  1`
7. `return ans`
8. Perform this two times for first and for last and return `[first, last]`

