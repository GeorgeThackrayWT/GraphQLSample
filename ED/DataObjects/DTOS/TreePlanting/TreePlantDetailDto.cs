using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.TreePlanting
{
    public class TreePlantDetailDto : BaseDto, IRecord
    {
        public TreePlantTerrainDto TerrainID { get; set; }

        public TreePlantAccessDto AccessID { get; set; }

        public int AdultsCount { get; set; }

        public int ChildrenCount { get; set; }

        public double? AreaToPlant { get; set; }

        public double? AreaPlanted { get; set; }

        public double DensityHa { get; set; }

        public int TreesPlanted { get; set; }

        public int? TreesToPlant { get; set; }

        public int TreesAllocated { get; set; }

        public string Comments { get; set; }
        public TreePlantDetailDto Clone()
        {
            return new TreePlantDetailDto()
            {
                AdultsCount = this.AdultsCount,
                ChildrenCount = this.ChildrenCount,
                AreaToPlant = this.AreaToPlant,
                AreaPlanted = this.AreaPlanted,
                DensityHa = this.DensityHa,
                TreesPlanted = this.TreesPlanted,
                TreesToPlant = this.TreesToPlant,
                TreesAllocated = this.TreesAllocated,
                Comments = this.Comments,
            };
        }//endofclonemethods
    }


    public class TreePlantDetailEdit : PropertyBase<TreePlantDetailEdit>, IDuplicate
    {

        private TreePlantDetailDto _dto;


        public TreePlantDetailEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public TreePlantTerrainDto TerrainID { get; set; }

        public TreePlantAccessDto AccessID { get; set; }

        public Property<int> AdultsCount { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> ChildrenCount { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<double?> AreaToPlant { get; set; } = new Property<double?>() { Value = 0.0, Original = 0.0 };

        public Property<double?> AreaPlanted { get; set; } = new Property<double?>() { Value = 0.0, Original = 0.0 };

        public Property<double> DensityHa { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<int> TreesPlanted { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int?> TreesToPlant { get; set; } = new Property<int?>() { Value = 0, Original = 0 };

        public Property<int> TreesAllocated { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Comments { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };


        public int RecordId => Id.Value;


        public TreePlantDetailDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.AdultsCount = AdultsCount.Value;
            returnVal.ChildrenCount = ChildrenCount.Value;
            returnVal.AreaToPlant = AreaToPlant.Value;
            returnVal.AreaPlanted = AreaPlanted.Value;
            returnVal.DensityHa = DensityHa.Value;
            returnVal.TreesPlanted = TreesPlanted.Value;
            returnVal.TreesToPlant = TreesToPlant.Value;
            returnVal.TreesAllocated = TreesAllocated.Value;
            returnVal.Comments = Comments.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (TreePlantDetailEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(TreePlantDetailDto test)
        {
            this.AdultsCount = Property<int>.Make(test.AdultsCount);
            this.ChildrenCount = Property<int>.Make(test.ChildrenCount);
            this.AreaToPlant = Property<double?>.Make(test.AreaToPlant);
            this.AreaPlanted = Property<double?>.Make(test.AreaPlanted);
            this.DensityHa = Property<double>.Make(test.DensityHa);
            this.TreesPlanted = Property<int>.Make(test.TreesPlanted);
            this.TreesToPlant = Property<int?>.Make(test.TreesToPlant);
            this.TreesAllocated = Property<int>.Make(test.TreesAllocated);
            this.Comments = Property<string>.Make(test.Comments);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            AdultsCount.Revert();
            ChildrenCount.Revert();
            AreaToPlant.Revert();
            AreaPlanted.Revert();
            DensityHa.Revert();
            TreesPlanted.Revert();
            TreesToPlant.Revert();
            TreesAllocated.Revert();
            Comments.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<TreePlantDetailEdit> MakeCollection(List<TreePlantDetailDto> records)
        {

            var newData = new ExtRangeCollection<TreePlantDetailEdit>();

            foreach (var rec in records)
            {
                var e = new TreePlantDetailEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


    public class TreePlantDetailEditList : ListObj<TreePlantDetailDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private TreePlantDetailDto _dto;


        public TreePlantDetailEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public TreePlantTerrainDto TerrainID { get => _current.TerrainID; set { _current.TerrainID = value; OnPropertyChanged(); } }

        public TreePlantAccessDto AccessID { get => _current.AccessID; set { _current.AccessID = value; OnPropertyChanged(); } }

        public int AdultsCount { get => _current.AdultsCount; set { _current.AdultsCount = value; OnPropertyChanged(); } }

        public int ChildrenCount { get => _current.ChildrenCount; set { _current.ChildrenCount = value; OnPropertyChanged(); } }

        public double? AreaToPlant { get => _current.AreaToPlant; set { _current.AreaToPlant = value; OnPropertyChanged(); } }

        public double? AreaPlanted { get => _current.AreaPlanted; set { _current.AreaPlanted = value; OnPropertyChanged(); } }

        public double DensityHa { get => _current.DensityHa; set { _current.DensityHa = value; OnPropertyChanged(); } }

        public int TreesPlanted { get => _current.TreesPlanted; set { _current.TreesPlanted = value; OnPropertyChanged(); } }

        public int? TreesToPlant { get => _current.TreesToPlant; set { _current.TreesToPlant = value; OnPropertyChanged(); } }

        public int TreesAllocated { get => _current.TreesAllocated; set { _current.TreesAllocated = value; OnPropertyChanged(); } }

        public string Comments { get => _current.Comments; set { _current.Comments = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public TreePlantDetailDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.AdultsCount = this.AdultsCount;
            returnVal.ChildrenCount = this.ChildrenCount;
            returnVal.AreaToPlant = this.AreaToPlant;
            returnVal.AreaPlanted = this.AreaPlanted;
            returnVal.DensityHa = this.DensityHa;
            returnVal.TreesPlanted = this.TreesPlanted;
            returnVal.TreesToPlant = this.TreesToPlant;
            returnVal.TreesAllocated = this.TreesAllocated;           
            returnVal.Comments = this.Comments;
            returnVal.TerrainID = this.TerrainID;
            returnVal.AccessID = this.AccessID;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (TreePlantDetailEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(TreePlantDetailDto test)
        {
            _original.AdultsCount = test.AdultsCount;
            _current.AdultsCount = test.AdultsCount;
            _original.ChildrenCount = test.ChildrenCount;
            _current.ChildrenCount = test.ChildrenCount;
            _original.AreaToPlant = test.AreaToPlant;
            _current.AreaToPlant = test.AreaToPlant;
            _original.AreaPlanted = test.AreaPlanted;
            _current.AreaPlanted = test.AreaPlanted;
            _original.DensityHa = test.DensityHa;
            _current.DensityHa = test.DensityHa;
            _original.TreesPlanted = test.TreesPlanted;
            _current.TreesPlanted = test.TreesPlanted;
            _original.TreesToPlant = test.TreesToPlant;
            _current.TreesToPlant = test.TreesToPlant;
            _original.TreesAllocated = test.TreesAllocated;
            _current.TreesAllocated = test.TreesAllocated;
            _original.Comments = test.Comments;
            _current.Comments = test.Comments;

            _original.TerrainID = test.TerrainID;
            _current.TerrainID = test.TerrainID;

            _original.AccessID = test.AccessID;
            _current.AccessID = test.AccessID;


            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<TreePlantDetailEditList> MakeCollection(List<TreePlantDetailDto> records)
        {

            var newData = new ExtRangeCollection<TreePlantDetailEditList>();

            foreach (var rec in records)
            {
                var e = new TreePlantDetailEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}