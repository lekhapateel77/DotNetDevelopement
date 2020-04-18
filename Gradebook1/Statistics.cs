using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    public class Statistics
    {
        public double average
        {
            get
            {
                return sum / count;
            }
        }
        public double highgrade;
        public double lowgrade;
        public Char letter
        {
            get
            {
                switch (average)
                {
                    case var d when d >= 90.0:
                        return 'A';
                    case var d when d >= 80.0:
                        return 'B';
                    case var d when d >= 70.0:
                        return 'c';
                    case var d when d >= 60.0:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }
        public double sum;
        public int count;

        public void add(double number)
        {
            sum += number;
            count += 1;
            lowgrade = Math.Min(number, lowgrade);
            highgrade = Math.Max(number, highgrade);
        }

        public Statistics()
        {
            sum = 0.0;
            count = 1;
            lowgrade = double.MaxValue;
            highgrade = double.MinValue;
        }
    }
}
