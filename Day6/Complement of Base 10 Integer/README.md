# Complement of Base 10 Integer


The  **complement**  of an integer is the integer you get when you flip all the  `0`'s to  `1`'s and all the  `1`'s to  `0`'s in its binary representation.

-   For example, The integer  `5`  is  `"101"`  in binary and its  **complement**  is  `"010"`  which is the integer  `2`.

Given an integer  `n`, return  _its complement_.

**Example 1:**

**Input:** n = 5
**Output:** 2
**Explanation:** 5 is "101" in binary, with complement "010" in binary, which is 2 in base-10.

**Example 2:**

**Input:** n = 7
**Output:** 0
**Explanation:** 7 is "111" in binary, with complement "000" in binary, which is 0 in base-10.

**Example 3:**

**Input:** n = 10
**Output:** 5
**Explanation:** 10 is "1010" in binary, with complement "0101" in binary, which is 5 in base-10.

**Constraints:**

-   `0 <= n < 10^9`

## Approach

### Important
These approach do not consider when `n = 0` so you have to add a condition for this

### Approach 1
#### Note 
1. We can get the right most bit by `n & 1`
2. Now in order to invert it what we can do is perform **XOR with 1** as
	2.1.  `0 ^ 1 = 1`
	2.2. `1 ^ 1 = 0`
3. As we are getting the right most bit we can direct multiply it with 2^(its position) to get its base 10 value.
#### Steps
1. Initialize `ans = 0` and `count = 0`
2. Run the loop unless `n != 0`
3. We need to get the inverted bit by `bit = (n & 1) ^ 1`
4. Then `ans = ans + (bit * pow(2, count))`
5. Update `count` by `count++` and `n` by `n = n >> 1`


### Approach 2
#### Note 
Suppose we take the complement of the number.
Here lets say its 5. Then ~5 as per 4 bytes representation is:
~`00000000000000000000000000000101` = `11111111111111111111111111111010`

Now are last 3 bits are the desired answer that we wan but not remaining 1's as it will convert the number to negative.
If we can create a mask like `00000000000000000000000000000111` and perform ***AND*** operation with ~5 then the answer that we get is:
`11111111111111111111111111111010` & `00000000000000000000000000000111` = `00000000000000000000000000000010` = `2`.
Which is our answer.
##### How to create mask
Lets again take number 5 = `00000000000000000000000000000101`
Now we know that we need 3 1's for this.
And here if we perform 3 times right shift what we will get here is 0.

So if we initialize `mask = 0` which actually in 32 bit representation will be `00000000000000000000000000000000` and every time we perform **RIGHT SHIFT** on 5 we perform **LEFT SHIFT** along with **OR with 1** then we can get our mask.

**Example**
1. Let `n = 5` and `mask = 0`
2. Iterate till `n != 0`
3. **1st Iteration**
	3.1. Left shift mask and OR with 1 => `mask =  00000000000000000000000000000001`
	3.2 Right shift n => `n = 00000000000000000000000000000010`
4. **2nd Iteration**
	4.1.  Left shift mask and OR with 1 => `mask =  00000000000000000000000000000011`
	4.2. Right shift n => `n = 00000000000000000000000000000001`
5. **3rd Iteration**
	5.1. Left shift mask and OR with 1 => `mask =  00000000000000000000000000000111`
	5.2 Right shift n => `n = 00000000000000000000000000000000`
6. Now `n = 0` and we got our `mask =  00000000000000000000000000000111`

#### Steps
1. Initialize `mask = 0` and `m = n`
2. Run the loop unless `m != 0`
3. Get the mask using `mask = (mask << 1) | 1`
4. Update `m` by `m = m >> 1`
5. Return `ans = (~n) & mask`
