using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Infrastructure.GameData.Interfaces;

namespace Infrastructure.GameData.Services
{
    public class BinnarySerializator : ISerializator
    {
        public void SaveData<T>(string path, T data)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using FileStream stream = new FileStream(path, FileMode.Create);
            formatter.Serialize(stream, data);
            stream.Close();
        }

        public T LoadData<T>(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using FileStream stream = new FileStream(path, FileMode.Open);
            T data = (T)formatter.Deserialize(stream);
            stream.Close();
            return data;
        }
    }
}