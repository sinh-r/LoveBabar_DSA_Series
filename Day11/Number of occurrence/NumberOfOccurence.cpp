#include <iostream>

using namespace std;

int search(int arr[], int n, int x, bool findFirst = true)
{
    int beg = 0, end = n - 1;
    int ans = -1;
    
    while(beg <= end)
    {
        int mid = beg + ((end - beg)/ 2);
        
        cout << mid << endl;
        if(arr[mid] == x)
        {
            ans = mid;
            
            if(findFirst)
            {
                end = mid - 1;
            }
            else
            {
                beg = mid + 1;
            }
        }
        else if(arr[mid] > x)
        {
            end = mid - 1;
        }
        else
        {
            beg = mid + 1;
        }
    }
    
    return ans;
}
	
int count(int arr[], int n, int x) {
    // code here
    cout << "First" << endl;
    int first = search(arr, n, x);
    
    if(first == -1)
    {
        return 0;
    }
    
    cout << "Last" << endl;
    int last = search(arr, n, x, false);
    
    return last - first + 1;
}

int main()
{
    int arr[] = {1, 1, 2, 2, 2, 2, 3};
    int n = 7;
    int x = 4;
    
    cout << count(arr, n, x);

    return 0;
}
