using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Tennis_Management_Software.Saving
{
    public static class Serialization
    {
        /// <summary>
        /// Serializes an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object to serialize.</param>
        /// <param name="filePath">The filepath to serialize.</param>
        /// <param name="append">Indicates if the object shall be appended to an existing file.</param>
        public static void Serialize<T>(T obj, string filePath, bool append)
        {
            if (obj != null)
            {
                if (append)
                {
                    if (File.Exists(filePath))
                    {
                        using (FileStream fileStream = new FileStream(filePath, FileMode.Append))
                        {
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            binaryFormatter.Serialize(fileStream, obj);
                        }
                    }
                    else
                    {
                        using (Stream output = File.Create(filePath))
                        {
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            binaryFormatter.Serialize(output, obj);
                        }
                    }
                }
                else
                {
                    using (Stream output = File.Create(filePath))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        binaryFormatter.Serialize(output, obj);
                    }
                }
            }
        }

        /// <summary>
        /// Serializes a list of objects.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list of objects to serialize</param>
        /// <param name="filePath"The filepath to serialize.></param>
        /// <param name="append">Indicates if the objects shall be appended to an existing file.</param>
        public static void SerializeList<T>(List<T> list, string filePath, bool append)
        {
            if (list.Count > 0)
            {
                if (append)
                {
                    if (File.Exists(filePath))
                    {
                        using (FileStream fileStream = new FileStream(filePath, FileMode.Append))
                        {
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            foreach (T obj in list)
                                binaryFormatter.Serialize(fileStream, obj);
                            fileStream.Close();
                            fileStream.Dispose();
                        }
                    }
                    else
                    {
                        using (Stream output = File.Create(filePath))
                        {
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            foreach (T obj in list)
                                binaryFormatter.Serialize(output, obj);
                            output.Close();
                            output.Dispose();
                        }
                    }
                }
                else
                {
                    using (Stream output = File.Create(filePath))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        foreach (T obj in list)
                            binaryFormatter.Serialize(output, obj);
                        output.Close();
                        output.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// Deserializes a list of objects.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath">The filepath to deserialize from.</param>
        /// <returns></returns>
        public static List<T> DeserializeList<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (Stream input = File.OpenRead(filePath))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    T obj;
                    List<T> list = new List<T>();
                    while (input.Position != input.Length)
                    {
                        obj = (T)binaryFormatter.Deserialize(input);
                        list.Add(obj);
                    }
                    return list;
                }
            }
            return new List<T>();
        }

        /// <summary>
        /// Desirializes an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath">The filepath to deserialize from.</param>
        /// <returns></returns>
        public static T Deserialize<T>(string filePath) where T : new()
        {
            T obj = new T();
            if (File.Exists(filePath))
            {
                using (Stream input = File.OpenRead(filePath))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    obj = (T)binaryFormatter.Deserialize(input);
                    input.Dispose();
                }
            }
            return obj;
        }
    }
}
