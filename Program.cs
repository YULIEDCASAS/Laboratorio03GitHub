﻿using System;

namespace Laboratorio03GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*solicito el nombre del usuario*/
            Console.WriteLine("\nWhat is your name");

            /*Capturo los datos (Nombre y fecha ) en unas variables*/

            var name= Console.ReadLine();
            var date=DateTime.Now;
             /*Funcionalidad que permite imprimir los  resultados por pantallaY*/
            Console.WriteLine($"\nHellow,{name}, on {date:d} at {date:t}! ");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);




        }
    }
}
