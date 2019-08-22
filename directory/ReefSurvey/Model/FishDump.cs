using Microsoft.EntityFrameworkCore;

namespace Model
{

    public class SurveyContext : DbContext
    {

    }
    public class Fish
    {
        public string ScientificName { get; set; }
        public int FishID { get; set; }
        public string Family { get; set; }
        public string CommonName { get; set; }
        public int TrophicID { get; set; }
    }

    public class FishData
    {
        public int FishID { get; set; }
        public int FishCount {get; set;}
        public int StructureID{get; set;}
        public double FishLength{get; set;}
        public int LocationID {get; set;}
    }

    public class Coordinates
    {
        public int LocationID {get; set;}
        public double Latitude {get; set;}
        public double Longitude {get; set;}
        public int SurveyIndex {get; set;}
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

    public class Region
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public string Management { get; set; }

    }

    public class Trophic
    {
        public int TrophicID { get; set; }
        public char TrophicCode { get; set; }
    }
    public class Structure
    {
        public int StructureID { get; set; }
        public string StructureType { get; set; }

    }
}
