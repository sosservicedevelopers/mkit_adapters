using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace AdapterMonListOfTourizm.DataContract
{

    [XmlType(TypeName = "ListOfTZY", Namespace = "http://producer.xroad.com")]
    public class ListOfTZY : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 0)]
        public string Name { get; set; }
        [XRoadXmlElement(ElementName = "DictLegalForm", IsOptional = false, Order = 1)]
        public string DictLegalForm { get; set; }
        [XRoadXmlElement(ElementName = "INN", IsOptional = false, Order = 2)]
        public string INN { get; set; }
        [XRoadXmlElement(ElementName = "Director", IsOptional = false, Order = 3)]
        public string Director { get; set; }
        [XRoadXmlElement(ElementName = "ArtsDirector", IsOptional = false, Order = 4)]
        public string ArtsDirector { get; set; }
        [XRoadXmlElement(ElementName = "NumEmployees", IsOptional = false, Order = 5)]
        public int NumEmployees { get; set; }
        [XRoadXmlElement(ElementName = "DictFinSource", IsOptional = false, Order = 6)]
        public string DictFinSource { get; set; }
        [XRoadXmlElement(ElementName = "ReregistrationDate", IsOptional = false, Order = 6)]
        public DateTime? ReregistrationDate { get; set; }
}


    [XmlType(TypeName = "ListOfStateAward", Namespace = "http://producer.xroad.com")]
    public class ListOfStateAward: XRoadSerializable
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

    [XmlType(TypeName = "ListOfProtMonum", Namespace = "http://producer.xroad.com")]
    public class ListOfProtMonum : XRoadSerializable
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

    [XmlType(TypeName = "ListOfLibOrg", Namespace = "http://producer.xroad.com")]
    public class ListOfLibOrg : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 0)]
        public string Name { get; set; }
        [XRoadXmlElement(ElementName = "DataSozdania", IsOptional = false, Order = 1)]
        public DateTime DataSozdania { get; set; }
        [XRoadXmlElement(ElementName = "CountOfBook", IsOptional = false, Order = 2)]
        public string CountOfBook { get; set; }
        [XRoadXmlElement(ElementName = "CountOfReaders", IsOptional = false, Order = 3)]
        public string CountOfReaders { get; set; }
        [XRoadXmlElement(ElementName = "CountOfEmp", IsOptional = false, Order = 4)]
        public string CountOfEmp { get; set; }
        [XRoadXmlElement(ElementName = "Knigovydacha", IsOptional = false, Order = 5)]
        public string Knigovydacha { get; set; }
        [XRoadXmlElement(ElementName = "CopKyrg", IsOptional = false, Order = 6)]
        public string CopKyrg { get; set; }
        [XRoadXmlElement(ElementName = "EventsLib", IsOptional = false, Order = 7)]
        public string EventsLib { get; set; }
        [XRoadXmlElement(ElementName = "DegEducation", IsOptional = false, Order = 8)]
        public string DegEducation { get; set; }
        [XRoadXmlElement(ElementName = "PravaUstanavDoc", IsOptional = false, Order = 9)]
        public string PravaUstanavDoc { get; set; }
    }


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

    [XmlType(TypeName = "ListOfRntObject", Namespace = "http://producer.xroad.com")]
    public class ListOfRntObject : XRoadSerializable
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

    [XmlType(TypeName = "ListOfCinematographys", Namespace = "http://producer.xroad.com")]
    public class ListOfCinematographys : XRoadSerializable
    {
        [XRoadXmlElement(ElementName = "Name", IsOptional = false, Order = 0)]
        public string NameRus { get; set; }
        [XRoadXmlElement(ElementName = "DictLegalForm", IsOptional = false, Order = 1)]
        public string DictLegalForm { get; set; }
        [XRoadXmlElement(ElementName = "INN", IsOptional = false, Order = 2)]
        public string INN { get; set; }
        [XRoadXmlElement(ElementName = "FIO", IsOptional = false, Order = 3)]
        public string LastNameDirector { get; set; }
        //[XRoadXmlElement(ElementName = "DictFinSource", IsOptional = false, Order = 4)]
        //public string DictFinSource { get; set; }
        [XRoadXmlElement(ElementName = "Dictrict", IsOptional = false, Order = 4)]
        public string Dictrict { get; set; }
        [XRoadXmlElement(ElementName = "Address", IsOptional = false, Order = 5)]
        public string LegalAddress { get; set; }
        [XRoadXmlElement(ElementName = "RegistrationDate", IsOptional = false, Order = 6)]
        public DateTime? RegistrationDate { get; set; }

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