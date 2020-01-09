using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictCinemaRegiser
    {
        public DictCinemaRegiser()
        {
            ListOfCinematographyCertificates = new HashSet<ListOfCinematographyCertificates>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronic { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<ListOfCinematographyCertificates> ListOfCinematographyCertificates { get; set; }
    }
}
