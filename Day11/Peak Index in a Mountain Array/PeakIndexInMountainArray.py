class Solution:
    def peakIndexInMountainArray(self, arr) -> int:
        beg = 0
        end = len(arr) - 1
        mid = 0
        
        while beg <= end:
            mid = beg = ((beg + end)// 2)
            
            if(arr[mid - 1] < arr[mid] > arr[mid + 1]):
                return mid
            elif (arr[mid - 1] < arr[mid]):
                beg = mid + 1
            elif (arr[mid - 1] > arr[mid]):
                end = mid - 1
                
        return mid
        