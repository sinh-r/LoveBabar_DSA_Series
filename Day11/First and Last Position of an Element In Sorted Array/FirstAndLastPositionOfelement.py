def search(arr, n, k, findFirst = True):
    beg = 0
    end = n - 1
    ans = -1

    while beg <= end:
        mid = beg + ((end - beg)// 2)
        
        if arr[mid] == k:
            ans = mid
            if findFirst:
                end = mid - 1
            else:
                beg = mid + 1
        elif arr[mid] > k:
            end = mid - 1
        else:
            beg = mid + 1

    return ans


def firstAndLastPosition(arr, n, k):
    first = search(arr, n, k)

    if first == -1:
        return [first, first]
    
    last = search(arr, n, k, False)

    return [first, last]

    pass