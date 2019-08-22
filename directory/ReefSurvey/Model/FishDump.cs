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

    public class Batch
    {
       public int BatchID { get; set; }
        public string BatchCode { get; set; }
    }

}
