using System;

public class Program{

    // Returns index of number if it is present in
    // arr[low..high], else return -1
    public static int BinarySearch(int[] list, int low, int high, int number){

        if(high >= low){

            int mid = low + (high - low)/2;

            // If the element is present at the
            // middle itself
            if(mid == number){
                return mid;
            }

            // If element is smaller than mid, then
            // it can only be present in left subarray
            if(list[mid] > number){
                return BinarySearch(list, low, mid - 1, number);
            }

            // Else the element can only be present
            // in right subarray
            return BinarySearch(list, mid + 1, high, number);
        }

        // We reach here when element is not present
        // in array
        return -1;
    }

    public static void Main(string[] args){


        int[] array = { 2, 3, 4, 10, 40 };
        int n = array.Length;
        int x = 10;
 
        int result = BinarySearch(array, 0, n - 1, x);
 
        if (result == -1)
            Console.WriteLine("Element not present");
        else
            Console.WriteLine("Element found at index "
                              + result);   
    }

}
