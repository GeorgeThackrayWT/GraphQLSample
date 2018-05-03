using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class PropertyFarmingDto : BaseDto, IRecord
    {
        // linked on ack unit to farming table


        public string SBIBRNCRN { get; set; }

        public string CPHNO { get; set; }

        public int VendorNo { get; set; }

        public bool SFPS { get; set; }

        public bool ELS { get; set; }

        public bool HLS { get; set; }

        public bool Registered { get; set; }

        public bool LFA { get; set; }

        public bool SRDP { get; set; }

        public bool ARP { get; set; }

        public bool CSS { get; set; }

        public bool GlastirAWE { get; set; }

        public bool GlastirTE { get; set; }

        public DateTime? ELSSRDPDate { get; set; }

        public string ELSSRDP_RefNo { get; set; }

        public DateTime? HLSSRDPDate { get; set; }

        public string HLSSRDP_RefNo { get; set; }

        public DateTime? CSSSRDPDate { get; set; }

        public string CSSSRDP_RefNo { get; set; }

        public DateTime? GlastirAWEDate { get; set; }

        public string GlastirAWE_RefNo { get; set; }

        public DateTime? GlastirTEDate { get; set; }

        public string GlastirTE_RefNo { get; set; }

        public bool WTFarmingLtd { get; set; }

        public bool FWPS { get; set; }

        public bool ILP { get; set; }

        public bool GlastirWCP { get; set; }

        public bool AgriculturalTenancies { get; set; }

        public bool Grazing { get; set; }

        public bool Fishing { get; set; }

        public bool Other { get; set; }
        public PropertyFarmingDto Clone()
        {
            return new PropertyFarmingDto()
            {
                SBIBRNCRN = this.SBIBRNCRN,
                CPHNO = this.CPHNO,
                VendorNo = this.VendorNo,
                SFPS = this.SFPS,
                ELS = this.ELS,
                HLS = this.HLS,
                Registered = this.Registered,
                LFA = this.LFA,
                SRDP = this.SRDP,
                ARP = this.ARP,
                CSS = this.CSS,
                GlastirAWE = this.GlastirAWE,
                GlastirTE = this.GlastirTE,
                ELSSRDPDate = this.ELSSRDPDate,
                ELSSRDP_RefNo = this.ELSSRDP_RefNo,
                HLSSRDPDate = this.HLSSRDPDate,
                HLSSRDP_RefNo = this.HLSSRDP_RefNo,
                CSSSRDPDate = this.CSSSRDPDate,
                CSSSRDP_RefNo = this.CSSSRDP_RefNo,
                GlastirAWEDate = this.GlastirAWEDate,
                GlastirAWE_RefNo = this.GlastirAWE_RefNo,
                GlastirTEDate = this.GlastirTEDate,
                GlastirTE_RefNo = this.GlastirTE_RefNo,
                WTFarmingLtd = this.WTFarmingLtd,
                FWPS = this.FWPS,
                ILP = this.ILP,
                GlastirWCP = this.GlastirWCP,
                AgriculturalTenancies = this.AgriculturalTenancies,
                Grazing = this.Grazing,
                Fishing = this.Fishing,
                Other = this.Other,
            };
        }//endofclonemethods
    }

    public class PropertyFarmingEdit : PropertyBase<PropertyFarmingEdit>, IDuplicate
    {

        private PropertyFarmingDto _dto;


        public PropertyFarmingEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        // linked on ack unit to farming table


        public Property<string> SBIBRNCRN { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> CPHNO { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> VendorNo { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<bool> SFPS { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> ELS { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> HLS { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Registered { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> LFA { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> SRDP { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> ARP { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> CSS { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> GlastirAWE { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> GlastirTE { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<DateTime?> ELSSRDPDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> ELSSRDP_RefNo { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> HLSSRDPDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> HLSSRDP_RefNo { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> CSSSRDPDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> CSSSRDP_RefNo { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> GlastirAWEDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> GlastirAWE_RefNo { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> GlastirTEDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> GlastirTE_RefNo { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> WTFarmingLtd { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> FWPS { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> ILP { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> GlastirWCP { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> AgriculturalTenancies { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Grazing { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Fishing { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Other { get; set; } = new Property<bool>() { Value = false, Original = false };


        public int RecordId => Id.Value;


        public PropertyFarmingDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.SBIBRNCRN = SBIBRNCRN.Value;
            returnVal.CPHNO = CPHNO.Value;
            returnVal.VendorNo = VendorNo.Value;
            returnVal.SFPS = SFPS.Value;
            returnVal.ELS = ELS.Value;
            returnVal.HLS = HLS.Value;
            returnVal.Registered = Registered.Value;
            returnVal.LFA = LFA.Value;
            returnVal.SRDP = SRDP.Value;
            returnVal.ARP = ARP.Value;
            returnVal.CSS = CSS.Value;
            returnVal.GlastirAWE = GlastirAWE.Value;
            returnVal.GlastirTE = GlastirTE.Value;
            returnVal.ELSSRDPDate = ELSSRDPDate.Value;
            returnVal.ELSSRDP_RefNo = ELSSRDP_RefNo.Value;
            returnVal.HLSSRDPDate = HLSSRDPDate.Value;
            returnVal.HLSSRDP_RefNo = HLSSRDP_RefNo.Value;
            returnVal.CSSSRDPDate = CSSSRDPDate.Value;
            returnVal.CSSSRDP_RefNo = CSSSRDP_RefNo.Value;
            returnVal.GlastirAWEDate = GlastirAWEDate.Value;
            returnVal.GlastirAWE_RefNo = GlastirAWE_RefNo.Value;
            returnVal.GlastirTEDate = GlastirTEDate.Value;
            returnVal.GlastirTE_RefNo = GlastirTE_RefNo.Value;
            returnVal.WTFarmingLtd = WTFarmingLtd.Value;
            returnVal.FWPS = FWPS.Value;
            returnVal.ILP = ILP.Value;
            returnVal.GlastirWCP = GlastirWCP.Value;
            returnVal.AgriculturalTenancies = AgriculturalTenancies.Value;
            returnVal.Grazing = Grazing.Value;
            returnVal.Fishing = Fishing.Value;
            returnVal.Other = Other.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PropertyFarmingEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PropertyFarmingDto test)
        {
            this.SBIBRNCRN = Property<string>.Make(test.SBIBRNCRN,SBIBRNCRN);
            this.CPHNO = Property<string>.Make(test.CPHNO,CPHNO);
            this.VendorNo = Property<int>.Make(test.VendorNo,VendorNo);
            this.SFPS = Property<bool>.Make(test.SFPS,SFPS);
            this.ELS = Property<bool>.Make(test.ELS,ELS);
            this.HLS = Property<bool>.Make(test.HLS,HLS);
            this.Registered = Property<bool>.Make(test.Registered,Registered);
            this.LFA = Property<bool>.Make(test.LFA,LFA);
            this.SRDP = Property<bool>.Make(test.SRDP,SRDP);
            this.ARP = Property<bool>.Make(test.ARP,ARP);
            this.CSS = Property<bool>.Make(test.CSS,CSS);
            this.GlastirAWE = Property<bool>.Make(test.GlastirAWE,GlastirAWE);
            this.GlastirTE = Property<bool>.Make(test.GlastirTE,GlastirTE);
            this.ELSSRDPDate = Property<DateTime?>.Make(test.ELSSRDPDate,ELSSRDPDate);
            this.ELSSRDP_RefNo = Property<string>.Make(test.ELSSRDP_RefNo, ELSSRDP_RefNo);
            this.HLSSRDPDate = Property<DateTime?>.Make(test.HLSSRDPDate,HLSSRDPDate);
            this.HLSSRDP_RefNo = Property<string>.Make(test.HLSSRDP_RefNo, HLSSRDP_RefNo);
            this.CSSSRDPDate = Property<DateTime?>.Make(test.CSSSRDPDate,CSSSRDPDate);
            this.CSSSRDP_RefNo = Property<string>.Make(test.CSSSRDP_RefNo, CSSSRDP_RefNo);
            this.GlastirAWEDate = Property<DateTime?>.Make(test.GlastirAWEDate,GlastirAWEDate);
            this.GlastirAWE_RefNo = Property<string>.Make(test.GlastirAWE_RefNo, GlastirAWE_RefNo);
            this.GlastirTEDate = Property<DateTime?>.Make(test.GlastirTEDate,GlastirTEDate);
            this.GlastirTE_RefNo = Property<string>.Make(test.GlastirTE_RefNo, GlastirTE_RefNo);
            this.WTFarmingLtd = Property<bool>.Make(test.WTFarmingLtd,WTFarmingLtd);
            this.FWPS = Property<bool>.Make(test.FWPS,FWPS);
            this.ILP = Property<bool>.Make(test.ILP,ILP);
            this.GlastirWCP = Property<bool>.Make(test.GlastirWCP,GlastirWCP);
            this.AgriculturalTenancies = Property<bool>.Make(test.AgriculturalTenancies,AgriculturalTenancies);
            this.Grazing = Property<bool>.Make(test.Grazing,Grazing);
            this.Fishing = Property<bool>.Make(test.Fishing,Fishing);
            this.Other = Property<bool>.Make(test.Other,Other);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            SBIBRNCRN.Revert();
            CPHNO.Revert();
            VendorNo.Revert();
            SFPS.Revert();
            ELS.Revert();
            HLS.Revert();
            Registered.Revert();
            LFA.Revert();
            SRDP.Revert();
            ARP.Revert();
            CSS.Revert();
            GlastirAWE.Revert();
            GlastirTE.Revert();
            ELSSRDPDate.Revert();
            ELSSRDP_RefNo.Revert();
            HLSSRDPDate.Revert();
            HLSSRDP_RefNo.Revert();
            CSSSRDPDate.Revert();
            CSSSRDP_RefNo.Revert();
            GlastirAWEDate.Revert();
            GlastirAWE_RefNo.Revert();
            GlastirTEDate.Revert();
            GlastirTE_RefNo.Revert();
            WTFarmingLtd.Revert();
            FWPS.Revert();
            ILP.Revert();
            GlastirWCP.Revert();
            AgriculturalTenancies.Revert();
            Grazing.Revert();
            Fishing.Revert();
            Other.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<PropertyFarmingEdit> MakeCollection(List<PropertyFarmingDto> records)
        {

            var newData = new ExtRangeCollection<PropertyFarmingEdit>();

            foreach (var rec in records)
            {
                var e = new PropertyFarmingEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class PropertyFarmingEditList : ListObj<PropertyFarmingDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private PropertyFarmingDto _dto;


        public PropertyFarmingEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        // linked on ack unit to farming table


        public string SBIBRNCRN { get => _current.SBIBRNCRN; set { _current.SBIBRNCRN = value; OnPropertyChanged(); } }

        public string CPHNO { get => _current.CPHNO; set { _current.CPHNO = value; OnPropertyChanged(); } }

        public int VendorNo { get => _current.VendorNo; set { _current.VendorNo = value; OnPropertyChanged(); } }

        public bool SFPS { get => _current.SFPS; set { _current.SFPS = value; OnPropertyChanged(); } }

        public bool ELS { get => _current.ELS; set { _current.ELS = value; OnPropertyChanged(); } }

        public bool HLS { get => _current.HLS; set { _current.HLS = value; OnPropertyChanged(); } }

        public bool Registered { get => _current.Registered; set { _current.Registered = value; OnPropertyChanged(); } }

        public bool LFA { get => _current.LFA; set { _current.LFA = value; OnPropertyChanged(); } }

        public bool SRDP { get => _current.SRDP; set { _current.SRDP = value; OnPropertyChanged(); } }

        public bool ARP { get => _current.ARP; set { _current.ARP = value; OnPropertyChanged(); } }

        public bool CSS { get => _current.CSS; set { _current.CSS = value; OnPropertyChanged(); } }

        public bool GlastirAWE { get => _current.GlastirAWE; set { _current.GlastirAWE = value; OnPropertyChanged(); } }

        public bool GlastirTE { get => _current.GlastirTE; set { _current.GlastirTE = value; OnPropertyChanged(); } }

        public DateTime? ELSSRDPDate { get => _current.ELSSRDPDate; set { _current.ELSSRDPDate = value; OnPropertyChanged(); } }

        public string ELSSRDP_RefNo { get => _current.ELSSRDP_RefNo; set { _current.ELSSRDP_RefNo = value; OnPropertyChanged(); } }

        public DateTime? HLSSRDPDate { get => _current.HLSSRDPDate; set { _current.HLSSRDPDate = value; OnPropertyChanged(); } }

        public string HLSSRDP_RefNo { get => _current.HLSSRDP_RefNo; set { _current.HLSSRDP_RefNo = value; OnPropertyChanged(); } }

        public DateTime? CSSSRDPDate { get => _current.CSSSRDPDate; set { _current.CSSSRDPDate = value; OnPropertyChanged(); } }

        public string CSSSRDP_RefNo { get => _current.CSSSRDP_RefNo; set { _current.CSSSRDP_RefNo = value; OnPropertyChanged(); } }

        public DateTime? GlastirAWEDate { get => _current.GlastirAWEDate; set { _current.GlastirAWEDate = value; OnPropertyChanged(); } }

        public string GlastirAWE_RefNo { get => _current.GlastirAWE_RefNo; set { _current.GlastirAWE_RefNo = value; OnPropertyChanged(); } }

        public DateTime? GlastirTEDate { get => _current.GlastirTEDate; set { _current.GlastirTEDate = value; OnPropertyChanged(); } }

        public string GlastirTE_RefNo { get => _current.GlastirTE_RefNo; set { _current.GlastirTE_RefNo = value; OnPropertyChanged(); } }

        public bool WTFarmingLtd { get => _current.WTFarmingLtd; set { _current.WTFarmingLtd = value; OnPropertyChanged(); } }

        public bool FWPS { get => _current.FWPS; set { _current.FWPS = value; OnPropertyChanged(); } }

        public bool ILP { get => _current.ILP; set { _current.ILP = value; OnPropertyChanged(); } }

        public bool GlastirWCP { get => _current.GlastirWCP; set { _current.GlastirWCP = value; OnPropertyChanged(); } }

        public bool AgriculturalTenancies { get => _current.AgriculturalTenancies; set { _current.AgriculturalTenancies = value; OnPropertyChanged(); } }

        public bool Grazing { get => _current.Grazing; set { _current.Grazing = value; OnPropertyChanged(); } }

        public bool Fishing { get => _current.Fishing; set { _current.Fishing = value; OnPropertyChanged(); } }

        public bool Other { get => _current.Other; set { _current.Other = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public PropertyFarmingDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.SBIBRNCRN = this.SBIBRNCRN;
            returnVal.CPHNO = this.CPHNO;
            returnVal.VendorNo = this.VendorNo;
            returnVal.SFPS = this.SFPS;
            returnVal.ELS = this.ELS;
            returnVal.HLS = this.HLS;
            returnVal.Registered = this.Registered;
            returnVal.LFA = this.LFA;
            returnVal.SRDP = this.SRDP;
            returnVal.ARP = this.ARP;
            returnVal.CSS = this.CSS;
            returnVal.GlastirAWE = this.GlastirAWE;
            returnVal.GlastirTE = this.GlastirTE;
            returnVal.ELSSRDPDate = this.ELSSRDPDate;
            returnVal.ELSSRDP_RefNo = this.ELSSRDP_RefNo;
            returnVal.HLSSRDPDate = this.HLSSRDPDate;
            returnVal.HLSSRDP_RefNo = this.HLSSRDP_RefNo;
            returnVal.CSSSRDPDate = this.CSSSRDPDate;
            returnVal.CSSSRDP_RefNo = this.CSSSRDP_RefNo;
            returnVal.GlastirAWEDate = this.GlastirAWEDate;
            returnVal.GlastirAWE_RefNo = this.GlastirAWE_RefNo;
            returnVal.GlastirTEDate = this.GlastirTEDate;
            returnVal.GlastirTE_RefNo = this.GlastirTE_RefNo;
            returnVal.WTFarmingLtd = this.WTFarmingLtd;
            returnVal.FWPS = this.FWPS;
            returnVal.ILP = this.ILP;
            returnVal.GlastirWCP = this.GlastirWCP;
            returnVal.AgriculturalTenancies = this.AgriculturalTenancies;
            returnVal.Grazing = this.Grazing;
            returnVal.Fishing = this.Fishing;
            returnVal.Other = this.Other;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PropertyFarmingEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PropertyFarmingDto test)
        {
            _original.SBIBRNCRN = test.SBIBRNCRN;
            _current.SBIBRNCRN = test.SBIBRNCRN;
            _original.CPHNO = test.CPHNO;
            _current.CPHNO = test.CPHNO;
            _original.VendorNo = test.VendorNo;
            _current.VendorNo = test.VendorNo;
            _original.SFPS = test.SFPS;
            _current.SFPS = test.SFPS;
            _original.ELS = test.ELS;
            _current.ELS = test.ELS;
            _original.HLS = test.HLS;
            _current.HLS = test.HLS;
            _original.Registered = test.Registered;
            _current.Registered = test.Registered;
            _original.LFA = test.LFA;
            _current.LFA = test.LFA;
            _original.SRDP = test.SRDP;
            _current.SRDP = test.SRDP;
            _original.ARP = test.ARP;
            _current.ARP = test.ARP;
            _original.CSS = test.CSS;
            _current.CSS = test.CSS;
            _original.GlastirAWE = test.GlastirAWE;
            _current.GlastirAWE = test.GlastirAWE;
            _original.GlastirTE = test.GlastirTE;
            _current.GlastirTE = test.GlastirTE;
            _original.ELSSRDPDate = test.ELSSRDPDate;
            _current.ELSSRDPDate = test.ELSSRDPDate;
            _original.ELSSRDP_RefNo = test.ELSSRDP_RefNo;
            _current.ELSSRDP_RefNo = test.ELSSRDP_RefNo;
            _original.HLSSRDPDate = test.HLSSRDPDate;
            _current.HLSSRDPDate = test.HLSSRDPDate;
            _original.HLSSRDP_RefNo = test.HLSSRDP_RefNo;
            _current.HLSSRDP_RefNo = test.HLSSRDP_RefNo;
            _original.CSSSRDPDate = test.CSSSRDPDate;
            _current.CSSSRDPDate = test.CSSSRDPDate;
            _original.CSSSRDP_RefNo = test.CSSSRDP_RefNo;
            _current.CSSSRDP_RefNo = test.CSSSRDP_RefNo;
            _original.GlastirAWEDate = test.GlastirAWEDate;
            _current.GlastirAWEDate = test.GlastirAWEDate;
            _original.GlastirAWE_RefNo = test.GlastirAWE_RefNo;
            _current.GlastirAWE_RefNo = test.GlastirAWE_RefNo;
            _original.GlastirTEDate = test.GlastirTEDate;
            _current.GlastirTEDate = test.GlastirTEDate;
            _original.GlastirTE_RefNo = test.GlastirTE_RefNo;
            _current.GlastirTE_RefNo = test.GlastirTE_RefNo;
            _original.WTFarmingLtd = test.WTFarmingLtd;
            _current.WTFarmingLtd = test.WTFarmingLtd;
            _original.FWPS = test.FWPS;
            _current.FWPS = test.FWPS;
            _original.ILP = test.ILP;
            _current.ILP = test.ILP;
            _original.GlastirWCP = test.GlastirWCP;
            _current.GlastirWCP = test.GlastirWCP;
            _original.AgriculturalTenancies = test.AgriculturalTenancies;
            _current.AgriculturalTenancies = test.AgriculturalTenancies;
            _original.Grazing = test.Grazing;
            _current.Grazing = test.Grazing;
            _original.Fishing = test.Fishing;
            _current.Fishing = test.Fishing;
            _original.Other = test.Other;
            _current.Other = test.Other;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<PropertyFarmingEditList> MakeCollection(List<PropertyFarmingDto> records)
        {

            var newData = new ExtRangeCollection<PropertyFarmingEditList>();

            foreach (var rec in records)
            {
                var e = new PropertyFarmingEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass



}