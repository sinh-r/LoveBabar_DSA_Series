def binSort(self, A, N): 
        #Your code here
        #No need to print the array
    
        i = 0
        j = N - 1
        
        while i <= j:
            if A[i] == 1:
                while j > 0 and A[j] == 1:
                    j -= 1
                    
                if i <= j:
                    A[i], A[j] = A[j], A[i]
                    i += 1
                    j -= 1
            else:
                while i < N and A[i] == 0:
                    i += 1
