using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenerLib
{
    public class Period
    {
        public static string[] GetPeriods()
        {
            return new string[] { 
                "MN1",
                "W1",
                "D1",
                "H4",
                "H1",
                "M30",
                "M15",
                "M5",
                "M1" 
            };
        }

        public static string[] GetPeriodsLessThen(string period)
        {
            if (period == "MN1")
                return new[] { "W1", "D1", "H4", "H1", "M30", "M15", "M5", "M1" };
            else if (period == "W1")
                return new[] { "D1", "H4", "H1", "M30", "M15", "M5", "M1" };
            else if (period == "D1")
                return new[] { "H4", "H1", "M30", "M15", "M5", "M1" };
            else if (period == "H4")
                return new[] { "H1", "M30", "M15", "M5", "M1" };
            else if (period == "H1")
                return new[] { "M30", "M15", "M5", "M1" };
            else if (period == "M30")
                return new[] { "M15", "M5", "M1" };
            else if (period == "M15")
                return new[] { "M5", "M1" };
            else if (period == "M5")
                return new[] { "M1" };
            else
                return null;
        }

        public static int PeriodToMinutes(string period)
        {
            switch (period)
            {
                case "MN1": return 302400;
                case "W1": return 10080;
                case "D1": return 1440;
                case "H4": return 240;
                case "H1": return 60;
                case "M30": return 30;
                case "M15": return 15;
                case "M5": return 5;
                case "M1": return 1;
                default: return 0;
            }
        }
    }
}
