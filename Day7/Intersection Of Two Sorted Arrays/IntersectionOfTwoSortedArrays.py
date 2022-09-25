def findArrayIntersection(arr: list, n: int, brr: list, m: int):
    # Write your code here
    # Return a list containing all the common elements in arr and brr.
    ans = []
    
    i = 0
    j = 0
    while i < n and j < m:
        if arr[i] > brr[j]:
            j += 1
        elif arr[i] < brr[j]:
            i += 1
        else:
            ans.append(arr[i])
            i += 1
            j += 1
    
    return ans
    pass
