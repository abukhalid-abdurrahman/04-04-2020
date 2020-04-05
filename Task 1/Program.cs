/*
 * Developed by Faridun Berdiev
 * Date: 04.04.2020
 * First Task
*/
using System;

namespace Task_1
{
    class Converter
    {
        public enum Сurrency
        {
            USD,
            EUR,
            RUB
        }
        private double usdCourse = 0.0;
        private double eurCourse = 0.0;
        private double rubCourse = 0.0;
        public double tjsCourse { get; set; }
        public Converter(double _usd, double _eur, double _rub)
        {
            usdCourse = _usd;
            eurCourse = _eur;
            rubCourse = _rub;
        }

        public double ConvertToTJS(double _tjs, Сurrency currency)
        {
            switch (currency)
            {
                case Сurrency.EUR:
                return _tjs * eurCourse;
                case Сurrency.RUB:
                return _tjs * rubCourse;
                case Сurrency.USD:
                return _tjs * usdCourse;
                default:
                return 0.0f;
            }
        }

        public double ConvertTJSTo(double _maney, Сurrency currency)
        {
            switch (currency)
            {
                case Сurrency.EUR:
                return _maney * tjsCourse;
                case Сurrency.RUB:
                return _maney * tjsCourse;
                case Сurrency.USD:
                return _maney * tjsCourse;
                default:
                return 0.0f;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
