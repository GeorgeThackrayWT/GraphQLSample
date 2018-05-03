using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Expenditure
    {
        public Expenditure()
        {
        //    EnvironmentalAssessment = new HashSet<EnvironmentalAssessment>();
            Pesticide = new HashSet<Pesticide>();
        }

        public int Id { get; set; }
        public string Kind { get; set; }
        public Guid? GroupGuid { get; set; }
        public int ManagementUnitId { get; set; }
        public bool Project { get; set; }
        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public int AimId { get; set; }
        public string Notes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public double Budget { get; set; }
        public double? Ordered { get; set; }
        public double? Forecast { get; set; }
        public double LastMonthForecast { get; set; }
        public double? Actual { get; set; }
        public double? TenderPrice { get; set; }
        public bool? Grn { get; set; }
        public string CptNo { get; set; }
        public bool Emc { get; set; }
        public bool PesticideRecord { get; set; }
        public string Emcspec { get; set; }
        public bool Wsp { get; set; }
        public bool Dtp { get; set; }
        public bool Pe { get; set; }
        public bool Pipeline { get; set; }
        public int FundingStatusId { get; set; }
        public string Pono { get; set; }
        public DateTime? Podate { get; set; }
        public int? TenderId { get; set; }
        public int? TaxCodeId { get; set; }
        public int AccountingYear { get; set; }
        public bool Rpi { get; set; }
        public bool Confidential { get; set; }
        public bool OpsGrantAided { get; set; }
        public bool Completed { get; set; }
        public bool Chalara { get; set; }
        public bool VolunteerWork { get; set; }
        public bool Cancelled { get; set; }
        public bool NoSync { get; set; }
        public bool WoodProduction { get; set; }
        public int? NumberOfTrees { get; set; }
        public int? NumberOfTreesOrigin { get; set; }
        public double? CostPerTree { get; set; }
        public int? TreeSupplierId { get; set; }
        public int? WcexpenditureId { get; set; }
        public int? ProvenanceZoneId { get; set; }
        public int? PlantTypeId { get; set; }
        public int? GrownMethodId { get; set; }
        public double? SizeCm { get; set; }
        public int? EcoSurveyTypeId { get; set; }
        public int? EcoSubjectOrSpeciesId { get; set; }
        public string EcoOtherDescription { get; set; }
        public string EcoAuthorOfOutput { get; set; }
        public bool EcoSurveyUploadedToDw { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Ulmdt { get; set; }
        public int? Ulmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

     //   public virtual ICollection<EnvironmentalAssessment> EnvironmentalAssessment { get; set; }
        public virtual ICollection<Pesticide> Pesticide { get; set; }
        public virtual Aim Aim { get; set; }
        public virtual EcologicalSubjectOrSpecies EcoSubjectOrSpecies { get; set; }
        public virtual EcologicalSurveyType EcoSurveyType { get; set; }
        public virtual FundingStatus FundingStatus { get; set; }
        public virtual ExpenditureGrownMethod GrownMethod { get; set; }
        public virtual User Lmu { get; set; }
        public virtual ManagementUnit ManagementUnit { get; set; }
        public virtual PlantType PlantType { get; set; }
        public virtual ExpenditureProduct Product { get; set; }
        public virtual ProvenanceZone ProvenanceZone { get; set; }
        public virtual TaxCode TaxCode { get; set; }
        public virtual Tender Tender { get; set; }
        public virtual Supplier TreeSupplier { get; set; }
        public virtual User Ulmu { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
