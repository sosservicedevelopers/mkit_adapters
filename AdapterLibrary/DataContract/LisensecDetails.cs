using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace AdapterMonListOfTourizm.DataContract
{
 
 

    [XmlType(TypeName = "ListOfLibOrg", Namespace = "http://producer.xroad.com")]
    public class ListOfLibOrg : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 0)]
        public string Name { get; set; }
        [XRoadXmlElement(ElementName = "DataSozdania", IsOptional = false, Order = 1)]
        public DateTime DataSozdania { get; set; }
        [XRoadXmlElement(ElementName = "CountOfBook", IsOptional = false, Order = 2)]
        public string CountOfBook { get; set; }
        [XRoadXmlElement(ElementName = "CountOfReaders", IsOptional = false, Order = 3)]
        public string CountOfReaders { get; set; }
        [XRoadXmlElement(ElementName = "CountOfEmp", IsOptional = false, Order = 4)]
        public string CountOfEmp { get; set; }
        [XRoadXmlElement(ElementName = "Knigovydacha", IsOptional = false, Order = 5)]
        public string Knigovydacha { get; set; }
        [XRoadXmlElement(ElementName = "CopKyrg", IsOptional = false, Order = 6)]
        public string CopKyrg { get; set; }
        [XRoadXmlElement(ElementName = "EventsLib", IsOptional = false, Order = 7)]
        public string EventsLib { get; set; }
        [XRoadXmlElement(ElementName = "DegEducation", IsOptional = false, Order = 8)]
        public string DegEducation { get; set; }
        [XRoadXmlElement(ElementName = "PravaUstanavDoc", IsOptional = false, Order = 9)]
        public string PravaUstanavDoc { get; set; }
    }


    

}