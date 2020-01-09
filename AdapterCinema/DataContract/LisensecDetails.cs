using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace AdapterMonListOfTourizm.DataContract
{


    [XmlType(TypeName = "ListOfCinemaOrg", Namespace = "http://producer.xroad.com")]
    public class ListOfCinemaOrg : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 0)]
        public string Name { get; set; }
        [XRoadXmlElement(ElementName = "DictLegalForm", IsOptional = false, Order = 1)]
        public string DictLegalForm { get; set; }
        [XRoadXmlElement(ElementName = "INN", IsOptional = false, Order = 2)]
        public string INN { get; set; }
        [XRoadXmlElement(ElementName = "Director", IsOptional = false, Order = 3)]
        public string Director { get; set; }
        [XRoadXmlElement(ElementName = "DictFinSource", IsOptional = false, Order = 4)]
        public string DictFinSource { get; set; }
        [XRoadXmlElement(ElementName = "Address", IsOptional = false, Order = 5)]
        public string Address { get; set; }
        [XRoadXmlElement(ElementName = "DictDistrict", IsOptional = false, Order = 6)]
        public string DictDistrict { get; set; }
        [XRoadXmlElement(ElementName = "RegistrationDate", IsOptional = false, Order = 7)]
        public DateTime? RegistrationDate { get; set; }
    }

    [XmlType(TypeName = "ListOfCinemaDocs", Namespace = "http://producer.xroad.com")]
    public class ListOfCinemaDocs : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 0)]
        public string Name { get; set; }
        [XRoadXmlElement(ElementName = "RegistrationDate", IsOptional = false, Order = 1)]
        public DateTime? RegistrationDate { get; set; }
    }


    [XmlType(TypeName = "ListOfCinemaCert", Namespace = "http://producer.xroad.com")]
    public class ListOfCinemaCert : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 0)]
        public string Name { get; set; }
        [XRoadXmlElement(ElementName = "Country", IsOptional = false, Order = 1)]
        public string Country { get; set; }
        [XRoadXmlElement(ElementName = "Years", IsOptional = false, Order = 2)]
        public string Years { get; set; }
        [XRoadXmlElement(ElementName = "Regiser", IsOptional = false, Order = 3)]
        public string Regiser { get; set; }
        [XRoadXmlElement(ElementName = "Duration", IsOptional = false, Order = 4)]
        public string Duration { get; set; }
        [XRoadXmlElement(ElementName = "AgeRestrictions", IsOptional = false, Order = 5)]
        public string AgeRestrictions { get; set; }
        [XRoadXmlElement(ElementName = "RegistrationDate", IsOptional = false, Order = 5)]
        public DateTime RegistrationDate { get; set; }
    }

}

