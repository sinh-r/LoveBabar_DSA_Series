# Sort 0 1

Given a **binary array** (consisting only 0 and 1). Sort the given array.

**Example 1:**

**Input:** n = 5, arr = 1 0 1 1 0
**Output:** 0 0 1 1 1

**Constraints:**

-   `1 <= N <= 10^6`
-   `0 <= A[i] <= 1`


## Approach
### Note 
We have to keep two pointers i and j at `i = 0` and `j = N -1`
Now we have to keep in mind that we want **all 0s to the left and all 1s to right**
So if we find `A[i] = 0 and A[j] = 1` then **we will swap and update the pointers**
Else we will simply update the pointers


### Steps
1. Initialize `i = 0` and `j = N - 1`
2. Run the loop till `i <= j`
3. `if  A[i] == 1` then go to step 4 else go to step 6
4. If **step 3 is true** then run the loop for `j--` till `j > 0  and  A[j] == 1`
5. `if i <= j` then swap the numbers and `i++ and j--`
6. If **step 3 is false** then run the loop for `i++` till `i < N  and  A[i] == 0`

