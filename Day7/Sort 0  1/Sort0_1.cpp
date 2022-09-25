#include<algorithm>

using namespace std;

class Solution{
  public:
    
    // A[]: input array
    // N: input array
    //Function to sort the binary array.
    void binSort(int A[], int N)
    {
       //Your code here
       
       /**************
        * No need to print the array
        * ************/
        int i = 0, j = N - 1;
        
        while(i <= j)
        {
            if(A[i] == 1)
            {
                while(A[j] == 1)
                {
                    j--;
                }
                
                if(i <= j)
                {
                    swap(A[i], A[j]);
                    i++;
                    j--;
                }
            }
            else
            {
                while(A[i] == 0)
                {
                    i++;
                }
            }
        }
    }
};