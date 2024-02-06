using System;

class Program 
{
  public static void Main (string[] args) 
  {
    /* 1. Leer 10 numeros enteros, almacenarlos en un arreglo y 
    determinar en qué posición del arreglo está el mayor número leído */

    int[] nums = new int[10];

    //Para almacenar los elementos en el arreglo
    for (int x = 0; x < 10; x++)
    {
        Console.Write($"Ingrese el número {x + 1}: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            nums[x] = num;
        }
        else
        {
            Console.WriteLine("El numero ingresado no es un número válido.");
            x--;
        }
    }

    //Para determinar en donde esta el nuemro mayor
    int mayor = 0;
    for (int i = 1; i < 10; i++)
    {
        if (nums[i] > nums[mayor])
        {
            mayor = i;
        }
    }

    Console.WriteLine($"El mayor número es {nums[mayor]}");
    Console.WriteLine($"Se encuentra en la posición {mayor + 1} del arreglo.");

  }
}