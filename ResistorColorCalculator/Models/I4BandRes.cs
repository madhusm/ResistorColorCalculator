﻿namespace ResistorColorCalculator.Models
{
    public interface I4BandRes: IOhmValueCalculator
    {
         string BandAColor { get; set; }
         string BandBColor { get; set; }
         string BandCColor { get; set; }
         string BandDColor { get; set; }
    }
}