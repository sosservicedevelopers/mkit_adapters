using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictEduInstType
    {
        public DictEduInstType()
        {
            ListOfEduInstituts = new HashSet<ListOfEduInstituts>();
        }

        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }

        public virtual ICollection<ListOfEduInstituts> ListOfEduInstituts { get; set; }
    }
}
