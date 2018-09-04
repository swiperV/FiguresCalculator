using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalculator.Figures
{
    public class Triangle : Figure
    {
        public double _partOne { get; set; }
        public double _partTwo { get; set; }
        public double _partThree { get; set; }

        public Triangle(double partOne, double partTwo, double partThree)
        {
            _partOne = partOne;
            _partTwo = partTwo;
            _partThree = partThree;
        }

        public override double GetArea()
        {
            if (IsTriangular())
            {
                return (new Triangular(_partOne, _partTwo, _partThree)).GetArea();
            }

            var halfPerimeter = (_partOne + _partTwo + _partThree) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _partOne) * (halfPerimeter - _partTwo) * (halfPerimeter - _partThree));
        }

        public bool IsTriangular()
        {
            return
                _partOne * _partOne == _partTwo * _partTwo + _partThree * _partThree
                || _partTwo * _partTwo == _partOne * _partOne + _partThree * _partThree
                || _partThree * _partThree == _partOne * _partOne + _partTwo * _partTwo;

            // Math.Pow(_partOne, 2) == Math.Pow(_partTwo, 2) + Math.Pow(_partThree, 2) менее производительно
        }
    }
}
