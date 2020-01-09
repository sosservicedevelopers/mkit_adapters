using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictInitiatorOfProj
    {
        public DictInitiatorOfProj()
        {
            ListOfCultEvents = new HashSet<ListOfCultEvents>();
            ListOfEvents = new HashSet<ListOfEvents>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ListOfCultEvents> ListOfCultEvents { get; set; }
        public virtual ICollection<ListOfEvents> ListOfEvents { get; set; }
    }
}
