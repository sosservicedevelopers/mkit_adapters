using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class Departments
    {
        public Departments()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contacts { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
