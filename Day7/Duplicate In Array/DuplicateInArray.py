def findDuplicate(arr):
    # Write your code here
    ans = 0
    
    for i in range(len(arr)):
        ans = ans ^ arr[i] 
        
    for i in range(1, len(arr)):
        ans = ans ^ i
        
    return ans