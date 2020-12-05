using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProject
{
    class Coordinates
    {
        private double coordinateX;

        private double coordinateY;

        
        public Coordinates(int coordinateX,int coordinateY,Random random) {
            

            this.coordinateY = random.NextDouble() * coordinateX;
            this.coordinateX = random.NextDouble() * coordinateY;
            
        
        }



        public double CoordinateY { get => coordinateY; set => coordinateY = value; }
        public double CoordinateX { get => coordinateX; set => coordinateX = value; }
    }
}
