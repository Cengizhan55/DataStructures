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
        Random random1 = new Random();
        Coordinates _coordinates;


        public  MyMatrix(int coordinateX, int coordinateY,int n) {

            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.n = n;
            Matrix = new double[n,2];
            GenerateCoordinate();
            
        }

        public void GenerateCoordinate() {
            for (int i = 0; i < n; i++) {
                _coordinates = new Coordinates(this.coordinateX, this.coordinateY,random1);
                matrix[i, 0] = _coordinates.CoordinateX;
                matrix[i,1]=_coordinates.CoordinateY;
            
            }
        }
        public int N { get => n; set => n = value; }
        public int CoordinateY { get => coordinateY; set => coordinateY = value; }
        public int CoordinateX { get => coordinateX; set => coordinateX = value; }
        public double[,] Matrix { get => matrix; set => matrix = value; }
    }

}
