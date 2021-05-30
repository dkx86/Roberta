using System;

namespace Roberta.Model
{
    class Ammunition
    {
        public Guid Id { get; set; }

        public string Manufacturer { get; set; }

        public string Caliber { get; set; }

        public Projectile ProjectileType { get; set; }

        public float ProjectileWeight { get; set; }

        public string BulletSlugType { get; set; }

        public string BirdshotSize { get; set; }

        public string BuckshotSize { get; set; }
    }
}
