using System;

namespace DataObjects
{
    public class AdminListDTO : SearchBase
    {              
        public string LocationMap { get; set; }

        public double AreaHa { get; set; }

        public string AccessCat { get; set; }

        public string EstateCat { get; set; }

        public string NewEstateCat { get; set; }

        public int PlanFrom { get; set; }

        public int PlanTo { get; set; }

        public string ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public bool UnderConsultation { get; set; }

        public DateTime? ConsultationDeadline { get; set; }

        public int? RiskID { get; set; }

    }
}








