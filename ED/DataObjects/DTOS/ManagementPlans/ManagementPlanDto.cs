using System;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans
{
    public class ManagementPlanDto : BaseDto, IRecord
    {
        public byte[] PDFFile { get; set; }
        public byte[] WoodBoardPDFFile { get; set; }
        public byte[] WoodBoardJPGFile { get; set; }
        public bool UnderConsultation { get; set; }
        public DateTime? ConsultationEndDate { get; set; }
        public DateTime? ReviewDeadline { get; set; }
        public bool UnderReview { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        public bool Approved { get; set; }
        public int? ApprovedByID { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? LastExported { get; set; }      

    }
}
