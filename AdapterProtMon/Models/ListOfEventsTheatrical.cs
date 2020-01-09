using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfEventsTheatrical
    {
        public int Id { get; set; }
        public int ListOfTheatricalId { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string DayOfMonth { get; set; }
        public string Time { get; set; }
        public string NameOfEvent { get; set; }
        public int DictTheatricalHallId { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictTheatricalHall DictTheatricalHall { get; set; }
        public virtual ListOfTheatrical ListOfTheatrical { get; set; }
    }
}
