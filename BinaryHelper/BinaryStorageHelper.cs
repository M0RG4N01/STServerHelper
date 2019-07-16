using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST.BinaryHelper
{
    class BinaryStorageHelper
    {
        private const string path = "signature.sthelper";

        public void WriteToBinaryFile<T>(T objectWrite, bool append = false)
        {
            using (Stream stream = File.Open(path, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormat = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormat.Serialize(stream, objectWrite);
            }

            //Encrypt(File.ReadAllText(path));
        }

        public T ReadFromBinaryFile<T>()
        {
           // Decrypt(File.ReadAllText(path));

            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var binaryFormat = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormat.Deserialize(stream);
            }
        }
    }
}
