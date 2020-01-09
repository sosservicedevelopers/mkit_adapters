using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace AdapterMonListOfTourizm.DataContract
{

    [XmlType(TypeName = "ListOfMonument", Namespace = "http://producer.xroad.com")]
    public class ListOfMonument : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 0)]
        public string Name { get; set; }
        [XRoadXmlElement(ElementName = "DatingOfMonument", IsOptional = false, Order = 1)]
        public string DatingOfMonument { get; set; }

        [XRoadXmlElement(ElementName = "District", IsOptional = false, Order = 2)]
        public string District { get; set; }

        [XRoadXmlElement(ElementName = "Address", IsOptional = false, Order = 3)]
        public string LegalAddress { get; set; }
        [XRoadXmlElement(ElementName = "DictMonumentType", IsOptional = false, Order = 4)]
        public string MonumentType { get; set; }
    }


}