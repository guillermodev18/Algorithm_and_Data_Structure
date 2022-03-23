
using System;

public class Program{

    public static void Main(string[] args){

        int[] arr = { 2, 3, 4, 13, 25, 37, 40, 48 };

        int high = arr.Length;
        int number = 10;

         int result = BinarySearch(arr, 0, high - 1, number);

    }

    static int BinarySearch(int[] list, int number, int low, int high){

        if(high >= low){

            int mid = low + (high - low)/2;

            // If the element is present at the
            // middle itself
            if(list[mid] == number){
                Console.WriteLine("Number found");
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
        Console.WriteLine("Number Not found");
        return -1;
    }
}
