using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfCinematographyServices
    {
        public int Id { get; set; }
        public int DictCinematographyServicesId { get; set; }
        public int ListOfCinematographyId { get; set; }
        public int DictStatusId { get; set; }
        public DateTime? DeactivateStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictCinematographyServices DictCinematographyServices { get; set; }
        public virtual DictStatus DictStatus { get; set; }
        public virtual ListOfCinematography ListOfCinematography { get; set; }
    }
}
