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

            if (!string.IsNullOrEmpty(Manufacturer))
                result += ", " + Manufacturer;

            if (ProjectileWeight > 0f)
                result += ", " + ProjectileWeight;

            return result;
        }
    }
}
