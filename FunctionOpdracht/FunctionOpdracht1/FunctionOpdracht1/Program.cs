﻿using System;

namespace FunctionOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //eerst even uit de static ontsnappen
            Program program = new Program();

            program.Run();
            program.ShowThis("this text has been shown");
        }

        private void Run()
        {
            Console.WriteLine("function run reporting!");
        }


        private void ShowThis(string showThisText)
        {
            Console.WriteLine(showThisText);
        }
    }
}