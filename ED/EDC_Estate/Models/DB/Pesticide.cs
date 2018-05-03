using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Pesticide
    {
        public Pesticide()
        {
            PesticideEntry = new HashSet<PesticideEntry>();
        }

        public int Id { get; set; }
        public string ContractorName { get; set; }
        public string ContractorCode { get; set; }
        public int ManagementUnitId { get; set; }
        public int? AcquisitionUnitId { get; set; }
        public int? ExpenditureId { get; set; }
        public string OldPonumber { get; set; }
        public string SurplusDisposed { get; set; }
        public string Comments { get; set; }
        public int? SiteClassificationId { get; set; }
        public int? ReasonForUseId { get; set; }
        public int? TargetSpeciesId { get; set; }
        public int? ProductId { get; set; }
        public string ProductDescr { get; set; }
        public double? NetAreaTreatedHa { get; set; }
        public double ConcentrateQuantity { get; set; }
        public double ApplicationRate { get; set; }
        public int? ApplicationUnitId { get; set; }
        public string LocationInSite { get; set; }
        public int? ActiveIngredientId { get; set; }
        public string OtherIngredient { get; set; }
        public int? ApplicationTypeId { get; set; }
        public int? ApplicationMethodId { get; set; }
        public string WeatherConditions { get; set; }
        public bool WholeSite { get; set; }
        public bool Archived { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual ICollection<PesticideEntry> PesticideEntry { get; set; }
        public virtual AcquisitionUnit AcquisitionUnit { get; set; }
        public virtual ActiveIngredient ActiveIngredient { get; set; }
        public virtual ApplicationMethod ApplicationMethod { get; set; }
        public virtual ApplicationType ApplicationType { get; set; }
        public virtual ApplicationUnit ApplicationUnit { get; set; }
        public virtual Expenditure Expenditure { get; set; }
        public virtual User Lmu { get; set; }
        public virtual ManagementUnit ManagementUnit { get; set; }
        public virtual PesticideProduct Product { get; set; }
        public virtual ReasonForUse ReasonForUse { get; set; }
        public virtual SiteClassification SiteClassification { get; set; }
        public virtual TargetSpecies TargetSpecies { get; set; }
    }
}
