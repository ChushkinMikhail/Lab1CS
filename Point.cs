// See https://aka.ms/new-console-template for more information
using System;

namespace Mihail
    {
    public class MyPoint                        
        {
        int x;
        int y;

        public int X                   
            {
            get {return x;}
            }

  
         public int Y
            {
            get {return y;}
            }

  
        public MyPoint (int x, int y)     
            {
            this.x = x;                
            this.y = y;
            }
        }

    public class MyFigure                       
        {
        MyPoint[] points;
        string name = "";

        public MyFigure (MyPoint p1, MyPoint p2, MyPoint p3)
            {
            points = new MyPoint[3];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            name = "Треугольник";
            
            Console.WriteLine (name);                                                                         
            }

        public MyFigure (MyPoint p1, MyPoint p2, MyPoint p3, MyPoint p4):this(p1, p2, p3)   
            {
            Array.Resize(ref points,4);
                
            points[3] = p4;

            name = "Четырехугольник";

            Console.WriteLine (name);
            }
        public MyFigure (MyPoint p1, MyPoint p2, MyPoint p3, MyPoint p4, MyPoint p5):this (p1, p2, p3, p4)
            {
            Array.Resize (ref points, 5);
           
            points[4] = p5;

            name = "пятиугольник";

            Console.WriteLine (name);
            }
        public string Name
            {
            get { return name; }
            //set { name = value; }
            }

        public double LengthSide (MyPoint A, MyPoint B)
            {
            int dx = A.X - B.X;
            int dy = A.Y - B.Y;
            return Math.Sqrt(dx * dx + dy * dy);
            }

        public double PerimeterCalculator ()
            {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
                {
                perimeter += LengthSide(points[i], points[i + 1]);
                }

            if (points.Length > 2)
                {
                perimeter += LengthSide(points[points.Length - 1], points[0]);
                }
            //Console.WriteLine (name);
            Console.WriteLine (perimeter);
            return perimeter;
            }
        }
    class Program
        {
        static void Main ()
            {
            MyPoint p1 = new MyPoint(0, 0);
            MyPoint p2 = new MyPoint(0, 15);
            MyPoint p3 = new MyPoint(5, 5);
            //MyPoint p4 = new MyPoint(5, 0);
            MyFigure rectangle = new MyFigure(p1, p2, p3); 
            rectangle.PerimeterCalculator();
            }
        }
    }   