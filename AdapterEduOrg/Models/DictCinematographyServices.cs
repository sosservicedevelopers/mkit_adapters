using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictCinematographyServices
    {
        public DictCinematographyServices()
        {
            ListOfCinematographyServices = new HashSet<ListOfCinematographyServices>();
        }

        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public int? DictStatusId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual DictStatus DictStatus { get; set; }
        public virtual ICollection<ListOfCinematographyServices> ListOfCinematographyServices { get; set; }
    }
}
