using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictFinSource
    {
        public DictFinSource()
        {
            ListOfCinematography = new HashSet<ListOfCinematography>();
            ListOfCinematographyHistory = new HashSet<ListOfCinematographyHistory>();
            ListOfCultAndArt = new HashSet<ListOfCultAndArt>();
            ListOfEduInstituts = new HashSet<ListOfEduInstituts>();
            ListOfMedia = new HashSet<ListOfMedia>();
            ListOfMediaHistory = new HashSet<ListOfMediaHistory>();
            ListOfMonuments = new HashSet<ListOfMonuments>();
            ListOfMonumentsProtObjects = new HashSet<ListOfMonumentsProtObjects>();
            ListOfTheatrical = new HashSet<ListOfTheatrical>();
            ListOfTheatricalHistory = new HashSet<ListOfTheatricalHistory>();
            ListOfTourism = new HashSet<ListOfTourism>();
            ListOfTourismHistory = new HashSet<ListOfTourismHistory>();
        }

        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public DateTime CreateDate { get; set; }
        public int? DictStatusId { get; set; }
        public DateTime? DeactiveDate { get; set; }

        public virtual DictStatus DictStatus { get; set; }
        public virtual ICollection<ListOfCinematography> ListOfCinematography { get; set; }
        public virtual ICollection<ListOfCinematographyHistory> ListOfCinematographyHistory { get; set; }
        public virtual ICollection<ListOfCultAndArt> ListOfCultAndArt { get; set; }
        public virtual ICollection<ListOfEduInstituts> ListOfEduInstituts { get; set; }
        public virtual ICollection<ListOfMedia> ListOfMedia { get; set; }
        public virtual ICollection<ListOfMediaHistory> ListOfMediaHistory { get; set; }
        public virtual ICollection<ListOfMonuments> ListOfMonuments { get; set; }
        public virtual ICollection<ListOfMonumentsProtObjects> ListOfMonumentsProtObjects { get; set; }
        public virtual ICollection<ListOfTheatrical> ListOfTheatrical { get; set; }
        public virtual ICollection<ListOfTheatricalHistory> ListOfTheatricalHistory { get; set; }
        public virtual ICollection<ListOfTourism> ListOfTourism { get; set; }
        public virtual ICollection<ListOfTourismHistory> ListOfTourismHistory { get; set; }
    }
}
