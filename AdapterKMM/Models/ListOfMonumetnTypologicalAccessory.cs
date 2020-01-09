using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfMonumetnTypologicalAccessory
    {
        public int Id { get; set; }
        public int ListOfMonumentsId { get; set; }
        public int DictMonumentTypologicalTypeId { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictMonumentTypologicalType DictMonumentTypologicalType { get; set; }
        public virtual ListOfMonuments ListOfMonuments { get; set; }
    }
}
