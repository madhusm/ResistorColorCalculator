using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResistorColorCalculator.Models
{
    public class Resistor : ValueFetcher, I4BandRes, IOhmValueCalculator
    {
        private string bandAColor ;
        private string bandBColor ;
        private string bandCColor ;
        private string bandDColor;
        [Required]
        public string BandAColor { get => this.bandAColor; set => this.bandAColor = value; }
        [Required]
        public string BandBColor { get => this.bandBColor; set => this.bandBColor = value; }
        [Required]
        public string BandCColor { get => this.bandCColor; set => this.bandCColor = value; }
        [Required]
        public string BandDColor { get => this.bandDColor; set => this.bandDColor = value; }

        public double CalculateOhmValue()
        {
            int bandAnum = GetBandNumber(bandAColor);
            int bandBnum = GetBandNumber(bandBColor);
            double bandCnum = GetBandMultiplier(bandCColor);
            return (bandAnum * 10 + bandBnum) * bandCnum;
        }

    }
}