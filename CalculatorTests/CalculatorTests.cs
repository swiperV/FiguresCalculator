using FiguresCalculator;
using FiguresCalculator.Figures;
using System;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Fact]
        public void CircleTest()
        {
            var radius = 3;
            var figure = new Circle(radius);
            var area = Calculator.CalculateArea(figure);
            Assert.Equal(28.26, area);
        }

        [Fact]
        public void TriangleTest()
        {
            var figure = new Triangle(4, 4, 4);
            var area = Calculator.CalculateArea(figure);
            Assert.Equal(6.93, area);
        }

        [Fact]
        public void TriangularTest()
        {
            var figure = new Triangle(3, 4, 5);
            var area = Calculator.CalculateArea(figure);
            Assert.Equal(6, area);
        }

        [Fact]
        public void TriangularCheckTest()
        {
            var figure = new Triangle(3, 4, 5);
            Assert.True(figure.IsTriangular());
        }
    }
}
