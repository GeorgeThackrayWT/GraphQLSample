namespace DataObjects.DTOS.AdministrationArea
{
    public class AdminWorkProgrammeDTO
    {
        public int ID { get; set; }

        public int LastPurchaseOrderNo { get; set; }

        public int LastSalesOrderNo { get; set; }

        public string OrdersDropPath { get; set; }

        public string PERESNO { get; set; }

        public string NEDRESNO { get; set; }

        public string AWRRESNO { get; set; }

        public string ChalaraWorkOrderCode { get; set; }

        public string VATGuideURL { get; set; }

        public int FirstExpenditureAccountCode { get; set; }

        public bool DisablePO { get; set; }

        public string DisablePOMessage { get; set; }

        public bool DisableSO { get; set; }

        public string DisableSOMessage { get; set; }


    }
}