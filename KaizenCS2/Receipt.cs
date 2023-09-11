﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaizenCS2
{
    public class BoundingPoly
    {
        public List<Vertex> vertices { get; set; }
    }
    public class Receipt
    {
        public string locale { get; set; }
        public string description { get; set; }
        public BoundingPoly boundingPoly { get; set; }
    }
    public class Vertex
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
