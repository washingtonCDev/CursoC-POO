using System;
namespace datetime
{
    internal class Data
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public void Date(int dia, int mes, int ano)
        {
            Day = dia;
            Month = mes;
            Year = ano;
        }
    }
}