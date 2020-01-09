using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace AdapterMonListOfTourizm.DataContract
{


    [XmlType(TypeName = "ListIndicatorsOfTourizm", Namespace = "http://producer.xroad.com")]
    public class ListIndicatorsOfTourizm : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Year", IsOptional = false, Order = 0)]
        public string Year { get; set; }
        [XRoadXmlElement(ElementName = "Gdp", IsOptional = false, Order = 1)]
        public string Gdp { get; set; }

        [XRoadXmlElement(ElementName = "OutTurist", IsOptional = false, Order = 2)]
        public string OutTurist { get; set; }

        [XRoadXmlElement(ElementName = "VolumeOfServicesForExport", IsOptional = false, Order = 3)]
        public string VolumeOfServicesForExport { get; set; }
        [XRoadXmlElement(ElementName = "VolumeOfServicesForImport", IsOptional = false, Order = 4)]
        public string VolumeOfServicesForImport { get; set; }

        [XRoadXmlElement(ElementName = "SummOfInvestFromBudget", IsOptional = false, Order = 5)]
        public string SummOfInvestFromBudget { get; set; }

        [XRoadXmlElement(ElementName = "SummOfPrivateDomesticInvest", IsOptional = false, Order = 6)]
        public string SummOfPrivateDomesticInvest { get; set; }
        [XRoadXmlElement(ElementName = "AverageMonthSalary", IsOptional = false, Order = 7)]
        public string AverageMonthSalary { get; set; }
        [XRoadXmlElement(ElementName = "SummOfForeignInvest", IsOptional = false, Order = 8)]
        public string SummOfForeignInvest { get; set; }

    }


    [XmlType(TypeName = "ListOfTourizm", Namespace = "http://producer.xroad.com")]
    public class ListOfTourizm : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "INN", IsOptional = false, Order = 0)]
        public string INN { get; set; }
        [XRoadXmlElement(ElementName = "DictLegalForm", IsOptional = false, Order = 1)]
        public string DictLegalForm { get; set; }

        [XRoadXmlElement(ElementName = "NameRus", IsOptional = false, Order = 2)]
        public string NameRus { get; set; }

        [XRoadXmlElement(ElementName = "LegalAddress", IsOptional = false, Order = 3)]
        public string LegalAddress { get; set; }
        [XRoadXmlElement(ElementName = "NameDirector", IsOptional = false, Order = 4)]
        public string NameDirector { get; set; }

        [XRoadXmlElement(ElementName = "District", IsOptional = false, Order = 5)]
        public string District { get; set; }

        [XRoadXmlElement(ElementName = "RegistrationDate", IsOptional = false, Order = 6)]
        public DateTime? RegistrationDate { get; set; }

    }


}