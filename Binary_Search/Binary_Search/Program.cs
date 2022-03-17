using System;

public class Program{

    public static void Main(string[] args){

        
    }

    static int BinarySearch(int[] list, int number, int low, int high){

        if(high >= low){

            int mid = low + (high - low)/2;

            if(list[mid] == x){
                return mid;
            }

            if(list[mid] > number){
                return BinarySearch(list, low, mid - 1, number);
            }

            return BinarySearch(list, mid + 1, high, number);
        }

        return -1;
    }
}
