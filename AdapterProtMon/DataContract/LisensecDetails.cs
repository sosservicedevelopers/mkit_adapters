using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace AdapterMonListOfTourizm.DataContract
{

    [XmlType(TypeName = "ListOfMonumProt", Namespace = "http://producer.xroad.com")]
    public class ListOfMonumProt : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 0)]
        public string Name { get; set; }
        [XRoadXmlElement(ElementName = "DictDistrict", IsOptional = false, Order = 1)]
        public string DictDistrict { get; set; }
        [XRoadXmlElement(ElementName = "Address", IsOptional = false, Order = 2)]
        public string Address { get; set; }
        [XRoadXmlElement(ElementName = "DictFinSource", IsOptional = false, Order = 3)]
        public string DictFinSource { get; set; }
        [XRoadXmlElement(ElementName = "Director", IsOptional = false, Order = 4)]
        public string Director { get; set; }
        [XRoadXmlElement(ElementName = "Contacts", IsOptional = false, Order = 5)]
        public string Contacts { get; set; }
        [XRoadXmlElement(ElementName = "LegalDocs", IsOptional = false, Order = 6)]
        public string LegalDocs { get; set; }
        [XRoadXmlElement(ElementName = "Ploshad", IsOptional = false, Order = 7)]
        public string Ploshad { get; set; }
        [XRoadXmlElement(ElementName = "CurrentStatus", IsOptional = false, Order = 8)]
        public string CurrentStatus { get; set; }
    }

}
