using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfEvents
    {
        public int Id { get; set; }
        public int DictTypeOfKmmid { get; set; }
        public int DistLocId { get; set; }
        public string EventTopic { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }
        public int DictInitiatorOfProjId { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual DictInitiatorOfProj DictInitiatorOfProj { get; set; }
        public virtual DictTypeOfKmm DictTypeOfKmm { get; set; }
        public virtual DictLoc DistLoc { get; set; }
    }
}
