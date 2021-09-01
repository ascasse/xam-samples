using System;

namespace CollectedSamples.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string ImageLocation { get; set; }
        public DateTime LastUse { get; set; }
    }
}