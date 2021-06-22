using System;

namespace Roberta.Model
{
    [Serializable]
    public class Ammunition
    {
        public Guid Id { get; set; }

        public string Manufacturer { get; set; }

        public string Caliber { get; set; }

        public Projectile ProjectileType { get; set; }

        public float ProjectileWeight { get; set; }

        public string BulletSlugName { get; set; }

        public string BirdshotSize { get; set; }

        public string BuckshotSize { get; set; }

        public override string ToString()
        {
            string result = "New ammo";
            if (string.IsNullOrEmpty(Caliber))
                return result;

            result = Caliber;
            
            if (ProjectileWeight > 0f)
                result += ", " + ProjectileWeight + "g";

            result += ", " + ProjectileType;

            if (!string.IsNullOrEmpty(BirdshotSize))
                result += ", #" + BirdshotSize;

            if (!string.IsNullOrEmpty(BuckshotSize))
                result += ", #" + BuckshotSize;

            if (!string.IsNullOrEmpty(BulletSlugName))
                result += ", " + BulletSlugName;

            if (!string.IsNullOrEmpty(Manufacturer))
                result += ", " + Manufacturer;

            return result;
        }
    }
}
