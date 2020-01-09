using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictRentObjectType
    {
        public DictRentObjectType()
        {
            ListOfRents = new HashSet<ListOfRents>();
        }

        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public int? DictUnitOfMeasureId { get; set; }
        public int? DictStatusId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual DictStatus DictStatus { get; set; }
        public virtual DictUnitOfMeasure DictUnitOfMeasure { get; set; }
        public virtual ICollection<ListOfRents> ListOfRents { get; set; }
    }
}
