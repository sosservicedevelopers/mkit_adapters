using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace AdapterMonListOfTourizm.DataContract
{

    [XmlType(TypeName = "ListOfEduOrg", Namespace = "http://producer.xroad.com")]
    public class ListOfEduOrg : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 0)]
        public string Name { get; set; }
        [XRoadXmlElement(ElementName = "DictLegalForm", IsOptional = false, Order = 1)]
        public string DictLegalForm { get; set; }
        [XRoadXmlElement(ElementName = "INN", IsOptional = false, Order = 2)]
        public string INN { get; set; }
        [XRoadXmlElement(ElementName = "Director", IsOptional = false, Order = 3)]
        public string Director { get; set; }
        [XRoadXmlElement(ElementName = "DictEduInstType", IsOptional = false, Order = 4)]
        public string DictEduInstType { get; set; }
        [XRoadXmlElement(ElementName = "DictFinSource", IsOptional = false, Order = 5)]
        public string DictFinSource { get; set; }
        [XRoadXmlElement(ElementName = "RegistrationDate", IsOptional = false, Order = 6)]
        public DateTime? RegistrationDate { get; set; }
        [XRoadXmlElement(ElementName = "LegalDocuments", IsOptional = false, Order = 7)]
        public string LegalDocuments { get; set; }

    }

}

