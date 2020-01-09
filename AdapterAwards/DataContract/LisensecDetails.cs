using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace AdapterMonListOfTourizm.DataContract
{



    [XmlType(TypeName = "ListOfStateAward", Namespace = "http://producer.xroad.com")]
    public class ListOfStateAward : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 0)]
        public string Name { get; set; }
        [XRoadXmlElement(ElementName = "DictStateAwardsType", IsOptional = false, Order = 1)]
        public string DictStateAwardsType { get; set; }
        [XRoadXmlElement(ElementName = "DictAwardsPosition", IsOptional = false, Order = 2)]
        public string DictAwardsPosition { get; set; }
        [XRoadXmlElement(ElementName = "DictAwardsReason", IsOptional = false, Order = 3)]
        public string DictAwardsReason { get; set; }
        [XRoadXmlElement(ElementName = "RegistrationDate", IsOptional = false, Order = 4)]
        public DateTime? RegistrationDate { get; set; }
    }


}