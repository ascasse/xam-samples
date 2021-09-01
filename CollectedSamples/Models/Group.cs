using System;
using System.Collections.Generic;
using System.Text;

namespace CollectedSamples.Models
{
    public class Group : List<Item>
    {
        public string Name { get; set; }

        public Group() : base()
        {

        }

        public Group(string name, List<Item> items) : base(items)
        {
            Name = name;
        }
    }
}
