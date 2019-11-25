using System;
using System.Collections.Generic;
using System.Text;

namespace JulieLibrary.DataModel
{
    public class Product
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ExpDate { get; set; }
        public string Company { get; set; }
        public int MfgYear { get; set; }
        public string Category { get; set; }
    }
}
