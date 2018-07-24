using System;

namespace SOLID._01_SingleResponsability
{
    public class Sample
    {
        public void Sum(int number1, int number2)
        {
            var total = number1 + number2;
            var rangeDescription = GetRangeDescription(total);
            Console.WriteLine(string.Format("The sum is: {0} and is in range {1}", total, rangeDescription));
        }

        private static string GetRangeDescription(int total)
        {
            var rangeDescription = "";
            if (total > 0 && total <= 10) rangeDescription = "Value between 0 and 10";
            else if (total > 10 && total <= 20) rangeDescription = "Value between 11 and 20";
            else if (total > 20 && total <= 30) rangeDescription = "Value between 11 and 20";
            return rangeDescription;
        }
    }
}
