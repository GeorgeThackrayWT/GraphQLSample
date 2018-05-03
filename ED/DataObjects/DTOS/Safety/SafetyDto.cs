using System;

namespace DataObjects.DTOS.SafetyObjects
{
    public class SafetyDto : SearchBase
    {
        public int ID { get; set; }

 

        public string FireRisk { get; set; }

        public string BiosecurityZone { get; set; }

        public int HazardCount { get; set; }

        public string MapUrl { get; set; }

        public DateTime? AuthorisedDate { get; set; }

        public string AuthorisedBy { get; set; }

        public DateTime? ReviewDate { get; set; }

        public bool Authorised { get; set; }
 
    }
}
