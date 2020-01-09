using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictTourismServices
    {
        public DictTourismServices()
        {
            ListOfTourismServices = new HashSet<ListOfTourismServices>();
        }

        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public int? DictStatusId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual DictStatus DictStatus { get; set; }
        public virtual ICollection<ListOfTourismServices> ListOfTourismServices { get; set; }
    }
}
