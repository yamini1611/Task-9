using System;

public class Arrays
{
    public static void Main() 
    {
        int i, j;

        int[,] arr1 = new int[3, 3];

        Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
        Console.Write("-----------------------------------------\n");

        Console.Write("Input elements in the matrix 3x3 :\n");

        for (i = 0; i < 3; i++) 
        {
            for (j = 0; j < 3; j++) 
            {
                Console.WriteLine($"elements in array {i} and {j}");
                arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                
            }
        }

        Console.Write("\nThe matrix is : \n");
        for (i = 0; i < 3; i++) 
        {
            for (j = 0; j < 3; j++) 
            {
                Console.Write($"{arr1[i, j]} \t"); 
            }
            Console.Write("\n");
        }

        Console.ReadLine(); 
    }
}
