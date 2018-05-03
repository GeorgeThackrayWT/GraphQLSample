using System;

namespace DataObjects
{
    public class GrantContractsListDTO : SearchBase
    {
    

        public int? WoodlandOfficerId { get; set; }

        public double TotalForecast { get; set; }

        public double TotalClaimed { get; set; }

        public double TotalActual { get; set; }

        public DateTime? LastChecked { get; set; }

        public DateTime? LastAuthorised { get; set; }

        public DateTime? LastAmended { get; set; }

    }
}