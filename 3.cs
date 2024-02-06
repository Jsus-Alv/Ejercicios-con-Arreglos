using System;

class Program 
{
  public static void Main (string[] args) 
  {
    /* 3. Leer 10 enteros, almacenarlos en un arreglo y 
    determinar en qué posición del arreglo está el mayor número primo leído */

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
      
    int mayor = -1;
    for (int i = 0; i < 10; i++)
    {
      if (EsPrimo(nums[i])) 
      {
        if (mayor == -1 || nums[i] > nums[mayor])
        {
          mayor = i;
        }
      }
    }

    if (mayor != -1)
      {
          Console.WriteLine($"El mayor numero primo es {nums[mayor]}");
          Console.WriteLine($"Se encuentra en la posicion {mayor + 1} del arreglo");
      }
      else //Usado por si no hay ningun numero par
      {
          Console.WriteLine("El arreglo no tiene ningun numero primo");
      }
    
  }

  // Para determinar si el numero es primo
  static bool EsPrimo(int numprimo)
  {
    if (numprimo < 2)
    {
      return false;
    }
    for (int i = 2; i <= Math.Sqrt(numprimo); i++)
    {
      if (numprimo % i == 0)
      {
        return false;
      }
    }
    return true;
  }
} 
