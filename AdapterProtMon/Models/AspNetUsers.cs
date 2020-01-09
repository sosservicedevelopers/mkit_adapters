using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            AspNetUserTokens = new HashSet<AspNetUserTokens>();
            ListOfCinematography = new HashSet<ListOfCinematography>();
            ListOfCinematographyCertificates = new HashSet<ListOfCinematographyCertificates>();
            ListOfCinematographyDocuments = new HashSet<ListOfCinematographyDocuments>();
            ListOfCinematographyHistory = new HashSet<ListOfCinematographyHistory>();
            ListOfCinematographyServices = new HashSet<ListOfCinematographyServices>();
            ListOfControlMedia = new HashSet<ListOfControlMedia>();
            ListOfCouncilTheatrical = new HashSet<ListOfCouncilTheatrical>();
            ListOfCultAndArt = new HashSet<ListOfCultAndArt>();
            ListOfEduInstituts = new HashSet<ListOfEduInstituts>();
            ListOfEvents = new HashSet<ListOfEvents>();
            ListOfEventsTheatrical = new HashSet<ListOfEventsTheatrical>();
            ListOfTourizmIndicators = new HashSet<ListOfTourizmIndicators>();
            ListOfMedia = new HashSet<ListOfMedia>();
            ListOfMediaHistory = new HashSet<ListOfMediaHistory>();
            ListOfMonuments = new HashSet<ListOfMonuments>();
            ListOfMonumentsProtObjects = new HashSet<ListOfMonumentsProtObjects>();
            ListOfMonumetnTypologicalAccessory = new HashSet<ListOfMonumetnTypologicalAccessory>();
            ListOfRents = new HashSet<ListOfRents>();
            ListOfRentsHistory = new HashSet<ListOfRentsHistory>();
            ListOfStateAwards = new HashSet<ListOfStateAwards>();
            ListOfTeleRadio = new HashSet<ListOfTeleRadio>();
            ListOfTheatrical = new HashSet<ListOfTheatrical>();
            ListOfTheatricalHistory = new HashSet<ListOfTheatricalHistory>();
            ListOfTourism = new HashSet<ListOfTourism>();
            ListOfTourismHistory = new HashSet<ListOfTourismHistory>();
            ListOfTourismIndicator = new HashSet<ListOfTourismIndicator>();
            ListOfTourismServices = new HashSet<ListOfTourismServices>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public int DepartmentsId { get; set; }

        public virtual Departments Departments { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual ICollection<ListOfCinematography> ListOfCinematography { get; set; }
        public virtual ICollection<ListOfCinematographyCertificates> ListOfCinematographyCertificates { get; set; }
        public virtual ICollection<ListOfCinematographyDocuments> ListOfCinematographyDocuments { get; set; }
        public virtual ICollection<ListOfCinematographyHistory> ListOfCinematographyHistory { get; set; }
        public virtual ICollection<ListOfCinematographyServices> ListOfCinematographyServices { get; set; }
        public virtual ICollection<ListOfControlMedia> ListOfControlMedia { get; set; }
        public virtual ICollection<ListOfCouncilTheatrical> ListOfCouncilTheatrical { get; set; }
        public virtual ICollection<ListOfCultAndArt> ListOfCultAndArt { get; set; }
        public virtual ICollection<ListOfEduInstituts> ListOfEduInstituts { get; set; }
        public virtual ICollection<ListOfEvents> ListOfEvents { get; set; }
        public virtual ICollection<ListOfEventsTheatrical> ListOfEventsTheatrical { get; set; }
        public virtual ICollection<ListOfTourizmIndicators> ListOfTourizmIndicators { get; set; }
        public virtual ICollection<ListOfMedia> ListOfMedia { get; set; }
        public virtual ICollection<ListOfMediaHistory> ListOfMediaHistory { get; set; }
        public virtual ICollection<ListOfMonuments> ListOfMonuments { get; set; }
        public virtual ICollection<ListOfMonumentsProtObjects> ListOfMonumentsProtObjects { get; set; }
        public virtual ICollection<ListOfMonumetnTypologicalAccessory> ListOfMonumetnTypologicalAccessory { get; set; }
        public virtual ICollection<ListOfRents> ListOfRents { get; set; }
        public virtual ICollection<ListOfRentsHistory> ListOfRentsHistory { get; set; }
        public virtual ICollection<ListOfStateAwards> ListOfStateAwards { get; set; }
        public virtual ICollection<ListOfTeleRadio> ListOfTeleRadio { get; set; }
        public virtual ICollection<ListOfTheatrical> ListOfTheatrical { get; set; }
        public virtual ICollection<ListOfTheatricalHistory> ListOfTheatricalHistory { get; set; }
        public virtual ICollection<ListOfTourism> ListOfTourism { get; set; }
        public virtual ICollection<ListOfTourismHistory> ListOfTourismHistory { get; set; }
        public virtual ICollection<ListOfTourismIndicator> ListOfTourismIndicator { get; set; }
        public virtual ICollection<ListOfTourismServices> ListOfTourismServices { get; set; }
    }
}
