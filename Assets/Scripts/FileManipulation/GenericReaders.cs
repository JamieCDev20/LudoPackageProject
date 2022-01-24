using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace LudoReaders
{
    public class GenericReaders : MonoBehaviour
    {
        public static T ReadXML<T>(string _fileName)
        {
            T readData;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            FileStream fs = new FileStream(_fileName, FileMode.Open);
            readData = (T)xmlSerializer.Deserialize(fs);
            fs.Close();
            return readData;
        }
    }
}