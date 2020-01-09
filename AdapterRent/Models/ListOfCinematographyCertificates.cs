using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfCinematographyCertificates
    {
        public int Id { get; set; }
        public string NameRus { get; set; }
        public string NameKyrg { get; set; }
        public int? DictCountryId { get; set; }
        public string Years { get; set; }
        public int? DictCinemaRegiserId { get; set; }
        public int? DictCinemaDurationId { get; set; }
        public int? DictCinemaAgeRestrictionsId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictCinemaAgeRestrictions DictCinemaAgeRestrictions { get; set; }
        public virtual DictCinemaDuration DictCinemaDuration { get; set; }
        public virtual DictCinemaRegiser DictCinemaRegiser { get; set; }
        public virtual DictCountry DictCountry { get; set; }
    }
}
