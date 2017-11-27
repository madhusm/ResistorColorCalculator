using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResistorColorCalculator.Models
{
    public class _5BandResistor : ValueFetcher, I5BandRes
    {
        private string bandAColor;
        private string bandBColor;
        private string bandCColor;
        private string bandDColor;
        private string bandEColor;

        public string BandAColor { get => this.bandAColor; set => this.bandAColor = value; }
        public string BandBColor { get => this.bandBColor; set => this.bandBColor = value; }
        public string BandCColor { get => this.bandCColor; set => this.bandCColor = value; }
        public string BandDColor { get => this.bandDColor; set => this.bandDColor = value; }
        public string BandEColor { get => this.bandEColor; set => this.bandEColor = value; }

        public double CalculateOhmValue()
        {
            int bandAnum = GetBandNumber(bandAColor);
            int bandBnum = GetBandNumber(bandBColor);
            int bandCnum = GetBandNumber(bandCColor);
            double bandDnum = GetBandMultiplier(BandDColor);

            return (bandAnum * 100 + bandBnum*10+bandCnum) * bandDnum;
        }
    }
}