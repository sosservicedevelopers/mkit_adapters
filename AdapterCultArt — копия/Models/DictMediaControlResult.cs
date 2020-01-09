using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictMediaControlResult
    {
        public DictMediaControlResult()
        {
            ListOfControlMedia = new HashSet<ListOfControlMedia>();
        }

        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public DateTime CreateDate { get; set; }
        public int? DictStatusId { get; set; }
        public DateTime? DeactiveDate { get; set; }

        public virtual DictStatus DictStatus { get; set; }
        public virtual ICollection<ListOfControlMedia> ListOfControlMedia { get; set; }
    }
}
