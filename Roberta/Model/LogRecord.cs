using System;

namespace Roberta.Model
{
    [Serializable]
    public class LogRecord
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public Firearm Firearm { get; set; }

        public Ammunition Ammunition { get; set; }

        public int Rounds { get; set; }
    }
}
