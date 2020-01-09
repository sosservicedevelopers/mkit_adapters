using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfControlMedia
    {
        public int Id { get; set; }
        public int ListOfMediaId { get; set; }
        public int DictControlTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDatePeriod { get; set; }
        public DateTime? EndDatePeriod { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PatronicName { get; set; }
        public DateTime? ActDateControl { get; set; }
        public string NumberOfAct { get; set; }
        public int? DictMediaControlResultId { get; set; }
        public string NumberOfWarning { get; set; }
        public DateTime? WarningDate { get; set; }
        public DateTime? WarningEndDate { get; set; }
        public DateTime? WarningRemovalDate { get; set; }
        public DateTime? DateOfPenalty { get; set; }
        public string DocNumPenalty { get; set; }
        public string PenaltySum { get; set; }
        public DateTime? DateOfPenaltyPay { get; set; }
        public DateTime? AnulmentDate { get; set; }
        public string NumberOfAnulment { get; set; }
        public DateTime? DateOfSuit { get; set; }
        public string NumberOfSuit { get; set; }
        public DateTime? DateOfSuitPerm { get; set; }
        public string NumberOfSuitPerm { get; set; }
        public int? DictMediaSuitPermId { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictControlType DictControlType { get; set; }
        public virtual DictMediaControlResult DictMediaControlResult { get; set; }
        public virtual DictMediaSuitPerm DictMediaSuitPerm { get; set; }
        public virtual ListOfMedia ListOfMedia { get; set; }
    }
}
