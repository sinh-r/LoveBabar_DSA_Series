# Square Root

You are given an number. You need to find the square root of that number excluding the decimal parts.

**Example 1:**

**Input:** n=4,
**Output:** 2

**Example 2:**

**Input:** n=6
**Output:** 2

**Constraints:**

-   `1 <= N <= 10^16`

## Approach

### Notes
Here we can use **Binary Search** to find the integer part.
Here the number can go as big as 10^16 so we cannot **store it in an integer.**

So for `beg` and `end` we can use **unsigned int** and for `ans` we can use `long`
 
### Steps
1. Initialize `beg = 1` , `end = n` and `ans = -1`
2. Run loop till `beg <= end` 
3. Find ans by `ans  =  beg  + ((end  -  beg)/  2);`
4. `if  ans * ans == n` then `return ans`
5. `else if ans * ans > n` then `end = ans - 1`
6. `else` then `beg = ans + 1`
7. Check `if ans < 0 ` then `return 0`
8. Check `if ans * ans > n` then `return ans - 1`
9. `else  return ans`



