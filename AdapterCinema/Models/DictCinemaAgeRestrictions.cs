using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictCinemaAgeRestrictions
    {
        public DictCinemaAgeRestrictions()
        {
            ListOfCinematographyCertificates = new HashSet<ListOfCinematographyCertificates>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ListOfCinematographyCertificates> ListOfCinematographyCertificates { get; set; }
    }
}
