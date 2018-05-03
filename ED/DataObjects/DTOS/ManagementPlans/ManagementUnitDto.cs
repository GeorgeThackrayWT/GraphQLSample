using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects
{
    public class ManagementUnitDto : BaseDto, IRecord
    {
         
        public int NavisionId { get; set; }

     
        public int WoodlandOfficerId { get; set; }

      
        public int? PreviousOfficerId { get; set; }

     
        public int? DeputyId { get; set; }


        public string Name { get; set; }
        public string LocalName { get; set; }
        public string LocalNameDesc { get; set; }

   
        public int ApplicationId { get; set; }

      
        public int? DepartmentId { get; set; }

   
        public int SiteCategoryId { get; set; }

    
        public int? AdministrationAreaId { get; set; }

        public string AccessCategory { get; set; }
        public string EstateCategory { get; set; }
        public string NewEstateCategory { get; set; }
        public string InterimCategory { get; set; }
        public string Remarks { get; set; }
        public string AdditionalInformation { get; set; }
        public bool VATRecoverable { get; set; }
        public bool ExcludeFromAccountsReporting { get; set; }

       
        public int? RiskAssessmentId { get; set; }

    
        public int? ManagementPlanId { get; set; }

      
        public int? RegionId { get; set; }

     
        public int? ParentManagementUnitId { get; set; }

      
        public int? PortfolioCategoryId { get; set; }

        public int? InterimPortfolioCategoryId { get; set; }

        public bool? ForecastApproved { get; set; }
        public string SummaryDescription { get; set; }
        public string PublishedSummaryDescription { get; set; }
        public string LongTermIntentions { get; set; }
        public string MicrositeURL { get; set; }
        public string Aspect { get; set; }
        public double MinimumAltitude { get; set; }
        public double MaximumAltitude { get; set; }
        public int? WebsiteVisits { get; set; }
        public string GridReference { get; set; }
        public string MainAccessGridReference { get; set; }
        public string PublicAccessDescription { get; set; }
        public string ManagementAccessDescription { get; set; }
        public string DirectionsToMainEntrance { get; set; }
        public string BoundariesDescription { get; set; }
        public string HarvestingComments { get; set; }
        public string DeerCullPlan { get; set; }
        public string PostCode { get; set; }
        public string SpecialSiteFeatures { get; set; }
        public string SuitableForFilming { get; set; }
        public string AntisocialIssues { get; set; }
        public bool? NonStandardKey { get; set; }
        public bool IsPAWS { get; set; }
        public bool IsPotSite { get; set; }
        public bool AllowPOSO { get; set; }
        public bool WCBudget { get; set; }
        public string AdministrationArea { get; set; }
        public bool Disposed { get; set; }     
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }   
        public bool IsMainClumpedSite { get; set; }    
        public int? ClumpedManagementUnitId { get; set; }


 

    }
}