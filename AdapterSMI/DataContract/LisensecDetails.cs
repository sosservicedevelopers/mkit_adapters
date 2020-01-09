using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace AdapterMonListOfTourizm.DataContract
{
     
    [XmlType(TypeName = "ListOfMedias", Namespace = "http://producer.xroad.com")]
    public class ListOfMedias : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "INN", IsOptional = false, Order = 0)]
        public string INN { get; set; }
        [XRoadXmlElement(ElementName = "DictLegalForm", IsOptional = false, Order = 1)]
        public string DictLegalForm { get; set; }

        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 2)]
        public string Name { get; set; }

        [XRoadXmlElement(ElementName = "MediaType", IsOptional = false, Order = 3)]
        public string MediaType { get; set; }
        [XRoadXmlElement(ElementName = "PermisionNo", IsOptional = false, Order = 4)]
        public string PermisionNo { get; set; }

        [XRoadXmlElement(ElementName = "DepPermGive", IsOptional = false, Order = 5)]
        public string DepPermGive { get; set; }

        [XRoadXmlElement(ElementName = "RegistrationDate", IsOptional = false, Order = 6)]
        public DateTime? RegistrationDate { get; set; }
        [XRoadXmlElement(ElementName = "PermisionDate", IsOptional = false, Order = 7)]
        public DateTime? PermisionDate { get; set; }
        [XRoadXmlElement(ElementName = "WarningDate", IsOptional = false, Order = 8)]
        public DateTime? WarningDate { get; set; }
        [XRoadXmlElement(ElementName = "WarningEndDate", IsOptional = false, Order = 9)]
        public DateTime? WarningEndDate { get; set; }

    }

}