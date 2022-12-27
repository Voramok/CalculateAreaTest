namespace CalculateAreaTest
{
    public class Triangle : Shape
    {  
        public Triangle()
        {
            shapeName = "Triangle";
        }

        protected double R, T, Y;
            public static double calculateArea(double R, double T, double Y)
            {
            if (R <= 0 || T <= 0 || Y <= 0) {
                return 0;
            } else { 

                double p;

                p = (R + T + Y) / 2;

                S = Math.Sqrt(p * (p - R) * (p - T) * (p - Y));

                
                Console.WriteLine(shapeName + " has area: ", S);
                return S; }
            }


        public static Boolean isRightTriangle(double R, double T, double Y)
        {
            if (R * R + T * T == Y * Y ||
                T * T + Y * Y == R * R ||
                Y * Y + R * R == T * T)
            {
                return true;
            } else {
                return false;
            }
        }


            
        

    }
}