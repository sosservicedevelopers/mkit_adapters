using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictAwardsReason
    {
        public DictAwardsReason()
        {
            ListOfStateAwards = new HashSet<ListOfStateAwards>();
        }

        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public int? DictStatusId { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual DictStatus DictStatus { get; set; }
        public virtual ICollection<ListOfStateAwards> ListOfStateAwards { get; set; }
    }
}
