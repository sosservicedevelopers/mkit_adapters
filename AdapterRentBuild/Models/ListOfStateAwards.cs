using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfStateAwards
    {
        public int Id { get; set; }
        public string LastNameDirector { get; set; }
        public string FirstNameDirector { get; set; }
        public string PatronicNameDirector { get; set; }
        public int DictStateAwardsTypeId { get; set; }
        public int? DictAwardsPositionId { get; set; }
        public int? DictAwardsReasonId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictAwardsPosition DictAwardsPosition { get; set; }
        public virtual DictAwardsReason DictAwardsReason { get; set; }
        public virtual DictStateAwardsType DictStateAwardsType { get; set; }
    }
}
