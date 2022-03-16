using System;

public class Program{

    public static void Main(string[] args){

        // list
        int[] list_1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15 };

    }

    public static int BinarySearch(int[] list, int number){

        int low = 0; 
        int high = list.Length;
        int mid = list.Length / 2;

        do
        {

            if(list[mid] == number){

                return mid;

            }else if(number > list[mid]){

                low = mid + 1;
                //mid = ;

            }else if(number < list[mid]){

               // high = ;
            }

        } while (list[mid] != number);




    }
}
