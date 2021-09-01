using System;
using System.Collections.Generic;
using System.Text;

namespace CollectedSamples.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Item> Items { get; set; }
        public DateTime? LastVisited { get; set; }
    }
}
