using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictRegion
    {
        public DictRegion()
        {
            DictDistrict = new HashSet<DictDistrict>();
        }

        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }

        public virtual ICollection<DictDistrict> DictDistrict { get; set; }
    }
}
