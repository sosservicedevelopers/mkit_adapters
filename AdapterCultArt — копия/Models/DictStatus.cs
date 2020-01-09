using System;
using System.Collections.Generic;

namespace AdapterLibrary
{
    public partial class DictStatus
    {
        public DictStatus()
        {
            DictAgencyPerm = new HashSet<DictAgencyPerm>();
            DictAwardsPosition = new HashSet<DictAwardsPosition>();
            DictAwardsReason = new HashSet<DictAwardsReason>();
            DictCinematographyServices = new HashSet<DictCinematographyServices>();
            DictControlType = new HashSet<DictControlType>();
            DictCultAndArtType = new HashSet<DictCultAndArtType>();
            DictFinSource = new HashSet<DictFinSource>();
            DictLegalForm = new HashSet<DictLegalForm>();
            DictMediaControlResult = new HashSet<DictMediaControlResult>();
            DictMediaFreqRelease = new HashSet<DictMediaFreqRelease>();
            DictMediaLangType = new HashSet<DictMediaLangType>();
            DictMediaSuitPerm = new HashSet<DictMediaSuitPerm>();
            DictMediaType = new HashSet<DictMediaType>();
            DictMonumemtSignOfLoss = new HashSet<DictMonumemtSignOfLoss>();
            DictMonumentType = new HashSet<DictMonumentType>();
            DictMonumentTypologicalType = new HashSet<DictMonumentTypologicalType>();
            DictRentObjectType = new HashSet<DictRentObjectType>();
            DictStateAwardsType = new HashSet<DictStateAwardsType>();
            DictTheatricalHall = new HashSet<DictTheatricalHall>();
            DictTourismServices = new HashSet<DictTourismServices>();
            DictUnitOfMeasure = new HashSet<DictUnitOfMeasure>();
            ListOfCinematographyServices = new HashSet<ListOfCinematographyServices>();
            ListOfTourismServices = new HashSet<ListOfTourismServices>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DictAgencyPerm> DictAgencyPerm { get; set; }
        public virtual ICollection<DictAwardsPosition> DictAwardsPosition { get; set; }
        public virtual ICollection<DictAwardsReason> DictAwardsReason { get; set; }
        public virtual ICollection<DictCinematographyServices> DictCinematographyServices { get; set; }
        public virtual ICollection<DictControlType> DictControlType { get; set; }
        public virtual ICollection<DictCultAndArtType> DictCultAndArtType { get; set; }
        public virtual ICollection<DictFinSource> DictFinSource { get; set; }
        public virtual ICollection<DictLegalForm> DictLegalForm { get; set; }
        public virtual ICollection<DictMediaControlResult> DictMediaControlResult { get; set; }
        public virtual ICollection<DictMediaFreqRelease> DictMediaFreqRelease { get; set; }
        public virtual ICollection<DictMediaLangType> DictMediaLangType { get; set; }
        public virtual ICollection<DictMediaSuitPerm> DictMediaSuitPerm { get; set; }
        public virtual ICollection<DictMediaType> DictMediaType { get; set; }
        public virtual ICollection<DictMonumemtSignOfLoss> DictMonumemtSignOfLoss { get; set; }
        public virtual ICollection<DictMonumentType> DictMonumentType { get; set; }
        public virtual ICollection<DictMonumentTypologicalType> DictMonumentTypologicalType { get; set; }
        public virtual ICollection<DictRentObjectType> DictRentObjectType { get; set; }
        public virtual ICollection<DictStateAwardsType> DictStateAwardsType { get; set; }
        public virtual ICollection<DictTheatricalHall> DictTheatricalHall { get; set; }
        public virtual ICollection<DictTourismServices> DictTourismServices { get; set; }
        public virtual ICollection<DictUnitOfMeasure> DictUnitOfMeasure { get; set; }
        public virtual ICollection<ListOfCinematographyServices> ListOfCinematographyServices { get; set; }
        public virtual ICollection<ListOfTourismServices> ListOfTourismServices { get; set; }
    }
}
