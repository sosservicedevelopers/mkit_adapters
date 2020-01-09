using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictUnitOfMeasure
    {
        public DictUnitOfMeasure()
        {
            DictRentObjectType = new HashSet<DictRentObjectType>();
        }

        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public int? DictStatusId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual DictStatus DictStatus { get; set; }
        public virtual ICollection<DictRentObjectType> DictRentObjectType { get; set; }
    }
}
