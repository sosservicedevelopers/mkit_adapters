using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfTourismIndicator
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public string Gdp { get; set; }
        public string InTurist { get; set; }
        public string OutTurist { get; set; }
        public string VolumeOfServicesForExport { get; set; }
        public string VolumeOfServicesForImport { get; set; }
        public string SummOfInvestFromBudget { get; set; }
        public string SummOfPrivateDomesticInvest { get; set; }
        public string SummOfForeignInvest { get; set; }
        public string AverageMonthSalary { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
    }
}
