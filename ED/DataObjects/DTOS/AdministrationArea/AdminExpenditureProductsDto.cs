using System.Collections.Generic;

namespace DataObjects.DTOS.AdministrationArea
{
    public class AdminExpenditureProductsDto
    {
        public int ID { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public int AimID { get; set; }

        public string AccountCode { get; set; }

        public string Account { get; set; }

        public string WTActivityCode { get; set; }

        public string WTActivity { get; set; }

        public int TaxCodeID { get; set; }

        public int EANeeded { get; set; }

        public bool Locked { get; set; }

        public bool Planted { get; set; }

        public int UnitTypeID { get; set; }

        public int ApplicationID { get; set; }

        public List<int> ProductSites { get; set; }


    }
}