#include <iostream>
using namespace std;

void SwapAlternates(int arr[], int n)
{
    for(int i = 0; i < n -1; i += 2)
    {
        arr[i] = arr[i] + arr[i + 1];
        arr[i + 1] = arr[i] - arr[i + 1];
        arr[i] = arr[i] - arr[i + 1]; 
    }
}

int main()
{
    int arr[5] = {1, 2, 7, 8, 5};

    SwapAlternates(arr, 5);

    for(int i = 0; i < 5; i++)
    {
        cout << arr[i] << " ";
    }
    cout << endl;

    int arr2[6] = {1, 2, 3, 4, 5, 6};

    SwapAlternates(arr2, 6);

    for(int i = 0; i < 6; i++)
    {
        cout << arr2[i] << " ";
    }

    return 0;
}