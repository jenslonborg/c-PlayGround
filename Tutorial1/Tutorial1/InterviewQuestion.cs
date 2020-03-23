using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestionApplication
{
    class interViewQuestion
    {
        public double GiveMePi()
        {
            int N = 1000;
            double pi = 0;
            Random randObj = new Random();
            Dictionary<int, CircleCoordinate> CirclePoints = new Dictionary<int, CircleCoordinate>();
            Dictionary<int, bool> CirclePointsUsed = new Dictionary<int, bool>();
            CircleCoordinate circlePoint = new CircleCoordinate(1, 1);
            CirclePoints.Add(0, circlePoint);
            CirclePointsUsed.Add(0, false);
            circlePoint = new CircleCoordinate(1, 0);
            CirclePoints.Add(1, circlePoint);
            CirclePointsUsed.Add(1, false);
            for (int i = 2; i < N; i++)
            {
                double rand = randObj.NextDouble();
                circlePoint = new CircleCoordinate(1, rand);
                CirclePoints.Add(i, circlePoint);
                //circlePoint.DisplayCoordinate();
                CirclePointsUsed.Add(i, false);
            }

            CircleCoordinate currentCirclePoint = CirclePoints[0];
            CirclePointsUsed[0] = true;
            double Distance;
            double MinDistance; //Safe upper limit
            double TotalDistance = 0;
            int MinDistancePos = 1;
            for (int i = 1; i < N; i++)
            {
                MinDistance = 2.0;
                for (int j = 1; j < N; j++)
                {
                    if (CirclePointsUsed[j] == false)
                    {
                        Distance = currentCirclePoint.Distance(CirclePoints[j]);
                        if (MinDistance > Distance)
                        {
                            MinDistance = Distance;
                            MinDistancePos = j;
                        }
                    }
                }
                TotalDistance += MinDistance;
                CirclePoints[MinDistancePos].DisplayCoordinate();
                Console.WriteLine("Total Dist = {0}", TotalDistance);
                
                CirclePointsUsed[MinDistancePos] = true;
                currentCirclePoint = CirclePoints[MinDistancePos];
            }
            return TotalDistance*2;

        }
    }

    class Coordinate<T>
    {
        T myPos1;
        T myPos2;
        public Coordinate() { }
        //Constructor
        public Coordinate(ref T pos1, ref T pos2)
        {
            this.myPos1 = pos1;
            this.myPos2 = pos2;
        }
        //Get
        public T pos1() { return myPos1; }
        public T pos2() { return myPos2; }
        //Set
        public void pos1(T pos) { this.myPos1 = pos; }
        public void pos2(T pos) { this.myPos2 = pos; }
        public void CoordinateSet(T pos1,T pos2)
        {
            this.myPos1 = pos1;
            this.myPos2 = pos2;
        }

    }
    class CircleCoordinate : Coordinate<double>
    {
        double myRadius;
        public CircleCoordinate()
        {
            myRadius = 1;
            double pos1 = 1;
            double pos2 = 0;
            this.CoordinateSet(pos1, pos2);
        }
        public CircleCoordinate(double Radius)
        {
            myRadius = Radius;
            if (Radius > 0)
            {
                double pos1 = Radius;
                double pos2 = Math.Sqrt(Radius * Radius - pos1 * pos1);
                this.CoordinateSet(pos1, pos2);
            }
            else
            {
                myRadius = 1;
                Console.WriteLine("Input correct for circle. Creating a R=1 circle");
                this.CoordinateSet(1, 0);
            }
        }
        public CircleCoordinate(double Radius, double pos1)
        {
            myRadius = Radius;
            if (Math.Sqrt(pos1*pos1) < Radius && Radius > 0)
            {
                double pos2 = Math.Sqrt(Radius * Radius - pos1 * pos1);
                this.CoordinateSet(pos1, pos2);
            }
            else
            {
                Console.Write("Input correct for circle. Creating a R=1 circle");
                myRadius = 1;
                this.CoordinateSet(1, 0);
            }
        }
        // Get
        public void DisplayCoordinate()
        {
            Console.WriteLine("Radius = {0}", myRadius);
            Console.WriteLine("Pos1 = {0}", this.pos1());
            Console.WriteLine("Pos2 = {0}", this.pos2());
        }
        //Maths
        public double Distance(CircleCoordinate input)
        {
            double DistTot;
            double Dist1;
            double Dist2;
            Dist1 = input.pos1() - this.pos1();
            Dist2 = input.pos2() - this.pos2();
            DistTot = Math.Sqrt(Dist1 * Dist1 + Dist2 * Dist2);
            return DistTot;
        }

    }
}
