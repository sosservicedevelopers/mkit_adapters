using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfMonumentsProtObjects
    {
        public int Id { get; set; }
        public string NameRus { get; set; }
        public string NameKyrg { get; set; }
        public int? DictDistrictId { get; set; }
        public string LegalAddress { get; set; }
        public int? DictFinSourceId { get; set; }
        public string LastNameDirector { get; set; }
        public string FirstNameDirector { get; set; }
        public string PatronicNameDirector { get; set; }
        public string Contacts { get; set; }
        public string LegalDocs { get; set; }
        public string Ploshad { get; set; }
        public string CurrentStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictDistrict DictDistrict { get; set; }
        public virtual DictFinSource DictFinSource { get; set; }
    }
}
