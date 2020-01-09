using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfMonuments
    {
        public ListOfMonuments()
        {
            ListOfMonumetnTypologicalAccessory = new HashSet<ListOfMonumetnTypologicalAccessory>();
        }

        public int Id { get; set; }
        public string NameRus { get; set; }
        public string NameKyrg { get; set; }
        public string DatingOfMonument { get; set; }
        public int? DictDistrictId { get; set; }
        public string LegalAddress { get; set; }
        public int? DictFinSourceId { get; set; }
        public int DictMonumentTypeId { get; set; }
        public int DictMonumemtSignOfLossId { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictDistrict DictDistrict { get; set; }
        public virtual DictFinSource DictFinSource { get; set; }
        public virtual DictMonumemtSignOfLoss DictMonumemtSignOfLoss { get; set; }
        public virtual DictMonumentType DictMonumentType { get; set; }
        public virtual ICollection<ListOfMonumetnTypologicalAccessory> ListOfMonumetnTypologicalAccessory { get; set; }
    }
}
