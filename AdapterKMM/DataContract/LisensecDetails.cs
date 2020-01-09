using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace AdapterMonListOfTourizm.DataContract
{


    [XmlType(TypeName = "ListOfEvtObj", Namespace = "http://producer.xroad.com")]
    public class ListOfEvtObj : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "EvtName", IsOptional = false, Order = 0)]
        public string EvtName { get; set; }
        [XRoadXmlElement(ElementName = "Location", IsOptional = false, Order = 1)]
        public string Location { get; set; }
        [XRoadXmlElement(ElementName = "EventTopic", IsOptional = false, Order = 2)]
        public string EventTopic { get; set; }
        [XRoadXmlElement(ElementName = "StartDate", IsOptional = false, Order = 3)]
        public string StartDate { get; set; }
        [XRoadXmlElement(ElementName = "EndDate", IsOptional = false, Order = 4)]
        public string EndDate { get; set; }
        [XRoadXmlElement(ElementName = "Initiator", IsOptional = false, Order = 5)]
        public string Initiator { get; set; }
    }

}