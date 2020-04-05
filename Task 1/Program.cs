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
        public double tjsCourseRUB { get; set; }
        public double tjsCourseEUR { get; set; }
        public double tjsCourseUSD { get; set; }
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
                return _maney * tjsCourseEUR;
                case Сurrency.RUB:
                return _maney * tjsCourseRUB;
                case Сurrency.USD:
                return _maney * tjsCourseUSD;
                default:
                return 0.0f;
            }
        }

    }
    class Program
    {
        static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine().Replace(".", ","));
        }
        static void Main(string[] args)
        {
            string menu = "1 - Convert TJS To (EUR, USD, RUB)\n" + 
                          "2 - Convert (EUR, USD, RUB) To TJS\n" + 
                          "exit - To Exit";
            Converter convert = new Converter(10.22, 11.04, 0.13);
            convert.tjsCourseEUR = 0.091;
            convert.tjsCourseUSD = 0.098;
            convert.tjsCourseRUB = 7.48;
            Console.WriteLine(menu);
            string _cmd = String.Empty;
            while(_cmd != "exit")
            {
               _cmd = Console.ReadLine();
               switch (_cmd)
               {
                   case "1":
                   {
                        Console.WriteLine("Таджитский Сомони в (EUR, USD, RUB): ");
                        string curStr = Console.ReadLine().ToUpper();
                        Console.WriteLine("Сомони: ");
                        double _tjsManey = ReadDouble();
                        if(curStr == "EUR")
                            Console.WriteLine($"{_tjsManey} сомони в {curStr} = " + convert.ConvertTJSTo(_tjsManey, Converter.Сurrency.EUR));
                        else if(curStr == "USD")
                            Console.WriteLine($"{_tjsManey} сомони в {curStr} = " + convert.ConvertTJSTo(_tjsManey, Converter.Сurrency.USD));
                        else if(curStr == "RUB")
                            Console.WriteLine($"{_tjsManey} сомони в {curStr} = " + convert.ConvertTJSTo(_tjsManey, Converter.Сurrency.RUB));
                        Console.WriteLine(menu);
                   }
                   break;
                   case "2":
                   {
                        Console.WriteLine("(EUR, USD, RUB) в Таджитских Сомони: ");
                        string curStr = Console.ReadLine().ToUpper();
                        Console.WriteLine("Деньги: ");
                        double _maneyManey = ReadDouble();
                        if(curStr == "EUR")
                            Console.WriteLine($"{_maneyManey} {curStr} в сомони = " + convert.ConvertToTJS(_maneyManey, Converter.Сurrency.EUR));
                        else if(curStr == "USD")
                            Console.WriteLine($"{_maneyManey} {curStr} в сомони = " + convert.ConvertToTJS(_maneyManey, Converter.Сurrency.USD));
                        else if(curStr == "RUB")
                            Console.WriteLine($"{_maneyManey} {curStr} в сомони = " + convert.ConvertToTJS(_maneyManey, Converter.Сurrency.RUB));
                        Console.WriteLine(menu);
                   }
                   break;
                   default:
                   Console.WriteLine("Нет такой команды!");
                   break;
               }
            }
        }
    }
}
