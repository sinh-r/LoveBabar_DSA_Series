# Reverse Integer


Given a signed 32-bit integer  `x`, return  `x` _with its digits reversed_. If reversing  `x`  causes the value to go outside the signed 32-bit integer range  `[-2^31, 2^31  - 1]`, then return  `0`.

**Assume the environment does not allow you to store 64-bit integers (signed or unsigned).**

**Example 1:**

**Input:** x = 123
**Output:** 321

**Example 2:**

**Input:** x = -123
**Output:** -321

**Example 3:**

**Input:** x = 120
**Output:** 21

**Constraints:**

-   `-2^31  <= x <= 2^31  - 1`

## Approach
1. Create a variable as `ans = 0`
2. Run loop till `x != 0`
3. `digit = x % 10`
4. `if (ans > (2**31 - 1) / 10) or (ans < (-2**31) / 10)` then `return 0`
5. else `ans = ans * 10 + digit`
6. ` x = x / 10`
7. Return `ans`

### Note
1. For C++ use **INT_MAX** and **INT_MIN**
2. For C# use **Int32.MaxValue** and **Int32.MinValue**
3. For Python use **sys.maxint** and **sys.minint**
4. In python you may have to check for negative
	4.1. If it is negative then remove the sign and perform the operation 