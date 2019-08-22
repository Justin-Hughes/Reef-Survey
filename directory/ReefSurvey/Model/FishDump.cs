using System;

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

    public class Batch
    {
       public int BatchID { get; set; }
       public string BatchCode { get; set; }
    }

    public class SurveyData
    {
        public int SurveyDate { get; set; }
        public int SurveyIndex { get; set; }
        public int BatchID { get; set; }
        public string ScientificName { get; set; }
    }

}
