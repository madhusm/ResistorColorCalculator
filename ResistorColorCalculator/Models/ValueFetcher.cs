using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResistorColorCalculator.Models
{
    public abstract class ValueFetcher
    {
        public IDictionary<string,double> GetBandToleranceColor()
        {
            Dictionary<string, double> DictBandTollerance = new Dictionary<string, double>();
            Type type = typeof(BandTolerance); 
            foreach (var p in type.GetFields())
            {
                var n = p.Name; 
                var v = p.GetValue(null);
                DictBandTollerance.Add((string)n, (double)v);
            }

            return DictBandTollerance;
        }
        public IEnumerable<string> GetBandMultiplierColor()
        {
            List<string> listBandMultiplier = new List<string>();
            Type type = typeof(BandMultiplier);
            foreach (var p in type.GetFields())
            {
                var n = p.Name;
                listBandMultiplier.Add((string)n);
            }

            return listBandMultiplier.AsEnumerable();
        }
        public double GetBandMultiplier(string bandColor)
        {
            Type type = typeof(BandMultiplier);
            foreach (var p in type.GetFields())
            {
                var v = p.GetValue(null);
                if (p.Name == bandColor)
                {
                    return (double)p.GetValue(null);
                }
            }
            return (double)1.0;
        }

        public  int GetBandNumber(string bandColor)
        {
            Enum.TryParse(bandColor, true, out BandDigitEnum myBandNo);
            return (int)myBandNo;
        }
        public enum BandDigitEnum
        {
            Black,
            Brown,
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Violet,
            Grey,
            White,

        }
        public static class BandMultiplier
        {
            public const double Black = 1;
            public const double Brown = 10;
            public const double Red = 100;
            public const double Orange = 1000;
            public const double Yellow = 10000;
            public const double Green = 100000;
            public const double Blue = 1000000;
            public const double Violet = 10000000;
            public const double Grey = 100000000;
            public const double White = 1000000000;
            public const double Gold = 0.1;
            public const double Silver = 0.01;

        }

        public static class BandTolerance
        {
            public const double None = 20.0;
            public const double Silver = 10.0;
            public const double Gold =5.0;
            public const double Brown = 1.0;
            public const double Red = 2.0;
            public const double Green = 0.5;
            public const double Blue = 0.25;
            public const double Voilet = 0.1;
            public const double Gray = 0.05;

        }
       
    }
}