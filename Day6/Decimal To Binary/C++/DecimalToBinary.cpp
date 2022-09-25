#include <iostream>
#include <math.h>
#include <cmath>

using namespace std;

int main()
{
    long n;
    cin >> n;

    long ans = 0;
    long count = 0;

    while(n != 0)
    {
        long bit = n & 1;
       
       ans += (bit * ceil(pow(10,count))); 
        
        count++;        
        n = n >> 1;
    }

    cout << ans;
    return 0;
}