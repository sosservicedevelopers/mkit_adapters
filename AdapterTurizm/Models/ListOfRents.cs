using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfRents
    {
        public ListOfRents()
        {
            ListOfRentsHistory = new HashSet<ListOfRentsHistory>();
        }

        public int Id { get; set; }
        public string NameRus { get; set; }
        public string NameKyrg { get; set; }
        public int? DictRentObjectTypeId { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictRentObjectType DictRentObjectType { get; set; }
        public virtual ICollection<ListOfRentsHistory> ListOfRentsHistory { get; set; }
    }
}
