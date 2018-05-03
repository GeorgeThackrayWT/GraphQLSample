using System;
using System.Collections.Generic;
using System.Text;

namespace EDC_Estate.Models.DB
{
    public partial class Menu
    {
        public int Id { get; set; }
        public int ParentMenuId { get; set; }
        public string Caption { get; set; }
        public string Destination { get; set; }
    }
}
