using Roberta.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Roberta.Repository
{
    public class FirearmsRepo
    {
        private readonly DataStorage<Firearm> ds;
        private readonly Dictionary<Guid, Firearm> _firearms;

        public FirearmsRepo()
        {
            ds = new DataStorage<Firearm>();
            _firearms = new Dictionary<Guid, Firearm>();
        }

        public void Initialize()
        {
            var rawFirearms = ds.Load();
            rawFirearms.ForEach(f => _firearms.Add(f.Id, f));
        }

        public void ReloadFromDisk()
        {
            _firearms.Clear();
            Initialize();
        }

        public Firearm GetFirearm(Guid id)
        {
            try
            {
                return _firearms[id];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public List<Firearm> GetAllFirearms() => _firearms.Values.ToList();

        public Firearm CreateNewFirearm()
        {
            Firearm firearm = new Firearm
            {
                Id = Guid.NewGuid()
            };

            _firearms.Add(firearm.Id, firearm);

            return firearm;
        }

        public void UpdateOrAdd(Firearm updated)
        {
            if (_firearms.ContainsKey(updated.Id))
                _firearms[updated.Id] = updated;
            else
                _firearms.Add(updated.Id, updated);
        }

        public void Delete(Guid id)
        {
            _firearms.Remove(id);
        }

        public void Save()
        {
            ds.Save(GetAllFirearms());
        }
    }
}
