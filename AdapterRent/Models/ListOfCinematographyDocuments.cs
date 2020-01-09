using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class ListOfCinematographyDocuments
    {
        public int Id { get; set; }
        public string NameRus { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUsers ApplicationUser { get; set; }
    }
}
