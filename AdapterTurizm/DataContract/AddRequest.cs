using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XRoadLib.Serialization;

namespace AdapterMonListOfTourizm.DataContract
{
    [XmlType(TypeName = "AddRequest", Namespace = "http://producer.xroad.com")]
    public class AddRequest : XRoadSerializable
    {
        [XmlElement(Order = 0)]
        public string INN { get; set; }

        //[XmlElement(Order = 1)]
        //public string NumberOfLisences { get; set; }
    }
}
