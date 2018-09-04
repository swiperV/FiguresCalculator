using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalculator.Figures
{
    public class Triangular : Triangle
    {
        double _hypotenuse => FindHypotenuse();
        double _katet1;
        double _katet2;

        public Triangular(double partOne, double partTwo, double partThree)
            : base(partOne, partTwo, partThree)
        { }

        public override double GetArea()
        {
            SetKatets();
            return 0.5 * _katet1 * _katet2;
        }

        private double FindHypotenuse()
        {
            double hypotenuse;
            hypotenuse = _partTwo > _partOne ? _partTwo : _partOne;
            hypotenuse = _partThree > hypotenuse ? _partThree : hypotenuse;

            return hypotenuse;
        }

        private void SetKatets()
        {
            if (_partOne == _hypotenuse)
            {
                _katet1 = _partTwo;
                _katet2 = _partThree;
            }
            else if (_partTwo == _hypotenuse)
            {
                _katet1 = _partOne;
                _katet2 = _partThree;
            }
            else if (base._partThree == _hypotenuse)
            {
                _katet1 = _partOne;
                _katet2 = _partTwo;
            }
        }
    }
}
