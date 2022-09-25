def sqrtN(n):

    # Write your code here.
    beg = 1
    end = n
    ans = -1

    while beg <= end:
        ans = beg + (end - beg)// 2

        if ans * ans == n:
            return ans
        elif ans * ans > n:
            end = ans - 1
        else:
            beg = ans + 1

    if ans < 0:
        return 0
    elif ans * ans > n:
        return ans - 1

    return ans
    pass