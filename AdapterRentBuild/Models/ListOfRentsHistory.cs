using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfRentsHistory
    {
        public int Id { get; set; }
        public int ListOfRentsId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Cost { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual ListOfRents ListOfRents { get; set; }
    }
}
