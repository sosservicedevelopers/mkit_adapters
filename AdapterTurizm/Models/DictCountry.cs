using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictCountry
    {
        public DictCountry()
        {
            ListOfCinematographyCertificates = new HashSet<ListOfCinematographyCertificates>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string English { get; set; }
        public string Alpha2 { get; set; }
        public string Alpha3 { get; set; }
        public string Iso { get; set; }
        public string Location { get; set; }
        public string LocationPrecise { get; set; }

        public virtual ICollection<ListOfCinematographyCertificates> ListOfCinematographyCertificates { get; set; }
    }
}
