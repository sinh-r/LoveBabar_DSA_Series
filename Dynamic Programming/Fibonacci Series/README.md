# Fibonacci Series

If we check the Fibonacci Series it goes like this
0, 1, 1, 2, 3, 5, 8, 13, 21, 34..........................

And the **recurence function** goes like this

`f(n) = f(n-1) + f(n-2); f(0) = 0, f(1) = 1`

Lets say we want to call for **f(8)**. The recursive tree will look like this:
```
                                			f(8)
						    /        \
						   f(7)      f(6)
						 /     \    /    \
						f(6)  f(5)  f(5)  f(4)
```

And like this it will go.
And its implementation will look [like this](https://github.com/sinh-r/LoveBabar_DSA_Series/tree/main/Dynamic%20Programming/Fibonacci%20Series/FibonacciWithoutDPCode) 

Now lets take a look again at the call tree
```
                                			f(8)
						    /        \
						   f(7)      f(6)
						 /     \    /    \
						f(6)  f(5)  f(5)  f(4)
```

If you notice **at  *level 1* we are calculating *f(6)* and we are calulating it again at *level 2***.
Ideally we **should not calculate it again**. Because we are wasting our time computing the same thing again and again.

So there should be a way to store it. That storing it is what we call ***Memoization***.

**Saving the answer of smaller problem/ sub problem to use it in future for a bigger problem is called *Memoization*. **

[Link for TopDown folder](https://github.com/sinh-r/LoveBabar_DSA_Series/tree/main/Dynamic%20Programming/Fibonacci%20Series/FibonacciWithDPCode/TopDown)

**Now lets talk about the Bottom Up Approach**
1. Create the array
2. After this you need to initialize the starting values like `dp[0] = 0` and `dp[1] = 1`
3. Now we will start from the begining i.e. from 2 in our case and we will start calculating the value of dp[i] by `dp[i] = dp[i-1] + dp[i-2]`
4. Then we will return dp[n]

[Link for BottomUp folder](https://github.com/sinh-r/LoveBabar_DSA_Series/tree/main/Dynamic%20Programming/Fibonacci%20Series/FibonacciWithDPCode/BottomUp)

**Optimization of space**
In order to optimize our memory usage instead of using a whole array we can go for using only **2 variables**
