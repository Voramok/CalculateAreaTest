using CalculateAreaTest;

namespace CalcAreaTest
{
    public class TriangleTest
    {
        [Fact]
        public void TestTriangleNullExteption()
        {
            double arg1 = 0;
            double arg2 = 4;
            double arg3 = 5;
            double expected = 0;

            double result = Triangle.calculateArea(arg1, arg2, arg3);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestTriangleCalcArea()
        {
            double arg1 = 3;
            double arg2 = 4;
            double arg3 = 5;
            double expected = 6;

            double result = Triangle.calculateArea(arg1, arg2, arg3);
           
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestIsRightTriangle()
        {
            double arg1 = 3;
            double arg2 = 4;
            double arg3 = 5;
            Boolean expected = true;

            Boolean result = Triangle.isRightTriangle(arg1, arg2, arg3);

            Assert.Equal(expected, result);
        }
    }
}