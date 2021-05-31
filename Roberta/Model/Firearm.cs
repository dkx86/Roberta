using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberta.Model
{
    [Serializable]
    public class Firearm
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Caliber { get; set; }
        public string SerialNumber { get; set; }
        public DateTime PurchaseDate { get; set; }

    }
}
