using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfMediaHistory
    {
        public int Id { get; set; }
        public int ListOfMediaId { get; set; }
        public string NameRus { get; set; }
        public string NameKyrg { get; set; }
        public int? DictLegalFormId { get; set; }
        public string Inn { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string Name { get; set; }
        public string Territoryy { get; set; }
        public int? DictMediaLangTypeId { get; set; }
        public int? DictMediaTypeId { get; set; }
        public string AddressRus { get; set; }
        public string AddressKyrg { get; set; }
        public int? DictMediaFreqReleaseId { get; set; }
        public int? DictMediaFinSourceId { get; set; }
        public int? DictFinSourceId { get; set; }
        public DateTime? ReregistrationDate { get; set; }
        public DateTime? EliminationDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictFinSource DictFinSource { get; set; }
        public virtual DictLegalForm DictLegalForm { get; set; }
        public virtual DictMediaFreqRelease DictMediaFreqRelease { get; set; }
        public virtual DictMediaLangType DictMediaLangType { get; set; }
        public virtual DictMediaType DictMediaType { get; set; }
        public virtual ListOfMedia ListOfMedia { get; set; }
    }
}
