using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConvertSolidCompass.Xmls
{
    [XmlRoot(ElementName = "VERSION")]
    public class VERSION
    {

        [XmlAttribute(AttributeName = "Number")]
        public string Number { get; set; }
    }

    [XmlRoot(ElementName = "VERSIONS")]
    public class VERSIONS
    {

        [XmlElement(ElementName = "DataProjectVersion")]
        public int DataProjectVersion { get; set; }

        [XmlElement(ElementName = "AppVersion")]
        public string AppVersion { get; set; }
    }

    [XmlRoot(ElementName = "LANGUAGE")]
    public class LANGUAGE
    {

        [XmlAttribute(AttributeName = "lang")]
        public string Lang { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DESCRIPTION")]
    public class DESCRIPTION
    {

        [XmlElement(ElementName = "LANGUAGE")]
        public List<LANGUAGE> LANGUAGE { get; set; }
    }

    [XmlRoot(ElementName = "EW_HEADER")]
    public class EWHEADER
    {

        [XmlElement(ElementName = "VERSION")]
        public VERSION VERSION { get; set; }

        [XmlElement(ElementName = "VERSIONS")]
        public VERSIONS VERSIONS { get; set; }

        [XmlElement(ElementName = "FILENAME")]
        public string FILENAME { get; set; }

        [XmlElement(ElementName = "DESCRIPTION")]
        public DESCRIPTION DESCRIPTION { get; set; }

        [XmlElement(ElementName = "FILE_TYPE")]
        public int FILETYPE { get; set; }

        [XmlElement(ElementName = "OBJECT_TYPE")]
        public int OBJECTTYPE { get; set; }

        [XmlElement(ElementName = "MEASURMENT")]
        public int MEASURMENT { get; set; }

        [XmlElement(ElementName = "Datatype")]
        public int Datatype { get; set; }
    }

    [XmlRoot(ElementName = "Description")]
    public class Description
    {

        [XmlElement(ElementName = "LANGUAGE")]
        public List<LANGUAGE> LANGUAGE { get; set; }
    }

    [XmlRoot(ElementName = "Header")]
    public class Header
    {

        [XmlElement(ElementName = "Description")]
        public Description Description { get; set; }
    }

    [XmlRoot(ElementName = "UserData")]
    public class UserData
    {

        [XmlElement(ElementName = "Description")]
        public Description Description { get; set; }

        [XmlElement(ElementName = "Index")]
        public int Index { get; set; }

        [XmlElement(ElementName = "Translatable")]
        public int Translatable { get; set; }

        [XmlElement(ElementName = "Visible")]
        public int Visible { get; set; }

        [XmlElement(ElementName = "ReadOnly")]
        public int ReadOnly { get; set; }

        [XmlElement(ElementName = "Formula")]
        public object Formula { get; set; }

        [XmlElement(ElementName = "MaxSize")]
        public int MaxSize { get; set; }
    }

    [XmlRoot(ElementName = "UserDataDescription")]
    public class UserDataDescription
    {

        [XmlElement(ElementName = "Header")]
        public List<Header> Header { get; set; }

        [XmlElement(ElementName = "UserData")]
        public List<UserData> UserData { get; set; }
    }

    [XmlRoot(ElementName = "ManufacturerData")]
    public class ManufacturerData
    {

        [XmlElement(ElementName = "Index")]
        public int Index { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "ManufacturerDatas")]
    public class ManufacturerDatas
    {

        [XmlElement(ElementName = "ManufacturerData")]
        public List<ManufacturerData> ManufacturerData { get; set; }
    }

    [XmlRoot(ElementName = "ClassProperties")]
    public class ClassProperties
    {

        [XmlElement(ElementName = "Root")]
        public string Root { get; set; }

        [XmlElement(ElementName = "Partname3D")]
        public object Partname3D { get; set; }

        [XmlElement(ElementName = "Footprint2D")]
        public object Footprint2D { get; set; }

        [XmlElement(ElementName = "ConnectonLabel")]
        public object ConnectonLabel { get; set; }

        [XmlElement(ElementName = "ManufacturerDatas")]
        public ManufacturerDatas ManufacturerDatas { get; set; }
    }

    [XmlRoot(ElementName = "SECTIONS")]
    public class SECTIONS
    {

        [XmlElement(ElementName = "EW_HEADER")]
        public EWHEADER EWHEADER { get; set; }

        [XmlElement(ElementName = "UserDataDescription")]
        public UserDataDescription UserDataDescription { get; set; }

        [XmlElement(ElementName = "ClassProperties")]
        public ClassProperties ClassProperties { get; set; }
    }


}
