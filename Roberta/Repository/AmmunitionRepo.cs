using Roberta.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Roberta.Repository
{
    class AmmunitionRepo
    {
        private readonly DataStorage<Ammunition> ds;
        private readonly Dictionary<Guid, Ammunition> _ammunition;

        public AmmunitionRepo()
        {
            ds = new DataStorage<Ammunition>();
            _ammunition = new Dictionary<Guid, Ammunition>();
        }

        public void Initialize()
        {
            var rawAmmo = ds.Load();
            rawAmmo.OrderBy(a => a.Caliber).ThenBy(a => a.ProjectileWeight).
                ToList().ForEach(a => _ammunition.Add(a.Id, a));
        }

        public void ReloadFromDisk()
        {
            _ammunition.Clear();
            Initialize();
        }
        public Ammunition GetAmmo(Guid id)
        {
            try
            {
                return _ammunition[id];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public List<Ammunition> GetAllAmmo() => _ammunition.Values.ToList();

        public Ammunition CreateNewAmmo()
        {
            Ammunition ammo = new Ammunition
            {
                Id = Guid.NewGuid()
            };

            _ammunition.Add(ammo.Id, ammo);

            return ammo;
        }

        public void UpdateOrAdd(Ammunition updated)
        {
            if (_ammunition.ContainsKey(updated.Id))
                _ammunition[updated.Id] = updated;
            else
                _ammunition.Add(updated.Id, updated);
        }

        public void Delete(Guid id)
        {
            _ammunition.Remove(id);
        }

        public void Save()
        {
            ds.Save(GetAllAmmo());
        }
    }
}
