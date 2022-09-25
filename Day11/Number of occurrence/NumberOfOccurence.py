def search(self, arr, n, k, findFirst = True):
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

def count(self,arr, n, x):
    # code here
    first = self.search(arr, n, x)

    if first == -1:
        return 0
    
    last = self.search(arr, n, x, False)

    return last - first + 1