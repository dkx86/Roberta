using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Roberta
{
    public class DataStorage<T>
    {
        private readonly static string DATA_DIR = "data";
        private readonly XmlSerializer _xmlSerializer;

        public DataStorage()
        {
            Directory.CreateDirectory(DATA_DIR);
            _xmlSerializer = new XmlSerializer(typeof(List<T>));
        }

        public void Save(List<T> entityList)
        {
            if (entityList == null || entityList.Count == 0)
                return;

            using (FileStream fs = new FileStream(GetFileName(), FileMode.Create))
            {
                _xmlSerializer.Serialize(fs, entityList);
            }
        }

        public List<T> Load()
        {
            try
            {
                using (FileStream fs = new FileStream(GetFileName(), FileMode.OpenOrCreate))
                {
                    return (List<T>)_xmlSerializer.Deserialize(fs);
                }
            }catch (Exception)
            {
                return new List<T>();
            }
        }

        private string GetFileName()
        {
            return DATA_DIR + "/" + typeof(T).Name.ToLower() + ".xml";
        }

        public static void ClearData()
        {
            DirectoryInfo directory = new DirectoryInfo(DATA_DIR);
            foreach (FileInfo file in directory.GetFiles()) file.Delete();
        }
    }
}
