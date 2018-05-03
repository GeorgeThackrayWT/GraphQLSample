namespace SQLite.DataTypes
{
    public class WorkProgramCollation
    {

        public int ID { get; set; }

        public bool T { get; set; }

        public string Name { get; set; }

        public int ManagementUnitID { get; set; }
        public bool Project { get; set; }

        public double? Ordered_ClmdInvd { get; set; }

        public int WorkOrderID { get; set; }
        public int ProductID { get; set; }

        public System.DateTime EndDate { get; set; }

        public double Budget { get; set; }

        public double? Forecast { get; set; }

        public double? Actual { get; set; }

        public bool EMC { get; set; }
        public bool PesticideRecord { get; set; }

        public bool WSP { get; set; }

        public bool PE { get; set; }

        public int FundingStatusID { get; set; }

        public int? TaxCodeID { get; set; }

        public bool Completed { get; set; }

    }
}