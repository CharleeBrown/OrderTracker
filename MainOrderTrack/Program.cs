using System;

namespace MainOrderTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }

        Square hey = new Square();
        
       
    }
    public class Square
    {
        public double length;
        public double width;

        public  double Area(double length, double width)
        {
           double  totalArea =  length * width;
            return totalArea;
            
        }

    }
}
