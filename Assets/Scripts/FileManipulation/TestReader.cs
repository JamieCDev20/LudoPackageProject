using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LudoReaders;
using System.Xml.Serialization;
public class TestReader : MonoBehaviour
{
    [SerializeField] private string s_fileName;
    [SerializeField] private TestXml testXml;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Application.dataPath + "/" + s_fileName);
        testXml = GenericReaders.ReadXML<TestXml>(Application.dataPath + "/" + s_fileName);
        foreach (TestEntries ents in testXml.entries)
            Debug.Log(ents.attribute);
    }
}

[XmlRoot(ElementName ="Test")]
public class TestXml
{
    [XmlElement(ElementName ="Entry")]
    public List<TestEntries> entries;

}

public class TestEntries
{
    [XmlAttribute(AttributeName = "attrib")]
    public string attribute;
}
