using NUnit.Framework;
using Roberta;
using Roberta.Model;
using System.Collections.Generic;

namespace RobertaTests
{
    public class DataStorageTests
    {
        [TearDown]
        public void After()
        {
            DataStorage<object>.ClearData();
        }

        [Test]
        public void FirearmsTest()
        {
            DataStorage<Firearm> dataStorage = new DataStorage<Firearm>();
            List<Firearm> firearms = new List<Firearm>
            {
                new Firearm
                {
                    Id = System.Guid.NewGuid(),
                    Manufacturer = "Baikal",
                    Model = "MP-155",
                    Caliber = "12/76",
                    SerialNumber = "1234567",
                },

                new Firearm
                {
                    Id = System.Guid.NewGuid(),
                    Manufacturer = "Baikal",
                    Model = "MP-135",
                    Caliber = "12/70",
                    SerialNumber = "0987654",
                }
            };

            dataStorage.Save(firearms);

            List<Firearm> firearmsLoaded = dataStorage.Load();
            Assert.AreEqual(2, firearmsLoaded.Count);

            var loadedFirearm = firearmsLoaded[0];
            Assert.IsNotNull(loadedFirearm);
            var firearm = firearms[0];
            Assert.IsNotNull(firearm);

            Assert.AreEqual(firearm.Id, loadedFirearm.Id);
            Assert.AreEqual(firearm.Manufacturer, loadedFirearm.Manufacturer);
            Assert.AreEqual(firearm.Model, loadedFirearm.Model);
            Assert.AreEqual(firearm.Caliber, loadedFirearm.Caliber);
            Assert.AreEqual(firearm.SerialNumber, loadedFirearm.SerialNumber);
        }

        [Test]
        public void AmmunitionTest()
        {
            DataStorage<Ammunition> dataStorage = new DataStorage<Ammunition>();
            List<Ammunition> ammunitions = new List<Ammunition>
            {
                new Ammunition
                {
                    Id = System.Guid.NewGuid(),
                    Manufacturer = "Fetter",
                    ProjectileType = Projectile.Birdshot,
                    ProjectileWeight = 32f,
                    BirdshotSize = "5",
                    Caliber = "12/70"
                },
                new Ammunition
                {
                    Id = System.Guid.NewGuid(),
                    Manufacturer = "Azot",
                    ProjectileType = Projectile.Buckshot,
                    ProjectileWeight = 28f,
                    BuckshotSize = "8.3",
                    Caliber = "12/70"
                },
                new Ammunition
                {
                    Id = System.Guid.NewGuid(),
                    Manufacturer = "Техкрим",
                    ProjectileType = Projectile.Bullet,
                    ProjectileWeight = 7.5f,
                    Caliber = "345ТК",
                    BulletSlugName = "FMJ"
                }


            };

            dataStorage.Save(ammunitions);

            List<Ammunition> ammunitionsLoaded = dataStorage.Load();
            Assert.AreEqual(3, ammunitionsLoaded.Count);

            var ammo = ammunitions[2];
            Assert.IsNotNull(ammo);
            var loadedAmmo = ammunitionsLoaded[2];
            Assert.IsNotNull(loadedAmmo);

            Assert.AreEqual(ammo.Id, loadedAmmo.Id);
            Assert.AreEqual(ammo.Manufacturer, loadedAmmo.Manufacturer);
            Assert.AreEqual(ammo.ProjectileType, loadedAmmo.ProjectileType);
            Assert.AreEqual(ammo.ProjectileWeight, loadedAmmo.ProjectileWeight);
            Assert.AreEqual(ammo.Caliber, loadedAmmo.Caliber);
            Assert.AreEqual(ammo.BuckshotSize, loadedAmmo.BuckshotSize);
        }

        [Test]
        public void LogRecordsTest()
        {
            DataStorage<LogRecord> dataStorage = new DataStorage<LogRecord>();
            var firearm = new Firearm
            {
                Id = System.Guid.NewGuid(),
                Manufacturer = "Baikal",
                Model = "MP-135",
                Caliber = "12/70",
                SerialNumber = "0987654"
            };


            List<Ammunition> ammunitions = new List<Ammunition>
            {
                new Ammunition
                {
                    Id = System.Guid.NewGuid(),
                    Manufacturer = "GrandPatron",
                    ProjectileType = Projectile.Birdshot,
                    ProjectileWeight = 32f,
                    BirdshotSize = "3",
                    Caliber = "12/70"
                },
                new Ammunition
                {
                    Id = System.Guid.NewGuid(),
                    Manufacturer = "Fetter",
                    ProjectileType = Projectile.Slug,
                    ProjectileWeight = 32f,
                    BulletSlugName = "Феттер",
                    Caliber = "12/70"
                }
            };

            List<LogRecord> records = new List<LogRecord>
            {
                new LogRecord()
                {
                    Id = System.Guid.NewGuid(),
                    Date = System.DateTime.Now,
                    Firearm = firearm,
                    Ammunition = ammunitions[0],
                    Rounds = 25
                },
                new LogRecord()
                {
                    Id = System.Guid.NewGuid(),
                    Date = System.DateTime.Now,
                    Firearm = firearm,
                    Ammunition = ammunitions[1],
                    Rounds = 10
                }
            };

            dataStorage.Save(records);

            List<LogRecord> recordsLoaded = dataStorage.Load();
            Assert.AreEqual(2, recordsLoaded.Count);
        }

        [Test]
        public void LoadFromEmptyFile()
        {
            DataStorage<Firearm> dataStorage = new DataStorage<Firearm>();

            List<Firearm> firearmsLoaded = dataStorage.Load();
            Assert.IsNotNull(firearmsLoaded);
            Assert.AreEqual(0, firearmsLoaded.Count);
        }

    }
}