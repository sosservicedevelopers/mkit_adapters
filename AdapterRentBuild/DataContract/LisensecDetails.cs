using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace AdapterMonListOfTourizm.DataContract
{


    [XmlType(TypeName = "ListOfRntObjectRoom", Namespace = "http://producer.xroad.com")]
    public class ListOfRntObjectRoom : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "NameRentObj", IsOptional = false, Order = 0)]
        public string RentObj { get; set; }
        [XRoadXmlElement(ElementName = "StartDate", IsOptional = false, Order = 1)]
        public DateTime? StartDate { get; set; }
        [XRoadXmlElement(ElementName = "EndDate", IsOptional = false, Order = 2)]
        public DateTime? EndDate { get; set; }
        [XRoadXmlElement(ElementName = "Cost", IsOptional = false, Order = 3)]
        public decimal Cost { get; set; }

    }
}
