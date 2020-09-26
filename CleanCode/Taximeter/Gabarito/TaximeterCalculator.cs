namespace Taximeter.Gabarito
{
    using System;

    public class TaximeterCalculator
    {
        private static readonly float NORMAL_FARE = 2;
        private static readonly int OVERNIGHT_END = 6;
        private static readonly float OVERNIGHT_FARE = 4;
        private static readonly int OVERNIGHT_START = 22;
        private static readonly float SUNDAY_FARE = 3.5f;

        public double CalcTrip(Trip trip)
        {
            if (IsOvernight(trip.Date)) return CalculateFare(trip, OVERNIGHT_FARE);

            if (IsSunday(trip.Date)) return CalculateFare(trip, SUNDAY_FARE);

            return CalculateFare(trip, NORMAL_FARE);
        }

        private static float CalculateFare(Trip trip, float fare)
        {
            return trip.Distance * fare;
        }

        private static bool IsOvernight(DateTime date)
        {
            return date.Hour > OVERNIGHT_START || date.Hour < OVERNIGHT_END;
        }

        private static bool IsSunday(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}