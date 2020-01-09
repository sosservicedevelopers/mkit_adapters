using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictDistrict
    {
        public DictDistrict()
        {
            ListOfCinematography = new HashSet<ListOfCinematography>();
            ListOfCinematographyHistory = new HashSet<ListOfCinematographyHistory>();
            ListOfCultAndArt = new HashSet<ListOfCultAndArt>();
            ListOfMonuments = new HashSet<ListOfMonuments>();
            ListOfMonumentsProtObjects = new HashSet<ListOfMonumentsProtObjects>();
            ListOfTourism = new HashSet<ListOfTourism>();
            ListOfTourismHistory = new HashSet<ListOfTourismHistory>();
        }

        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public string City { get; set; }
        public int DictRegionId { get; set; }

        public virtual DictRegion DictRegion { get; set; }
        public virtual ICollection<ListOfCinematography> ListOfCinematography { get; set; }
        public virtual ICollection<ListOfCinematographyHistory> ListOfCinematographyHistory { get; set; }
        public virtual ICollection<ListOfCultAndArt> ListOfCultAndArt { get; set; }
        public virtual ICollection<ListOfMonuments> ListOfMonuments { get; set; }
        public virtual ICollection<ListOfMonumentsProtObjects> ListOfMonumentsProtObjects { get; set; }
        public virtual ICollection<ListOfTourism> ListOfTourism { get; set; }
        public virtual ICollection<ListOfTourismHistory> ListOfTourismHistory { get; set; }
    }
}
