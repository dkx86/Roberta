using Roberta.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Roberta.Repository
{
    public class RecordsRepo
    {
        private readonly DataStorage<LogRecord> ds;
        private readonly Dictionary<Guid, LogRecord> _records;

        public RecordsRepo()
        {
            ds = new DataStorage<LogRecord>();
            _records = new Dictionary<Guid, LogRecord>();
        }

        public void Initialize()
        {
            var rawRecords = ds.Load();
            rawRecords.ForEach(r => _records.Add(r.Id, r));
        }

        public void ReloadFromDisk()
        {
            _records.Clear();
            Initialize();
        }

        public LogRecord GetRecord(Guid id)
        {
            try
            {
                return _records[id];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public List<LogRecord> GetAll() => _records.Values.OrderByDescending(r => r.Date).ToList();

        public LogRecord CreateNewRecord()
        {
            LogRecord record = new LogRecord
            {
                Id = Guid.NewGuid()
            };

            _records.Add(record.Id, record);

            return record;
        }

        public void UpdateOrAdd(LogRecord updated)
        {
            if (_records.ContainsKey(updated.Id))
                _records[updated.Id] = updated;
            else
                _records.Add(updated.Id, updated);
        }

        public void Delete(Guid id)
        {
            _records.Remove(id);
        }

        public void Save()
        {
            ds.Save(GetAll());
        }
    }
}
