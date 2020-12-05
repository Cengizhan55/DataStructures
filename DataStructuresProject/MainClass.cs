using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProject
{
    class MainClass
    {
        static void Main(string[] args)
        {

            MyMatrix myMatrix = new MyMatrix(100, 100, 10);

            for (int i = 0; i < 10; i++) {

                Console.WriteLine(myMatrix.Matrix[i, 0] + myMatrix.Matrix[i, 1]);
                
            
            }
            Console.ReadKey();
        }

         
    }
}
