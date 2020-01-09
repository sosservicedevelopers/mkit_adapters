using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AdapterLibrary
{
    public class ApplicationUser : IdentityUser
    {
        public int DepartmentsId { get; set; }   // Код департамента
        public Departments Departments { get; set; }
    }



    public partial class aismkitdbContext : DbContext
    {
        public aismkitdbContext()
        {
        }

        public aismkitdbContext(DbContextOptions<aismkitdbContext> options)
            : base(options)
        {
        }
        public DbSet<ListOfTourizmIndicators> ListOfLibraryIndicators { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<DictAgencyPerm> DictAgencyPerm { get; set; }
        public virtual DbSet<DictAwardsPosition> DictAwardsPosition { get; set; }
        public virtual DbSet<DictAwardsReason> DictAwardsReason { get; set; }
        public virtual DbSet<DictCinemaAgeRestrictions> DictCinemaAgeRestrictions { get; set; }
        public virtual DbSet<DictCinemaDuration> DictCinemaDuration { get; set; }
        public virtual DbSet<DictCinemaRegiser> DictCinemaRegiser { get; set; }
        public virtual DbSet<DictCinematographyServices> DictCinematographyServices { get; set; }
        public virtual DbSet<DictControlType> DictControlType { get; set; }
        public virtual DbSet<DictCountry> DictCountry { get; set; }
        public virtual DbSet<DictCultAndArtType> DictCultAndArtType { get; set; }
        public virtual DbSet<DictDistrict> DictDistrict { get; set; }
        public virtual DbSet<DictEduInstType> DictEduInstType { get; set; }
        public virtual DbSet<DictFinSource> DictFinSource { get; set; }
        public virtual DbSet<DictInitiatorOfProj> DictInitiatorOfProj { get; set; }
        public virtual DbSet<DictLegalForm> DictLegalForm { get; set; }
        public virtual DbSet<DictLoc> DictLoc { get; set; }
        public virtual DbSet<DictMediaControlResult> DictMediaControlResult { get; set; }
        public virtual DbSet<DictMediaDistribTerritory> DictMediaDistribTerritory { get; set; }
        public virtual DbSet<DictMediaFreqRelease> DictMediaFreqRelease { get; set; }
        public virtual DbSet<DictMediaLangType> DictMediaLangType { get; set; }
        public virtual DbSet<DictMediaSuitPerm> DictMediaSuitPerm { get; set; }
        public virtual DbSet<DictMediaType> DictMediaType { get; set; }
        public virtual DbSet<DictMonumemtSignOfLoss> DictMonumemtSignOfLoss { get; set; }
        public virtual DbSet<DictMonumentType> DictMonumentType { get; set; }
        public virtual DbSet<DictMonumentTypologicalType> DictMonumentTypologicalType { get; set; }
        public virtual DbSet<DictRegion> DictRegion { get; set; }
        public virtual DbSet<DictRentObjectType> DictRentObjectType { get; set; }
        public virtual DbSet<DictStateAwardsType> DictStateAwardsType { get; set; }
        public virtual DbSet<DictStatus> DictStatus { get; set; }
        public virtual DbSet<DictTheatricalHall> DictTheatricalHall { get; set; }
        public virtual DbSet<DictTourismServices> DictTourismServices { get; set; }
        public virtual DbSet<DictTypeOfKmm> DictTypeOfKmm { get; set; }
        public virtual DbSet<DictUnitOfMeasure> DictUnitOfMeasure { get; set; }
        public virtual DbSet<ListOfCinematography> ListOfCinematography { get; set; }
        public virtual DbSet<ListOfCinematographyCertificates> ListOfCinematographyCertificates { get; set; }
        public virtual DbSet<ListOfCinematographyDocuments> ListOfCinematographyDocuments { get; set; }
        public virtual DbSet<ListOfCinematographyHistory> ListOfCinematographyHistory { get; set; }
        public virtual DbSet<ListOfCinematographyServices> ListOfCinematographyServices { get; set; }
        public virtual DbSet<ListOfControlMedia> ListOfControlMedia { get; set; }
        public virtual DbSet<ListOfCouncilTheatrical> ListOfCouncilTheatrical { get; set; }
        public virtual DbSet<ListOfCultAndArt> ListOfCultAndArt { get; set; }
        public virtual DbSet<ListOfCultEvents> ListOfCultEvents { get; set; }
        public virtual DbSet<ListOfEduInstituts> ListOfEduInstituts { get; set; }
        public virtual DbSet<ListOfEvents> ListOfEvents { get; set; }
        public virtual DbSet<ListOfEventsTheatrical> ListOfEventsTheatrical { get; set; }
        public virtual DbSet<ListOfTourizmIndicators> ListOfTourizmIndicators { get; set; }
        public virtual DbSet<ListOfMedia> ListOfMedia { get; set; }
        public virtual DbSet<ListOfMediaHistory> ListOfMediaHistory { get; set; }
        public virtual DbSet<ListOfMonuments> ListOfMonuments { get; set; }
        public virtual DbSet<ListOfMonumentsProtObjects> ListOfMonumentsProtObjects { get; set; }
        public virtual DbSet<ListOfMonumetnTypologicalAccessory> ListOfMonumetnTypologicalAccessory { get; set; }
        public virtual DbSet<ListOfRents> ListOfRents { get; set; }
        public virtual DbSet<ListOfRentsHistory> ListOfRentsHistory { get; set; }
        public virtual DbSet<ListOfStateAwards> ListOfStateAwards { get; set; }
        public virtual DbSet<ListOfTeleRadio> ListOfTeleRadio { get; set; }
        public virtual DbSet<ListOfTheatrical> ListOfTheatrical { get; set; }
        public virtual DbSet<ListOfTheatricalHistory> ListOfTheatricalHistory { get; set; }
        public virtual DbSet<ListOfTourism> ListOfTourism { get; set; }
        public virtual DbSet<ListOfTourismHistory> ListOfTourismHistory { get; set; }
        public virtual DbSet<ListOfTourismIndicator> ListOfTourismIndicator { get; set; }
        public virtual DbSet<ListOfTourismServices> ListOfTourismServices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5432;Database=aismkitdb;Username=postgres;Password=dbPwdAdmin");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.DepartmentsId);

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEnd).HasColumnType("timestamp with time zone");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Departments)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.DepartmentsId);
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<DictAgencyPerm>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictAgencyPerm)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictAwardsPosition>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictAwardsPosition)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictAwardsReason>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictAwardsReason)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictCinematographyServices>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictCinematographyServices)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictControlType>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictControlType)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictCountry>(entity =>
            {
                entity.Property(e => e.Iso).HasColumnName("ISO");
            });

            modelBuilder.Entity<DictCultAndArtType>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictCultAndArtType)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictDistrict>(entity =>
            {
                entity.HasIndex(e => e.DictRegionId);

                entity.HasOne(d => d.DictRegion)
                    .WithMany(p => p.DictDistrict)
                    .HasForeignKey(d => d.DictRegionId);
            });

            modelBuilder.Entity<DictFinSource>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictFinSource)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictLegalForm>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictLegalForm)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictMediaControlResult>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictMediaControlResult)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictMediaFreqRelease>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictMediaFreqRelease)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictMediaLangType>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictMediaLangType)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictMediaSuitPerm>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictMediaSuitPerm)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictMediaType>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictMediaType)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictMonumemtSignOfLoss>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictMonumemtSignOfLoss)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictMonumentType>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictMonumentType)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictMonumentTypologicalType>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictMonumentTypologicalType)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictRentObjectType>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasIndex(e => e.DictUnitOfMeasureId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictRentObjectType)
                    .HasForeignKey(d => d.DictStatusId);

                entity.HasOne(d => d.DictUnitOfMeasure)
                    .WithMany(p => p.DictRentObjectType)
                    .HasForeignKey(d => d.DictUnitOfMeasureId);
            });

            modelBuilder.Entity<DictStateAwardsType>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictStateAwardsType)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictTheatricalHall>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictTheatricalHall)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictTourismServices>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictTourismServices)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<DictTypeOfKmm>(entity =>
            {
                entity.ToTable("DictTypeOfKMM");
            });

            modelBuilder.Entity<DictUnitOfMeasure>(entity =>
            {
                entity.HasIndex(e => e.DictStatusId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.DictUnitOfMeasure)
                    .HasForeignKey(d => d.DictStatusId);
            });

            modelBuilder.Entity<ListOfCinematography>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictDistrictId);

                entity.HasIndex(e => e.DictFinSourceId);

                entity.HasIndex(e => e.DictLegalFormId);

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfCinematography)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictDistrict)
                    .WithMany(p => p.ListOfCinematography)
                    .HasForeignKey(d => d.DictDistrictId);

                entity.HasOne(d => d.DictFinSource)
                    .WithMany(p => p.ListOfCinematography)
                    .HasForeignKey(d => d.DictFinSourceId);

                entity.HasOne(d => d.DictLegalForm)
                    .WithMany(p => p.ListOfCinematography)
                    .HasForeignKey(d => d.DictLegalFormId);
            });

            modelBuilder.Entity<ListOfCinematographyCertificates>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictCinemaAgeRestrictionsId);

                entity.HasIndex(e => e.DictCinemaDurationId);

                entity.HasIndex(e => e.DictCinemaRegiserId);

                entity.HasIndex(e => e.DictCountryId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfCinematographyCertificates)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_ListOfCinematographyCertificates_AspNetUsers_ApplicationUse~");

                entity.HasOne(d => d.DictCinemaAgeRestrictions)
                    .WithMany(p => p.ListOfCinematographyCertificates)
                    .HasForeignKey(d => d.DictCinemaAgeRestrictionsId)
                    .HasConstraintName("FK_ListOfCinematographyCertificates_DictCinemaAgeRestrictions_~");

                entity.HasOne(d => d.DictCinemaDuration)
                    .WithMany(p => p.ListOfCinematographyCertificates)
                    .HasForeignKey(d => d.DictCinemaDurationId)
                    .HasConstraintName("FK_ListOfCinematographyCertificates_DictCinemaDuration_DictCin~");

                entity.HasOne(d => d.DictCinemaRegiser)
                    .WithMany(p => p.ListOfCinematographyCertificates)
                    .HasForeignKey(d => d.DictCinemaRegiserId)
                    .HasConstraintName("FK_ListOfCinematographyCertificates_DictCinemaRegiser_DictCine~");

                entity.HasOne(d => d.DictCountry)
                    .WithMany(p => p.ListOfCinematographyCertificates)
                    .HasForeignKey(d => d.DictCountryId);
            });

            modelBuilder.Entity<ListOfCinematographyDocuments>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfCinematographyDocuments)
                    .HasForeignKey(d => d.ApplicationUserId);
            });

            modelBuilder.Entity<ListOfCinematographyHistory>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictDistrictId);

                entity.HasIndex(e => e.DictFinSourceId);

                entity.HasIndex(e => e.DictLegalFormId);

                entity.HasIndex(e => e.ListOfCinematographyId);

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfCinematographyHistory)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictDistrict)
                    .WithMany(p => p.ListOfCinematographyHistory)
                    .HasForeignKey(d => d.DictDistrictId);

                entity.HasOne(d => d.DictFinSource)
                    .WithMany(p => p.ListOfCinematographyHistory)
                    .HasForeignKey(d => d.DictFinSourceId);

                entity.HasOne(d => d.DictLegalForm)
                    .WithMany(p => p.ListOfCinematographyHistory)
                    .HasForeignKey(d => d.DictLegalFormId);

                entity.HasOne(d => d.ListOfCinematography)
                    .WithMany(p => p.ListOfCinematographyHistory)
                    .HasForeignKey(d => d.ListOfCinematographyId)
                    .HasConstraintName("FK_ListOfCinematographyHistory_ListOfCinematography_ListOfCine~");
            });

            modelBuilder.Entity<ListOfCinematographyServices>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictCinematographyServicesId);

                entity.HasIndex(e => e.DictStatusId);

                entity.HasIndex(e => e.ListOfCinematographyId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfCinematographyServices)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictCinematographyServices)
                    .WithMany(p => p.ListOfCinematographyServices)
                    .HasForeignKey(d => d.DictCinematographyServicesId)
                    .HasConstraintName("FK_ListOfCinematographyServices_DictCinematographyServices_Dic~");

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.ListOfCinematographyServices)
                    .HasForeignKey(d => d.DictStatusId);

                entity.HasOne(d => d.ListOfCinematography)
                    .WithMany(p => p.ListOfCinematographyServices)
                    .HasForeignKey(d => d.ListOfCinematographyId)
                    .HasConstraintName("FK_ListOfCinematographyServices_ListOfCinematography_ListOfCin~");
            });

            modelBuilder.Entity<ListOfControlMedia>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictControlTypeId);

                entity.HasIndex(e => e.DictMediaControlResultId);

                entity.HasIndex(e => e.DictMediaSuitPermId);

                entity.HasIndex(e => e.ListOfMediaId);

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfControlMedia)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictControlType)
                    .WithMany(p => p.ListOfControlMedia)
                    .HasForeignKey(d => d.DictControlTypeId);

                entity.HasOne(d => d.DictMediaControlResult)
                    .WithMany(p => p.ListOfControlMedia)
                    .HasForeignKey(d => d.DictMediaControlResultId)
                    .HasConstraintName("FK_ListOfControlMedia_DictMediaControlResult_DictMediaControlR~");

                entity.HasOne(d => d.DictMediaSuitPerm)
                    .WithMany(p => p.ListOfControlMedia)
                    .HasForeignKey(d => d.DictMediaSuitPermId);

                entity.HasOne(d => d.ListOfMedia)
                    .WithMany(p => p.ListOfControlMedia)
                    .HasForeignKey(d => d.ListOfMediaId);
            });

            modelBuilder.Entity<ListOfCouncilTheatrical>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.ListOfTheatricalId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfCouncilTheatrical)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.ListOfTheatrical)
                    .WithMany(p => p.ListOfCouncilTheatrical)
                    .HasForeignKey(d => d.ListOfTheatricalId);
            });

            modelBuilder.Entity<ListOfCultAndArt>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictCultAndArtTypeId);

                entity.HasIndex(e => e.DictDistrictId);

                entity.HasIndex(e => e.DictFinSourceId);

                entity.HasIndex(e => e.DictLegalFormId);

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfCultAndArt)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictCultAndArtType)
                    .WithMany(p => p.ListOfCultAndArt)
                    .HasForeignKey(d => d.DictCultAndArtTypeId);

                entity.HasOne(d => d.DictDistrict)
                    .WithMany(p => p.ListOfCultAndArt)
                    .HasForeignKey(d => d.DictDistrictId);

                entity.HasOne(d => d.DictFinSource)
                    .WithMany(p => p.ListOfCultAndArt)
                    .HasForeignKey(d => d.DictFinSourceId);

                entity.HasOne(d => d.DictLegalForm)
                    .WithMany(p => p.ListOfCultAndArt)
                    .HasForeignKey(d => d.DictLegalFormId);
            });

            modelBuilder.Entity<ListOfCultEvents>(entity =>
            {
                entity.HasIndex(e => e.DictInitiatorOfProjId);

                entity.HasIndex(e => e.DictTypeOfKmmid);

                entity.HasIndex(e => e.DistLocId);

                entity.Property(e => e.DictTypeOfKmmid).HasColumnName("DictTypeOfKMMId");

                entity.HasOne(d => d.DictInitiatorOfProj)
                    .WithMany(p => p.ListOfCultEvents)
                    .HasForeignKey(d => d.DictInitiatorOfProjId);

                entity.HasOne(d => d.DictTypeOfKmm)
                    .WithMany(p => p.ListOfCultEvents)
                    .HasForeignKey(d => d.DictTypeOfKmmid);

                entity.HasOne(d => d.DistLoc)
                    .WithMany(p => p.ListOfCultEvents)
                    .HasForeignKey(d => d.DistLocId);
            });

            modelBuilder.Entity<ListOfEduInstituts>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictEduInstTypeId);

                entity.HasIndex(e => e.DictFinSourceId);

                entity.HasIndex(e => e.DictLegalFormId);

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfEduInstituts)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictEduInstType)
                    .WithMany(p => p.ListOfEduInstituts)
                    .HasForeignKey(d => d.DictEduInstTypeId);

                entity.HasOne(d => d.DictFinSource)
                    .WithMany(p => p.ListOfEduInstituts)
                    .HasForeignKey(d => d.DictFinSourceId);

                entity.HasOne(d => d.DictLegalForm)
                    .WithMany(p => p.ListOfEduInstituts)
                    .HasForeignKey(d => d.DictLegalFormId);
            });

            modelBuilder.Entity<ListOfEvents>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictInitiatorOfProjId);

                entity.HasIndex(e => e.DictTypeOfKmmid);

                entity.HasIndex(e => e.DistLocId);

                entity.Property(e => e.DictTypeOfKmmid).HasColumnName("DictTypeOfKMMId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfEvents)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictInitiatorOfProj)
                    .WithMany(p => p.ListOfEvents)
                    .HasForeignKey(d => d.DictInitiatorOfProjId);

                entity.HasOne(d => d.DictTypeOfKmm)
                    .WithMany(p => p.ListOfEvents)
                    .HasForeignKey(d => d.DictTypeOfKmmid);

                entity.HasOne(d => d.DistLoc)
                    .WithMany(p => p.ListOfEvents)
                    .HasForeignKey(d => d.DistLocId);
            });

            modelBuilder.Entity<ListOfEventsTheatrical>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictTheatricalHallId);

                entity.HasIndex(e => e.ListOfTheatricalId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfEventsTheatrical)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictTheatricalHall)
                    .WithMany(p => p.ListOfEventsTheatrical)
                    .HasForeignKey(d => d.DictTheatricalHallId)
                    .HasConstraintName("FK_ListOfEventsTheatrical_DictTheatricalHall_DictTheatricalHal~");

                entity.HasOne(d => d.ListOfTheatrical)
                    .WithMany(p => p.ListOfEventsTheatrical)
                    .HasForeignKey(d => d.ListOfTheatricalId);
            });

            modelBuilder.Entity<ListOfTourizmIndicators>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfTourizmIndicators)
                    .HasForeignKey(d => d.ApplicationUserId);
            });

            modelBuilder.Entity<ListOfMedia>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictFinSourceId);

                entity.HasIndex(e => e.DictLegalFormId);

                entity.HasIndex(e => e.DictMediaFreqReleaseId);

                entity.HasIndex(e => e.DictMediaLangTypeId);

                entity.HasIndex(e => e.DictMediaTypeId);

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfMedia)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictFinSource)
                    .WithMany(p => p.ListOfMedia)
                    .HasForeignKey(d => d.DictFinSourceId);

                entity.HasOne(d => d.DictLegalForm)
                    .WithMany(p => p.ListOfMedia)
                    .HasForeignKey(d => d.DictLegalFormId);

                entity.HasOne(d => d.DictMediaFreqRelease)
                    .WithMany(p => p.ListOfMedia)
                    .HasForeignKey(d => d.DictMediaFreqReleaseId);

                entity.HasOne(d => d.DictMediaLangType)
                    .WithMany(p => p.ListOfMedia)
                    .HasForeignKey(d => d.DictMediaLangTypeId);

                entity.HasOne(d => d.DictMediaType)
                    .WithMany(p => p.ListOfMedia)
                    .HasForeignKey(d => d.DictMediaTypeId);
            });

            modelBuilder.Entity<ListOfMediaHistory>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictFinSourceId);

                entity.HasIndex(e => e.DictLegalFormId);

                entity.HasIndex(e => e.DictMediaFreqReleaseId);

                entity.HasIndex(e => e.DictMediaLangTypeId);

                entity.HasIndex(e => e.DictMediaTypeId);

                entity.HasIndex(e => e.ListOfMediaId);

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfMediaHistory)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictFinSource)
                    .WithMany(p => p.ListOfMediaHistory)
                    .HasForeignKey(d => d.DictFinSourceId);

                entity.HasOne(d => d.DictLegalForm)
                    .WithMany(p => p.ListOfMediaHistory)
                    .HasForeignKey(d => d.DictLegalFormId);

                entity.HasOne(d => d.DictMediaFreqRelease)
                    .WithMany(p => p.ListOfMediaHistory)
                    .HasForeignKey(d => d.DictMediaFreqReleaseId)
                    .HasConstraintName("FK_ListOfMediaHistory_DictMediaFreqRelease_DictMediaFreqReleas~");

                entity.HasOne(d => d.DictMediaLangType)
                    .WithMany(p => p.ListOfMediaHistory)
                    .HasForeignKey(d => d.DictMediaLangTypeId);

                entity.HasOne(d => d.DictMediaType)
                    .WithMany(p => p.ListOfMediaHistory)
                    .HasForeignKey(d => d.DictMediaTypeId);

                entity.HasOne(d => d.ListOfMedia)
                    .WithMany(p => p.ListOfMediaHistory)
                    .HasForeignKey(d => d.ListOfMediaId);
            });

            modelBuilder.Entity<ListOfMonuments>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictDistrictId);

                entity.HasIndex(e => e.DictFinSourceId);

                entity.HasIndex(e => e.DictMonumemtSignOfLossId);

                entity.HasIndex(e => e.DictMonumentTypeId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfMonuments)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictDistrict)
                    .WithMany(p => p.ListOfMonuments)
                    .HasForeignKey(d => d.DictDistrictId);

                entity.HasOne(d => d.DictFinSource)
                    .WithMany(p => p.ListOfMonuments)
                    .HasForeignKey(d => d.DictFinSourceId);

                entity.HasOne(d => d.DictMonumemtSignOfLoss)
                    .WithMany(p => p.ListOfMonuments)
                    .HasForeignKey(d => d.DictMonumemtSignOfLossId)
                    .HasConstraintName("FK_ListOfMonuments_DictMonumemtSignOfLoss_DictMonumemtSignOfLo~");

                entity.HasOne(d => d.DictMonumentType)
                    .WithMany(p => p.ListOfMonuments)
                    .HasForeignKey(d => d.DictMonumentTypeId);
            });

            modelBuilder.Entity<ListOfMonumentsProtObjects>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictDistrictId);

                entity.HasIndex(e => e.DictFinSourceId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfMonumentsProtObjects)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictDistrict)
                    .WithMany(p => p.ListOfMonumentsProtObjects)
                    .HasForeignKey(d => d.DictDistrictId);

                entity.HasOne(d => d.DictFinSource)
                    .WithMany(p => p.ListOfMonumentsProtObjects)
                    .HasForeignKey(d => d.DictFinSourceId);
            });

            modelBuilder.Entity<ListOfMonumetnTypologicalAccessory>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictMonumentTypologicalTypeId)
                    .HasName("IX_ListOfMonumetnTypologicalAccessory_DictMonumentTypologicalT~");

                entity.HasIndex(e => e.ListOfMonumentsId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfMonumetnTypologicalAccessory)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_ListOfMonumetnTypologicalAccessory_AspNetUsers_ApplicationU~");

                entity.HasOne(d => d.DictMonumentTypologicalType)
                    .WithMany(p => p.ListOfMonumetnTypologicalAccessory)
                    .HasForeignKey(d => d.DictMonumentTypologicalTypeId)
                    .HasConstraintName("FK_ListOfMonumetnTypologicalAccessory_DictMonumentTypologicalT~");

                entity.HasOne(d => d.ListOfMonuments)
                    .WithMany(p => p.ListOfMonumetnTypologicalAccessory)
                    .HasForeignKey(d => d.ListOfMonumentsId)
                    .HasConstraintName("FK_ListOfMonumetnTypologicalAccessory_ListOfMonuments_ListOfMo~");
            });

            modelBuilder.Entity<ListOfRents>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictRentObjectTypeId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfRents)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictRentObjectType)
                    .WithMany(p => p.ListOfRents)
                    .HasForeignKey(d => d.DictRentObjectTypeId);
            });

            modelBuilder.Entity<ListOfRentsHistory>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.ListOfRentsId);

                entity.Property(e => e.Cost).HasColumnType("numeric");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfRentsHistory)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.ListOfRents)
                    .WithMany(p => p.ListOfRentsHistory)
                    .HasForeignKey(d => d.ListOfRentsId);
            });

            modelBuilder.Entity<ListOfStateAwards>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictAwardsPositionId);

                entity.HasIndex(e => e.DictAwardsReasonId);

                entity.HasIndex(e => e.DictStateAwardsTypeId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfStateAwards)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictAwardsPosition)
                    .WithMany(p => p.ListOfStateAwards)
                    .HasForeignKey(d => d.DictAwardsPositionId);

                entity.HasOne(d => d.DictAwardsReason)
                    .WithMany(p => p.ListOfStateAwards)
                    .HasForeignKey(d => d.DictAwardsReasonId);

                entity.HasOne(d => d.DictStateAwardsType)
                    .WithMany(p => p.ListOfStateAwards)
                    .HasForeignKey(d => d.DictStateAwardsTypeId);
            });

            modelBuilder.Entity<ListOfTeleRadio>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictAgencyPermId);

                entity.HasIndex(e => e.ListOfMediaId);

                entity.Property(e => e.PermElimGasdate).HasColumnName("PermElimGASDate");

                entity.Property(e => e.PermGasdate).HasColumnName("PermGASDate");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfTeleRadio)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictAgencyPerm)
                    .WithMany(p => p.ListOfTeleRadio)
                    .HasForeignKey(d => d.DictAgencyPermId);

                entity.HasOne(d => d.ListOfMedia)
                    .WithMany(p => p.ListOfTeleRadio)
                    .HasForeignKey(d => d.ListOfMediaId);
            });

            modelBuilder.Entity<ListOfTheatrical>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictFinSourceId);

                entity.HasIndex(e => e.DictLegalFormId);

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfTheatrical)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictFinSource)
                    .WithMany(p => p.ListOfTheatrical)
                    .HasForeignKey(d => d.DictFinSourceId);

                entity.HasOne(d => d.DictLegalForm)
                    .WithMany(p => p.ListOfTheatrical)
                    .HasForeignKey(d => d.DictLegalFormId);
            });

            modelBuilder.Entity<ListOfTheatricalHistory>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictFinSourceId);

                entity.HasIndex(e => e.DictLegalFormId);

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfTheatricalHistory)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictFinSource)
                    .WithMany(p => p.ListOfTheatricalHistory)
                    .HasForeignKey(d => d.DictFinSourceId);

                entity.HasOne(d => d.DictLegalForm)
                    .WithMany(p => p.ListOfTheatricalHistory)
                    .HasForeignKey(d => d.DictLegalFormId);
            });

            modelBuilder.Entity<ListOfTourism>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictDistrictId);

                entity.HasIndex(e => e.DictFinSourceId);

                entity.HasIndex(e => e.DictLegalFormId);

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfTourism)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictDistrict)
                    .WithMany(p => p.ListOfTourism)
                    .HasForeignKey(d => d.DictDistrictId);

                entity.HasOne(d => d.DictFinSource)
                    .WithMany(p => p.ListOfTourism)
                    .HasForeignKey(d => d.DictFinSourceId);

                entity.HasOne(d => d.DictLegalForm)
                    .WithMany(p => p.ListOfTourism)
                    .HasForeignKey(d => d.DictLegalFormId);
            });

            modelBuilder.Entity<ListOfTourismHistory>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictDistrictId);

                entity.HasIndex(e => e.DictFinSourceId);

                entity.HasIndex(e => e.DictLegalFormId);

                entity.HasIndex(e => e.ListOfTourismId);

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfTourismHistory)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictDistrict)
                    .WithMany(p => p.ListOfTourismHistory)
                    .HasForeignKey(d => d.DictDistrictId);

                entity.HasOne(d => d.DictFinSource)
                    .WithMany(p => p.ListOfTourismHistory)
                    .HasForeignKey(d => d.DictFinSourceId);

                entity.HasOne(d => d.DictLegalForm)
                    .WithMany(p => p.ListOfTourismHistory)
                    .HasForeignKey(d => d.DictLegalFormId);

                entity.HasOne(d => d.ListOfTourism)
                    .WithMany(p => p.ListOfTourismHistory)
                    .HasForeignKey(d => d.ListOfTourismId);
            });

            modelBuilder.Entity<ListOfTourismIndicator>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.Property(e => e.Gdp).HasColumnName("GDP");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfTourismIndicator)
                    .HasForeignKey(d => d.ApplicationUserId);
            });

            modelBuilder.Entity<ListOfTourismServices>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.DictStatusId);

                entity.HasIndex(e => e.DictTourismServicesId);

                entity.HasIndex(e => e.ListOfTourismId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ListOfTourismServices)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.DictStatus)
                    .WithMany(p => p.ListOfTourismServices)
                    .HasForeignKey(d => d.DictStatusId);

                entity.HasOne(d => d.DictTourismServices)
                    .WithMany(p => p.ListOfTourismServices)
                    .HasForeignKey(d => d.DictTourismServicesId)
                    .HasConstraintName("FK_ListOfTourismServices_DictTourismServices_DictTourismServic~");

                entity.HasOne(d => d.ListOfTourism)
                    .WithMany(p => p.ListOfTourismServices)
                    .HasForeignKey(d => d.ListOfTourismId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }


    /*
     * public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Dictionary
        public DbSet<Departments> Departments { get; set; }
        public DbSet<DictRegion> DictRegion { get; set; }
        public DbSet<DictDistrict> DictDistrict { get; set; }
        public DbSet<DictLegalForm> DictLegalForm { get; set; }
        public DbSet<DictFinSource> DictFinSource { get; set; }
        public DbSet<DictMediaType> DictMediaType { get; set; }
        public DbSet<DictMediaDistribTerritory> DictMediaDistribTerritory { get; set; }
        public DbSet<DictMediaLangType> DictMediaLangType { get; set; }
        public DbSet<DictMediaFreqRelease> DictMediaFreqRelease { get; set; }
        public DbSet<DictAgencyPerm> DictAgencyPerm { get; set; }
        public DbSet<DictControlType> DictControlType { get; set; }
        public DbSet<DictMediaControlResult> DictMediaControlResult { get; set; }
        public DbSet<DictMediaSuitPerm> DictMediaSuitPerm { get; set; }
        public DbSet<DictStatus> DictStatus { get; set; }

        #endregion

        #region Media
        public DbSet<ListOfMedia> ListOfMedia { get; set; }
        public DbSet<ListOfControlMedia> ListOfControlMedia { get; set; }
        public DbSet<ListOfTeleRadio> ListOfTeleRadio { get; set; }
        public DbSet<ListOfMediaHistory> ListOfMediaHistory { get; set; }

        #endregion

        #region TZY
        public DbSet<ListOfTheatrical> ListOfTheatrical { get; set; }
        public DbSet<ListOfCouncilTheatrical> ListOfCouncilTheatrical { get; set; }
        public DbSet<ListOfEventsTheatrical> ListOfEventsTheatrical { get; set; }
        public DbSet<DictTheatricalHall> DictTheatricalHall { get; set; }
        public DbSet<ListOfTheatricalHistory> ListOfTheatricalHistory { get; set; }


        #endregion

        #region EduInst
        public DbSet<ListOfEduInstituts> ListOfEduInstituts { get; set; }
        public DbSet<DictEduInstType> DictEduInstType { get; set; }

        #endregion

        #region Tourizm
        public DbSet<ListOfTourism> ListOfTourism { get; set; }
        public DbSet<ListOfTourismIndicator> ListOfTourismIndicator { get; set; }
        public DbSet<ListOfTourismHistory> ListOfTourismHistory { get; set; }
        public DbSet<ListOfTourismServices> ListOfTourismServices { get; set; }
        public DbSet<DictTourismServices> DictTourismServices { get; set; }

        #endregion

        #region Cinematography
        public DbSet<ListOfCinematography> ListOfCinematography { get; set; }
        public DbSet<ListOfCinematographyHistory> ListOfCinematographyHistory { get; set; }
        public DbSet<ListOfCinematographyServices> ListOfCinematographyServices { get; set; }
        public DbSet<DictCinematographyServices> DictCinematographyServices { get; set; }
        public DbSet<ListOfCinematographyDocuments> ListOfCinematographyDocuments { get; set; }


        public DbSet<DictCountry> DictCountry { get; set; }
        public DbSet<ListOfCinematographyCertificates> ListOfCinematographyCertificates { get; set; }
        public DbSet<DictCinemaAgeRestrictions> DictCinemaAgeRestrictions { get; set; }
        public DbSet<DictCinemaRegiser> DictCinemaRegiser { get; set; }
        public DbSet<DictCinemaDuration> DictCinemaDuration { get; set; }

        #endregion

        #region Monumetns
        public DbSet<ListOfMonuments> ListOfMonuments { get; set; }
        public DbSet<ListOfMonumentsProtObjects> ListOfMonumentsProtObjects { get; set; }
        public DbSet<DictMonumemtSignOfLoss> DictMonumemtSignOfLoss { get; set; }
        public DbSet<DictMonumentType> DictMonumentType { get; set; }
        public DbSet<ListOfMonumetnTypologicalAccessory> ListOfMonumetnTypologicalAccessory { get; set; }
        public DbSet<DictMonumentTypologicalType> DictMonumentTypologicalType { get; set; }
        #endregion

        #region Library
        public DbSet<ListOfTourizmIndicators> ListOfLibraryIndicators { get; set; }
        #endregion


        #region CultAndArts

        public DbSet<ListOfCultAndArt> ListOfCultAndArt { get; set; }
        public DbSet<DictCultAndArtType> DictCultAndArtType { get; set; }
        #endregion



        #region StateAwards

        public DbSet<ListOfStateAwards> ListOfStateAwards { get; set; }
        public DbSet<DictStateAwardsType> DictStateAwardsType { get; set; }
        public DbSet<DictAwardsPosition> DictAwardsPosition { get; set; }
        public DbSet<DictAwardsReason> DictAwardsReason { get; set; }

        #endregion

        #region Rent

        public DbSet<ListOfRentsHistory> ListOfRentsHistory { get; set; }
        public DbSet<ListOfRents> ListOfRents { get; set; }
        public DbSet<DictRentObjectType> DictRentObjectType { get; set; }
        public DbSet<DictUnitOfMeasure> DictUnitOfMeasure { get; set; }

        #endregion

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Seed();
        //}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        //Для postgresql
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseNpgsql("Host=192.168.145.130;Port=5432;Database=AisMKIT;Username=postgres;Password=admin");
            //  optionsBuilder.UseNpgsql("Host=212.112.106.181;Port=5432;Database=aismkitdb;Username=postgres;Password=dbPwdAdmin");
            //  optionsBuilder.UseNpgsql("Host=192.168.161.130;Port=5432;Database=aismkitdb;Username=postgres;Password=dbPwdAdmin");
            // optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5432;Database=aismkitdb;Username=postgres;Password=dbPwdAdmin");
            optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5432;Database=aismkitdb;Username=postgres;Password=admin");

        }
        //Для postgresql
        public DbSet<DictTypeOfKmm> DictTypeOfKMM { get; set; }
        //Для postgresql
        public DbSet<DictLoc> DictLoc { get; set; }
        //Для postgresql
        public DbSet<DictInitiatorOfProj> DictInitiatorOfProj { get; set; }
        //Для postgresql
        public DbSet<ListOfCultEvents> ListOfCultEvents { get; set; }
        //Для postgresql
        public DbSet<ListOfEvents> ListOfEvents { get; set; }
        //Для postgresql


    }
     */
}
