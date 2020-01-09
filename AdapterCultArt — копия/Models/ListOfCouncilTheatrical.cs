using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfCouncilTheatrical
    {
        public int Id { get; set; }
        public int ListOfTheatricalId { get; set; }
        public string LastNameOfArts { get; set; }
        public string FirstNameOfArts { get; set; }
        public string PatronicNameOfArts { get; set; }
        public DateTime DateInArtCouncil { get; set; }
        public DateTime? DateOutArtCouncil { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
        public virtual ListOfTheatrical ListOfTheatrical { get; set; }
    }
}
