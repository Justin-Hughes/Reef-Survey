﻿using System;

namespace Model
{
    public class Fish
    {
        public string ScientificName { get; set; }
        public int FishID { get; set; }
        public string Family { get; set; }
        public string CommonName { get; set; }
        public int TrophicID { get; set; }
    }

    public class Location
    {
        public string StudyArea { get; set; }
        public int  RegionID { get; set; }
        public string SubRegion { get; set; }
        public int LocationID { get; set; }
    }
}
