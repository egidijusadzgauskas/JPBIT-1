﻿using System;

namespace Mano_darbas_darbas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            int y = int.Parse(Console.ReadLine());
            Parametras(x, y);
            string vardas = Environment.UserName;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(vardas);
            }

        }
       static void Parametras(int a, int b)
       {
           int suma = a + b;
        Console.WriteLine("Ju suma bus {0}",suma);
    }  }
}
