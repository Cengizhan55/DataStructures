﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProject
{
    class MainClass
    {
        static int width;
        static int height;
        static int nValue;

        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("width değeri girin  :  ");
            width = Int32.Parse(Console.ReadLine());
            Console.Write("height değeri girin :  ");
            height = Int32.Parse(Console.ReadLine());
            Console.Write("n değeri girin :  ");
            nValue = Int32.Parse(Console.ReadLine());

            MyMatrix myMatrix = new MyMatrix(width, height, nValue, random);


            myMatrix.PrintMatrix();



            Console.ReadKey();   
        }

         
    }
}
