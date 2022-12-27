namespace CalculateAreaTest
{
    public class UniversalAreaCalc
    {
        public static double calculateArea(double R)
        {
            return Circle.calculateArea(R);
        }

        public static double calculateArea(double R, double T, double Y)
        {
            return Triangle.calculateArea(R, T, Y);
        }

    }
}