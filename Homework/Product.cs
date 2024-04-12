using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public int UnitNumber { get; set; }
        public string Brand { get; set; }
        public string PackageType { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public DateTime CountingDateTime { get; set; }
    }
}

