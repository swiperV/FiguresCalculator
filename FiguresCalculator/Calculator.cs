using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalculator
{
    public static class Calculator
    {
        public static double CalculateArea(Figure figure)
        {
            return Math.Round(figure.GetArea(), 2);
        }
    }
}


/// Ответ на второй вопрос
/// SELECT g.name, c.name
/// FROM goods as g LEFT JOIN categories as c
/// ON g.categoty_id = c.id
/// 
/// или ON categoty_id = c.id
