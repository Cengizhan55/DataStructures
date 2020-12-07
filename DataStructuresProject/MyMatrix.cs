using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProject
{
    class MyMatrix
    {

        private int coordinateX;
        private int coordinateY;
        private int n;
        private double[,] matrix;
        private double[,] matrixN;
        Random random=new Random();

        Coordinates _coordinates;

        public  MyMatrix(int coordinateX, int coordinateY,int n,Random random) {

            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.n = n;
            Matrix = new double[n,2];
            
            GenerateCoordinate();
            
        }

        public void GenerateCoordinate() {
            for (int i = 0; i < n; i++) {
                _coordinates = new Coordinates(this.coordinateX, this.coordinateY,random);
                matrix[i, 0] = _coordinates.CoordinateX;
                matrix[i, 1] = _coordinates.CoordinateY;
            
            }
            MatrixProducer(this.n);
        }
        
        public void MatrixProducer(int n) {
            MatrixN = new double[n, n];
            for (int i = 0; i < n; i++) {
                double degerX = matrix[i, 0];
                double degerY = matrix[i, 1];


                for (int j = 0; j < n; j++) {
                    double digerDegerX = matrix[j, 0];
                    double digerDegerY = matrix[j, 1];

                    double Hesaplama = Math.Sqrt(Math.Pow(digerDegerX - degerX, 2)+ Math.Pow(digerDegerY - degerY,2));

                    MatrixN[i, j] = Math.Round(Hesaplama,2);
                    
                }


            }
            
        }
        public void PrintMatrix()
        {
            for (int a = 0; a < n; a++) {
                Console.Write("\t"+ a.ToString());
            }
            
            Console.WriteLine();
            
                for (int i = 0; i < this.n; i++)
                {
                    Console.Write(  i.ToString()+"\t"  );
                


                    for (int j = 0; j < this.n; j++)
                    {

                        Console.Write(MatrixN[i, j]);
                        Console.Write(" \t");
                    }

                    Console.WriteLine("");
                }

        }



        public int N { get => n; set => n = value; }
        public int CoordinateY { get => coordinateY; set => coordinateY = value; }
        public int CoordinateX { get => coordinateX; set => coordinateX = value; }
        public double[,] Matrix { get => matrix; set => matrix = value; }
        public double[,] MatrixN { get => matrixN; set => matrixN = value; }
    }

}
