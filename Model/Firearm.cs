﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberta.Model
{
    class Firearm
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Caliber { get; set; }
        public string SerialNumber { get; set; }
    }
}
