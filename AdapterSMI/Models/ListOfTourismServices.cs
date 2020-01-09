using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfTourismServices
    {
        public int Id { get; set; }
        public int DictTourismServicesId { get; set; }
        public int ListOfTourismId { get; set; }
        public int DictStatusId { get; set; }
        public DateTime? DeactivateStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictStatus DictStatus { get; set; }
        public virtual DictTourismServices DictTourismServices { get; set; }
        public virtual ListOfTourism ListOfTourism { get; set; }
    }
}
