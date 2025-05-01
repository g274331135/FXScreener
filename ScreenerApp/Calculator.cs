using ScreenerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenerApp
{
    public class Calculator
    {

        //public ScreenerItem Calculate(IEnumerable bars, string period)
        //{
        //    var item = new ScreenerItem();

        //    item.DaysAgo5 = Calc_DaysAgo5(bars);

        //    return item;
        //}

        public int Calc_DaysAgo5(IEnumerable<Bar> bars)
        {
            if (bars.Reverse().ElementAt(0).Close > bars.Reverse().ElementAt(1).Close
                && bars.Reverse().ElementAt(1).Close > bars.Reverse().ElementAt(2).Close
                && bars.Reverse().ElementAt(2).Close > bars.Reverse().ElementAt(3).Close
                && bars.Reverse().ElementAt(3).Close > bars.Reverse().ElementAt(4).Close)
            {
                return 2;
            }
            else if (bars.Reverse().Skip(1).Take(4).All(a => bars.Last().Close > a.Close))
            {
                return 1;
            }
            else if (bars.Reverse().ElementAt(0).Close < bars.Reverse().ElementAt(1).Close
                && bars.Reverse().ElementAt(1).Close < bars.Reverse().ElementAt(2).Close
                && bars.Reverse().ElementAt(2).Close < bars.Reverse().ElementAt(3).Close
                && bars.Reverse().ElementAt(3).Close < bars.Reverse().ElementAt(4).Close)
            {
                return -2;
            }
            else if (bars.Reverse().Skip(1).Take(4).All(a => bars.Last().Close < a.Close))
            {
                return -1;
            }
            else
                return 0;
        }
    }
}
