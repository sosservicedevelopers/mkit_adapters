using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfEduInstituts
    {
        public int Id { get; set; }
        public string NameRus { get; set; }
        public string NameKyrg { get; set; }
        public int? DictLegalFormId { get; set; }
        public string Inn { get; set; }
        public string LastNameDirector { get; set; }
        public string FirstNameDirector { get; set; }
        public string PatronicNameDirector { get; set; }
        public int DictEduInstTypeId { get; set; }
        public int? DictFinSourceId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? ReregistrationDate { get; set; }
        public DateTime? DeactiveDate { get; set; }
        public string LegalDocuments { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictEduInstType DictEduInstType { get; set; }
        public virtual DictFinSource DictFinSource { get; set; }
        public virtual DictLegalForm DictLegalForm { get; set; }
    }
}
