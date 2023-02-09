using System;

namespace Infrastructure.GameData.Interfaces
{
    public interface ISerializator
    {
        public void SaveData<T>(string path, T data);
        public T LoadData<T>(string path);
    }
}