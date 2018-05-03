using MvvmHelpers;

namespace DataObjects
{
    
    public class WorkProgrammeListDTO : SearchBase
    {      
        public double Year5Expenditure { get; set; }

        public double Year5Income { get; set; }

        public double Year5Net { get; set; }

        public double YearXExpenditure { get; set; }

        public double YearXIncome { get; set; }

        public double YearXNet { get; set; }


        public bool EMC { get; set; }

        public bool PRS { get; set; }

        public bool FundingOpportunity { get; set; }

        public bool Project { get; set; }
        public bool WSP { get; set; }

        public bool PE { get; set; }



    }
    
}