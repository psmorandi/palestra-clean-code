namespace Taximeter.Gabarito
{
    using System;

    public class Trip
    {
        public Trip(DateTime date, float distance)
        {
            if (this.Distance < 0) throw new ArgumentException($"Invalid distance ({this.Distance}).");
            this.Date = date;
            this.Distance = distance;
        }

        public DateTime Date { get; }
        public float Distance { get; }
    }
}