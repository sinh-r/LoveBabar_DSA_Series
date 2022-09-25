public class Solution 
{
    public int PeakIndexInMountainArray(int[] arr) 
    {
        int beg = 0, end = arr.Length - 1;
        int mid = 0;

        while(beg <= end)
        {
            mid = beg + ((end - beg) / 2);

            if(arr[mid] > arr[mid + 1] && arr[mid] > arr[mid - 1])
            {
                return mid;
            }
            else if(arr[mid] < arr[mid + 1])
            {
                beg = mid + 1;
            }
            else if(arr[mid] > arr[mid + 1])
            {
                end = mid - 1;
            }
        }

        return mid;    
    }
}