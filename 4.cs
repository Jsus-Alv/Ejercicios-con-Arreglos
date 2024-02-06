using System;

class Program 
{
  public static void Main (string[] args) 
  {
    /* 4. Leer 10 números enteros, almacenarlos en un arreglo y 
    determinar cuántos números de los almacenados en dicho arreglo 
    comienzan en dígito primo */

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

    //Subarreglo con los primeros digitos de cada numero del arreglo principal
    int[] subArr = new int[10];
    for (int x = 0; x < 10; x++)
    {
      subArr[x] = nums[x] / 10;
    }

    //Contador
    int count = 0;
    for (int i = 0; i < 10; i++)
    {
      if (EsPrimo(subArr[i])) 
      {
        count++;
      }
    }
    
    Console.WriteLine($"Hay {count} numeros que comienzan con un digito primo");
    
    for (int x = 0; x < subArr.Length; x++)
    {
      Console.WriteLine($"Elemento {x + 1} del subarreglo: {subArr[x]}");
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
