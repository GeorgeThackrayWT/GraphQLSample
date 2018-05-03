using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class RadGridSelectionDto
    {
        public List<object> AddedRecords { get; set; }

        public List<object> DeletedRecords { get; set; }

        public object SelectedRecord { get; set; }
        
    }
}
