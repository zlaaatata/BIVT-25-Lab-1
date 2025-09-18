using System.Numerics;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a != 0 || b!=0)
            {
                if ((a>0 && b>0) || (a < 0 && b < 0))
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            int compareD = (int)d;
            if (compareD != d)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;
            
            // code here
            if (b != 0 && a%b==0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double absD = Math.Abs(d);
            double absF = Math.Abs(f);
            double absG = Math.Abs(g);
            if (absD >= absF && absD >= absG)
            {
                answer = d;
            }
            else
            {
                if (absF >= absD && absF >= absG)
                {
                    answer = f;
                }
                else
                {
                    if (absG >= absD && absG >= absF)
                    {
                        answer = g;
                    }
                }

            }
                // end

                return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x > 0)
            {
                answer = 1;
            }
            else
            {
                if (x > -1 && x <= 0)
                {
                    answer = x + 1;
                }
                else
                {
                    if (x <= -1)
                    {
                        answer = 0;
                    }
                }
            }
                // end

                return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double circleD= Math.Sqrt(circleS/Math.PI) * 2;
            double squareD = Math.Sqrt(squareS);
            if (circleD <= squareD)
            {
                answer = true;
            }
            //end

                return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
            }
                // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here

            int old = a / 2;
            int middle = b / 2;
            int young = c / 2;
            int total = old + middle + young;
            if (total % 3 == 0 && total !=0)
            {
                answer = true;
            }
            else
            {
                if ((total + 1) % 3 == 0 && total!=0)
                {
                    answer = true;
                }
            }


                // end

                return answer;
        }
    }
}