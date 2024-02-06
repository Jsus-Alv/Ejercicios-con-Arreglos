using System;

class Program 
{
  public static void Main (string[] args) 
  {
    /* 2. Leer 10 enteros, almacenarlos en un arreglo y 
    determinar en qué posición del arreglo está el mayor número par leído. */

    int[] nums = new int[10];

    //Para almacenar los elementos en el arreglo
    for (int x = 0; x < 10; x++)
    {
        Console.Write($"Ingrese el numero {x + 1}: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            nums[x] = num;
        }
        else
        {
            Console.WriteLine("El numero ingresado no es un numero valido.");
            x--;
        }
    }

    //Para determinar en donde esta el numero par mayor
    int parmayor = -1;
    for (int i = 0; i < 10; i++)
    {
      if (nums[i] % 2 == 0)
      {
        if ((parmayor == -1) || (nums[i] > nums[parmayor]))
        {
            parmayor = i;
        }
      }
     
    }

    if (parmayor != -1)
    {
        Console.WriteLine($"El mayor numero par es {nums[parmayor]}");
        Console.WriteLine($"Se encuentra en la posicion {parmayor + 1} del arreglo");
    }
    else //Usado por si no hay ningun numero par
    {
        Console.WriteLine("El arreglo no tiene ningun numero par");
    }

  }
} 