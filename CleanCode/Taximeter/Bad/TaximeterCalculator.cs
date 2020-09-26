using System;

namespace Taximeter.Bad
{
    public class TaximeterCalculator
    {
        #region 1

        public double CalcTrip(DateTime hour, float dist)
        {
            if (hour.Hour > 22 || hour.Hour < 6)
            {
                return dist * 4;
            }
            else
            {
                return dist * 2;
            }
        }

        #endregion

        #region 2
        public double CalcTrip2(DateTime hour, float dist)
        {
            if (dist >= 0)
            {
                if (hour.Hour > 22 || hour.Hour < 6)
                {
                    return dist * 4;
                }
                else
                {
                    if (hour.DayOfWeek == DayOfWeek.Sunday)
                    {
                        return dist * 3;
                    }
                    else
                    {
                        return dist * 2;
                    }
                }
            }
            else
            {
                return -1;
            }
        }
        #endregion

        #region 3
        public double CalcTrip3(DateTime hour, float dist)
        {
            if (hour.Hour > 22 || hour.Hour < 6)
            {
                return dist * 4;
            }
            else
            {
                if (hour.DayOfWeek == DayOfWeek.Sunday)
                {
                    return dist * 3.5;
                    //return dist * 3;
                }
                else
                {
                    return dist * 2;
                }
            }
        }
        #endregion

        #region 4
        public double CalcTrip4(DateTime hour, float dist)
        {
            if (dist >= 0)
            {
                // is overnight
                if (hour.Hour > 22 || hour.Hour < 6)
                {
                    return dist * 4;
                }
                else
                {
                    // is sunday
                    if (hour.DayOfWeek == DayOfWeek.Sunday)
                    {
                        return dist * 3.5;
                        //return dist * 3; (dont remove)
                    }
                    else
                    {
                        return dist * 2;
                    }
                }
            }
            else
            {
                return -1;
            }
        }
        #endregion
    }
}