using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfTeleRadio
    {
        public int Id { get; set; }
        public int ListOfMediaId { get; set; }
        public DateTime CreateDate { get; set; }
        public int NumberOfPermission { get; set; }
        public DateTime PermissionDate { get; set; }
        public int? DictAgencyPermId { get; set; }
        public DateTime? DateOfPay { get; set; }
        public string NumOfPermGas { get; set; }
        public DateTime? PermGasdate { get; set; }
        public DateTime? PermElimGasdate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictAgencyPerm DictAgencyPerm { get; set; }
        public virtual ListOfMedia ListOfMedia { get; set; }
    }
}
