using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfTourizmIndicators
    {
        public int Id { get; set; }
        public string LibraryName { get; set; }
        public DateTime DataSozdania { get; set; }
        public string CountOfBook { get; set; }
        public string CountOfReaders { get; set; }
        public string CountOfEmp { get; set; }
        public string Knigovydacha { get; set; }
        public string AddressData { get; set; }
        public string TotalArea { get; set; }
        public string SeatLanding { get; set; }
        public string EmerCapLib { get; set; }
        public string SpecAdapLib { get; set; }
        public string OverhaulMade { get; set; }
        public string Redecorated { get; set; }
        public string Computers { get; set; }
        public string InternetConnection { get; set; }
        public string ComputersForUsers { get; set; }
        public string UserConnection { get; set; }
        public string UsersLib { get; set; }
        public string RecRetTotal { get; set; }
        public string TotalNumOfEx { get; set; }
        public string CopKyrg { get; set; }
        public string EventsLib { get; set; }
        public string Librarians { get; set; }
        public string DegEducation { get; set; }
        public string PravaUstanavDoc { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
    }
}
