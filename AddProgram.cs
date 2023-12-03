using System;
using System.Globalization;

namespace first
{
    public class AddProgram
    {
        public bool IsGreaterThanZero(int value)
        {
            if (value <= 0)
                //Console.WriteLine("Number is greater than zero");
                return true;
            else
                Console.WriteLine("Number is less than zero");
                return false;
        }

        public int Addition(int x, int y)
        {
            int res = x + y;
            return res;
        }


        public string NameOfMonth(int MonthIndex)
        {
            string MonthName = "";
            if (MonthIndex > 0 && MonthIndex < 12)
                MonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(MonthIndex);
            else
                MonthName = "Not a Valid Month";
            return MonthName;
        }
    } 
}

