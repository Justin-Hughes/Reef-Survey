using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using Model;

namespace ReefSurvey.Parser
{
    public class Parser
    {
        public string[] csvColumn = new string[17];  // 0 Region, 1 SubRegion, 2 StudyArea, 3 SurveyYear, 4 BatchCode, 5 SurveyIndex, 6 SurveyDate, 7 Latitude,
                                                     // 8 Longitude, 9 Management, 10 StructureType, 11 Family, 12 ScientificName, 13 CommonName, 14 Trophic, 15 FishLenth, 16 FishCount

        public static string dir = @"C:\Users\justi\OneDrive\Desktop\ReefSurvey\external\survey\1-data";
        string[] csvPaths = Directory.GetFiles(dir, "Fish Dump.csv", System.IO.SearchOption.AllDirectories);

        public void CSVParse()
        {
            bool writing = true;
            foreach (var x in csvPaths)
            {
                TextFieldParser writer = new TextFieldParser(x);
                writer.SetDelimiters(x, ",");
                writer.TrimWhiteSpace = true;
                while (writing == true)
                {
                    csvColumn = writer.ReadFields();
                    foreach (var y in csvColumn)
                    {
                        var fish = new Fish { ScientificName };
                    }
                }
                writer.Close();
            }
        }
    }
}