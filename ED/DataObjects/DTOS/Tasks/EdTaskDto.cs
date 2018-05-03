using System;

namespace DataObjects
{
    public class EdTaskDto :SearchBase
    {
        public int TaskId { get; set; }
   
        public DateTime Deadline { get; set; }
      
        public string Notes { get; set; }
    
        public double Amount { get; set; }

        public string Category { get; set; }

    }
}
