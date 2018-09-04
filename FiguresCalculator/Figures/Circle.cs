using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalculator.Figures
{
    public class Circle : Figure
    {
        readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            var pi = Math.Round(Math.PI, 2);
            return pi * _radius * _radius;

            // Math.Pow(_radius, 2) не использую, так как это гораздно медленнее работает
        }
    }
}
