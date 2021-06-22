using System;

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

        public override string ToString()
        {
            string result = "New firearm";
            if (string.IsNullOrEmpty(Model))
                return result;

            result = Model;
            
            if (!string.IsNullOrEmpty(SerialNumber))
                result += " - s/n:" + SerialNumber;

            return result;
        }

    }
}
