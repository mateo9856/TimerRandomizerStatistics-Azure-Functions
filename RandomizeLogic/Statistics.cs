using CsvHelper.Configuration.Attributes;

namespace RandomizeLogic
{
    public class Statistics
    {
        [Index(0)]
        public int Id { get; set; }
        [Index(1)]
        public string Text { get; set; }
        [Index(2)]
        public string Author { get; set; }
        [Index(3)]
        public int Value { get; set; }
        [Index(4)]
        public double Precision { get; set; }
        [Index(5)]
        public double Precision2 { get; set; }
        [Index(6)]
        public decimal Precision3 { get; set; }
        [Index(7)]
        public string Text2 { get; set; }
        [Index(8)]
        public string Text3 { get; set; }
        [Index(9)]
        public float Value2 { get; set; }

        public override string ToString()
        {
            return $"{Id},{Text},{Author},{Value},{Precision},{Precision2},{Precision3},{Text2},{Text3},{Value2}";
        }

    }
}