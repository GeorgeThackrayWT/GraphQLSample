
namespace DataObjects
{
    public class ObjectiveKFListDTO : SearchBase
    {      
        public string KF1 { get; set; }
        public string KF2 { get; set; }
        public string KF3 { get; set; }
        public string KF4{ get; set; }
        public string KF5 { get; set; }
        public bool MoreKF { get; set; }
        public bool Aim1Creation { get; set; }
        public bool Aim2Biodiversity { get; set; }
        public bool Aim3People { get; set; }
        public string EstateCategory { get; set; }        
    }
    
}