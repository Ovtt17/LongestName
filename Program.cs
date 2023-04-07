/*Escriba un programa que almacene en una lista (tipo List), una serie de nombres. El
programa debe imprimir la longitud del nombre que tiene más caracteres.*/

using System;
using System.Collections.Generic;

namespace LongestName
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> names = new List<string>();

      // Input names and add them to the list
      while (true)
      {
        Console.Write("Enter a name (or 'q' to quit): ");
        string input = Console.ReadLine();

        if (input == "q")
        {
          break;
        }

        names.Add(input);
      }

      // Find the length of the longest name
      int maxLength = 0;
      foreach (string name in names)
      {
        if (name.Length > maxLength)
        {
          maxLength = name.Length;
        }
      }
      
      //print the longest name and length
      foreach (string name in names)
      {
        if (name.Length == maxLength)
        {
          Console.WriteLine($"\n\nThe longest name is: {name}\nThe length of the longest name is: {maxLength}");
        }
      }
    }
  }
}
