def findPivot(arr, n):
    beg = 0
    end = n - 1
    mid = -1
    
    while beg < end:
        mid = beg + (end - beg)// 2
        
        if arr[mid] >= arr[0]:
            beg = mid + 1
        else:
            end = mid
        
    return beg

def search(arr, beg, end, k):
    mid = -1

    while beg <= end:
        mid = beg + (end - beg)// 2

        if arr[mid] == k:
            return mid
        elif arr[mid] > k:
            end = mid - 1
        else:
            beg = mid + 1

    return -1

def findPosition(arr, n, k):

	# Write your code here
    lowerPivot = findPivot(arr, n)
    ans = -1
    
    if arr[lowerPivot] <= k <= arr[n - 1]:
        ans = search(arr, lowerPivot, n - 1, k)
    else:
        ans = search(arr, 0, lowerPivot- 1, k)

    return ans

    pass