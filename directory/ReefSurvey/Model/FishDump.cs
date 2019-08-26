using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class SurveyContext : DbContext
    {
        public DbSet<Fish> Fish { get; set; }
        public DbSet<FishData> FishData {get; set;}
        public DbSet<Coordinates> Coordinates {get; set;}
        public DbSet<Location> Location {get; set;}
        public DbSet<Batch> Batch {get; set;}
        public DbSet<SurveyData> SurveyData {get; set;}
        public DbSet<Region> Region {get; set;}
        public DbSet<Trophic> Trophic {get; set;}
        public DbSet<Structure> Structure {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=FishDump");
        }
    }
    public class Fish

    {
        [Key]
        public string ScientificName { get; set; }
        public int FishID { get; set; }
        public string Family { get; set; }
        public string CommonName { get; set; }
        public int TrophicID { get; set; }
    }

    public class FishData
    {
        [Key]
        public int FishID { get; set; }
        public int FishCount {get; set;}
        public int StructureID{get; set;}
        public double FishLength{get; set;}
        public int LocationID {get; set;}
    }

    public class Coordinates
    {
        [Key]
        public int LocationID {get; set;}
        public double Latitude {get; set;}
        public double Longitude {get; set;}
        public int SurveyIndex {get; set;}
    }

    public class Location
    {
        [Key]
        public string StudyArea { get; set; }
        public int  RegionID { get; set; }
        public string SubRegion { get; set; }
        public int LocationID { get; set; }
    }

    public class Batch
    {
        [Key]
        public int BatchID { get; set; }
       public string BatchCode { get; set; }
    }

    public class SurveyData
    {
        [Key]
        public int SurveyDate { get; set; }
        public int SurveyIndex { get; set; }
        public int BatchID { get; set; }
        public string ScientificName { get; set; }
    }

    public class Region
    {
        [Key]
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public string Management { get; set; }

    }

    public class Trophic
    {
        [Key]
        public int TrophicID { get; set; }
        public char TrophicCode { get; set; }
    }
    public class Structure
    {
        [Key]
        public int StructureID { get; set; }
        public string StructureType { get; set; }

    }
}
