using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace ConsoleApplication1
{
    class Circle
    {
        private Point center;
        private double radius;

        public Circle(Point center, int radius) {
            this.center = center;
            this.radius = radius;
        }

        public bool IsPointOnCircle(Point point){
            if (Math.Pow((point.X - center.X), 2) + Math.Pow((point.Y - center.Y), 2) == Math.Pow(radius, 2))
                return true;
            else
                return false;
        }

        public bool IntersectsWith(Circle circle) {
            double distance = circle.radius + this.radius;
            if(!oneIsInsideTheOther(circle) && distance >= DistanceBetween(circle.center,this.center))
                return true;
            else              
                return false;
        }

//private methods

        private bool oneIsInsideTheOther(Circle circle)
        {
            double greaterRadius, lesserRadius;

            if (this.radius > circle.radius)
            {
                greaterRadius = this.radius;
                lesserRadius = circle.radius;
            }
            else
            {
                greaterRadius = circle.radius;
                lesserRadius = this.radius;
            }

            if ((DistanceBetween(circle.center, this.center) + lesserRadius) < greaterRadius)
                return true;
            else
                return false;
        }

        private double DistanceBetween(Point firstPoint, Point secondPoint) {
            return Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + 
                Math.Pow((firstPoint.Y - secondPoint.Y), 2));
        }

//Accessors and Mutators

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Point Center
        {
            get { return center; }
            set { center = value; }
        }

    }
}
