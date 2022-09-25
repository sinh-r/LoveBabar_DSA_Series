# Search In Rotated Sorted Array

You are give **a sorted array**.  This array **does not have any duplicate elements**. The array will be **rotated towards right by some numbers**. You need to find whether in this array that **element is present or not**.
If it is present then return its index else return -1.

**Example 1:**

**Input:** n=4, k=3, arr = [8, 9, 4, 5]
**Output:** -1

**Example 2:**

**Input:** n=7, k=2, arr = [2, 4, 5, 6, 8, 9, 1]
**Output:** 0

**Constraints:**

-   `3 <= arr.length <= 10^5`
-   `0 <= arr[i] <= 10^6`

## Approach

### Notes
As this array is **sorted and rotated** so in order to work with this we need to find its **pivot**.
Pivot element is that element from where the array was rotated. For example for `arr = [8, 9, 2, 4, 5, 6, 7] ` the **pivot are 9 and 2**.

You can imagine this array as 2 separate lines where 1st line consists of `[8, 9, 2]` and 2nd line consists of `[4, 5, 6, 7]`
Here we will do this by finding the 1st element of 2nd line.

To do this we have to follow these steps mentioned below
### Steps
#### Steps to find Pivot(arr, n)
1. Initialize `beg = 0` , `end = n - 1` and `ans = -1`
2. Run loop till `beg < end` **This condition is important dont make it `beg <= end` otherwise it will be stuck in an infinite loop.**
3. Find mid by `int  mid  =  beg  + ((end  -  beg)/  2);`
4. `if(arr[mid] >= arr[0])`  that means that **the mid is present either at the end of line 1 or in between line 1** so we have to `beg = mid + 1` **as we have to get to the end of the 1st line**
5. `else`  we are at line 2 and we have to `end = mid`  **becuase if we do `end = mid - 1` then we may jump to line 1 which do not want to happen**
6. Once loop is completed `return beg`
#### Steps to search(arr, beg, end, k)
1. Perform binary search.
#### Steps to find the number in sorted and rotated array
1. Get `lowerPivot` using `lowerPivot = Pivot(arr, n)`
2. `if  arr[lowerPivot] <= k <= arr[n - 1]` then call `search(arr, lowerPivot, n - 1, k)`. 
3. `else` call `search(arr, 0, lowerPivot,k)`
4. store the call in `ans` and `return ans`



