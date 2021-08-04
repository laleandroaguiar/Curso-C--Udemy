using System;

namespace Exemple_Composition.Entities
{
    class HoursContract
    {
        public DateTime Date { get; set; }

        public double ValuePerHours { get; set; }
        public int Hours { get; set; }

        public HoursContract()
        {

        }

        public HoursContract(DateTime date, double valuePerHours, int hours)
        {
            Date = date;
            ValuePerHours = valuePerHours;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHours;
        }
    }
}
