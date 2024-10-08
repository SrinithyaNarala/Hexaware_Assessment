using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.task2
{
    internal class Courier
    {
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public int DistanceFromOrder { get; set; }  // Distance in kilometers

        public Courier(string name, bool isAvailable, int distanceFromOrder)
        {
            Name = name;
            IsAvailable = isAvailable;
            DistanceFromOrder = distanceFromOrder;
        }
    }
}

