using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    //You decide to test if your oddly-mathematical heating company is fulfilling its 
    //All-Time Max, Min, Mean and Mode Temperature Guarantee™.
    class TemperatureTracker
    {
        //Insert()—records a new temperature
        //GetMax()—returns the highest temp we've seen so far
        //GetMin()—returns the lowest temp we've seen so far
        //GetMean()—returns the mean of all temps we've seen so far
        //GetMode()—returns a mode of all temps we've seen so far

        // For min and max
        private int? _minTemp;
        private int? _maxTemp;
        //For Mean
        private int _count = 0;
        private int _sum = 0;
        private double _mean = 0;
        //For Mode
        //Assumption -  temperatures in Fahrenheit, so we can assume they'll all be in the range 0..110
        private int[] _occurrences = new int[111];
        private int _maxOccurrences;
        private int? _mode;

        public void Insert(int temp)
        {
            //For Min
            if (_minTemp == null || _minTemp > temp)
            {
                _minTemp = temp;
            }

            //For Max
            if (_maxTemp == null || _maxTemp < temp)
            {
                _maxTemp = temp;
            }

            _count++;
            _sum = _sum + temp;
            _mean = (double)_sum / _count;

            //For Mode
            _occurrences[temp]++;
            if (_maxOccurrences < _occurrences[temp])
            {
                _mode = temp;
                _maxOccurrences = _occurrences[temp];
            }

        }
        public int? GetMax()
        {
            return _maxTemp;
        }

        public int? GetMin()
        {
            return _minTemp;
        }

        public double? GetMean()
        {
            return _mean;
        }

        public int? GetMode()
        {
            return _mode;
        }
    }
}
