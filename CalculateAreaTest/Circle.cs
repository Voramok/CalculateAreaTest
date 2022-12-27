namespace CalculateAreaTest
{
    public class Circle : Shape {

        public Circle() {
        shapeName = "Circle";
        }

        protected double R; 
            public static double calculateArea(double R)
            {
            if (R <= 0)
            {
                return 0;
            }
            else
            {
                S = Math.PI * Math.Pow(R, 2);
                Console.WriteLine(shapeName + " has area: ", S);
                return S;
            }
        }
            
        

    }
}