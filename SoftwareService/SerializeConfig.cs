using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SoftwareService
{
    public class SerializeConfig<T> where T : class
    {
        public static void Serialize(string path, T type)
        {
            var serializer = new XmlSerializer(type.GetType());
            using (var writer = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(writer, type);
            }
        }

        public static void SerializeList(string path, List<T> type)
        {
            var serializer = new XmlSerializer(type.GetType());
            using (var writer = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(writer, type);
            }
        }

        public static T DeSerialize(string path)
        {
            T type;
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = XmlReader.Create(path))
            {
                type = serializer.Deserialize(reader) as T;
            }
            return type;
        }

        public static List<T> DeSerializeList(string path)
        {
            List<T> type;
            var serializer = new XmlSerializer(typeof(List<T>));
            using (var reader = XmlReader.Create(path))
            {
                type = serializer.Deserialize(reader) as List<T>;
            }
            return type;
        }
    }
}
