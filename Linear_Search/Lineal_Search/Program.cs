using System;

public class Program{

    public static void Main(string[] args)
    {

        // Varibles
        int[] numberList_1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] numberList_2 = { 100, 24, 3, 54, 885, 69, 4447, 38, 19, 120 };

        // Testing number in order
        LinealSearch(numberList_1, 7);

        // Testing number ramdom order
        LinealSearch(numberList_2, 54);

        // Testing number dont exist
        LinealSearch(numberList_1, 100);

    }

    // Lineal Search Method
    public static int LinealSearch(int[] list, int number){

        for (int i = 0; i < list.Length; i++){

            if(list[i] == number){
                Console.WriteLine("Number "+ number + " found");
                return list[i];
            }
        }

        Console.WriteLine("Number " + number + " not found.");
        return -1;
    }

}
