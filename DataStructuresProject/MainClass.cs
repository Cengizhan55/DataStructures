using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructuresProject
{
    class MainClass
    {
        static int width=100;
        static int height=100;
        static int nValue = 10;
        static int nValueAnother=100;

        static void Main(string[] args)
        {
            Random random = new Random();
            MyMatrix myMatrix = new MyMatrix(width, height, nValue, random);
            
            Thread.Sleep(2000);
            Console.WriteLine("OLUŞTURULAN RASTGELE NOKTALAR\n"+"*******************************\n");
            Thread.Sleep(2000);

            myMatrix.PrintClumps();
            Console.WriteLine("\n\n\tUZAKLIK MATRİSİ\n\n");
            Console.WriteLine("\n\n\t n=10 width=100 height=100 değerleri için matris  \n" + "\t*******************************\n");
            Thread.Sleep(2000);

            MyMatrix myMatrixAnother = new MyMatrix(width,height,nValueAnother,random);

            myMatrix.PrintMatrix(nValue);
            Console.WriteLine("\n\n \tn=100 width=100 height=100 değerleri için matris  \n" + "\t*******************************\n");
            Thread.Sleep(3000);

            myMatrixAnother.PrintMatrix(nValueAnother);

            Console.WriteLine("Çıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();   
        }
    }
}
