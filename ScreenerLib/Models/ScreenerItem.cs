using ScreenerLib.Models;
using System.Collections.Generic;

namespace ScreenerLib
{
    public class ScreenerItem
    {
        public string Market { get; set; }

        public string SymbolName { get; set; }

        public string Period { get; set; }

        public List<Bar> Bars { get; set; }

        public int Days5Ago { get; set; }


        public override int GetHashCode()
        {
            return string.Format($"{Market}_{SymbolName}_{Period}").GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ScreenerItem))
                return false;

            var right = obj as ScreenerItem;

            return this.GetHashCode() == right.GetHashCode();
        }

    }
}
