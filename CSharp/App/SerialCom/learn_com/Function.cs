using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;

namespace learn_com
{
    public static class Function
    {  
        public static byte[] HexStringToBytes(string str)
        {
            try
            {
                if (str == null || str == string.Empty)
                {
                    return null;
                }

                str = str.Trim();

                int i;
                string[] hexStrs = str.Split(' ');

                byte[] buf = new byte[hexStrs.Length];

                for (i = 0; i < hexStrs.Length; i++)
                {
                    buf[i] = Convert.ToByte(hexStrs[i], 16);
                }

                return buf;
              
            }
            catch
            {
                return null;
            }
        }


        public static bool XmlSerializeToFile(Type type, object obj, string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                

                XmlSerializer serializer = new XmlSerializer(type);
                //FileStream writer = new FileStream(filePath,FileMode.Create);
                TextWriter writer = new StreamWriter(filePath);
                serializer.Serialize(writer,obj);

                writer.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public static object XmlDeserializeFromFile(Type type, string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new Exception(filePath + " is not exists");
                } 

                XmlSerializer serializer = new XmlSerializer(type);
                FileStream stream = new FileStream(filePath,FileMode.Open);
                object obj = serializer.Deserialize(stream);
                stream.Close();
                return obj;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
