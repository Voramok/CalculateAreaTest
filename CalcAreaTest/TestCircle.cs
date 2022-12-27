using CalculateAreaTest;

namespace CalcAreaTest
{
    public class CircleTest
    {
        [Fact]
        public void TestCircleNullExteption()
        {
            double arg1 = 0;
            double expected = 0;

            double result = Circle.calculateArea(arg1);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCircleCalcArea()
        {
            double arg1 = 9;
            double expected = 254.46900494077323;

            double result = Circle.calculateArea(arg1);

            Assert.Equal(expected, result);
        }
    }
}