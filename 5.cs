using System;

class Program 
{
  public static void Main (string[] args) 
  {
    /* 5. Leer 10 números enteros, almacenarlos en un arreglo y 
    determinar en qué posición se encuentra el número primo con 
    mayor cantidad de dígitos pares */

    int[] nums = new int[10];

    //Arreglo principal
    for (int x = 0; x < 10; x++)
    {
      int num;
      bool numValido = false;

      do
      {
        Console.Write($"Ingrese el numero {x + 1}: ");
        if (int.TryParse(Console.ReadLine(), out num))
        {
          numValido = true;
        }
        else
        {
          Console.WriteLine("El numero ingresado no es un numero valido");
        }
      } 
      while (!numValido);

      nums[x] = num;
    }

    int MayorPrimo = MayorPrimoConDigitosPares(nums);
    Console.WriteLine("El numero primo con la mayor cantidad de digitos pares");
    Console.WriteLine($"se encuentra en la posicion {MayorPrimo + 1}");
    
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

  //Para determinar la cantidad de digitos pares por numero
  static int ContarDigitosPares(int num)
  {
    int count = 0;

    while (num != 0)
    {
      int dig = (num % 10);
      if ((dig % 2) == 0)
      {
        count++;
      }

      num /= 10;
    }

    return count;
  }

  //Para determinar el numero primo con mayor cantidad de digitos pares
  static int MayorPrimoConDigitosPares(int[] nums)
  {
    int MayorPrimo = -1;
    int MaxDigitosPares = -1;

    for (int x = 0; x < nums.Length; x++)
    {
      int num = nums[x];
          
      if (EsPrimo(num))
      {
        int digitosPares = ContarDigitosPares(num);

        if (digitosPares > MaxDigitosPares)
        {
          MaxDigitosPares = digitosPares;
          MayorPrimo = x;
        }
      }
    }

    return MayorPrimo;
  }
} 
