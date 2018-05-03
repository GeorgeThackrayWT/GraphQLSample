using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Farming
    {
        public Farming()
        {
            AcquisitionUnit = new HashSet<AcquisitionUnit>();
        }

        public int Id { get; set; }
        public string Sbibrncrn { get; set; }
        public string Cphno { get; set; }
        public int? VendorNo { get; set; }
        public bool Sfps { get; set; }
        public bool Els { get; set; }
        public bool Hls { get; set; }
        public bool Registered { get; set; }
        public bool Lfa { get; set; }
        public bool Srdp { get; set; }
        public bool Arp { get; set; }
        public bool Css { get; set; }
        public bool GlastirAwe { get; set; }
        public bool GlastirTe { get; set; }
        public DateTime? Elsdate { get; set; }
        public DateTime? Hlsdate { get; set; }
        public DateTime? Cssdate { get; set; }
        public DateTime? GlastirAwedate { get; set; }
        public DateTime? GlastirTedate { get; set; }
        public string ElsrefNo { get; set; }
        public string HlsrefNo { get; set; }
        public string CssrefNo { get; set; }
        public string GlastirAwerefNo { get; set; }
        public string GlastirTerefNo { get; set; }
        public bool WtfarmingLtd { get; set; }
        public bool Fwps { get; set; }
        public bool Ilp { get; set; }
        public bool GlastirWcp { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual ICollection<AcquisitionUnit> AcquisitionUnit { get; set; }
        public virtual User Lmu { get; set; }
    }
}
