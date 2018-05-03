using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class PublicRightOfWayDto : BaseDto, IRecord
    {
        public bool Bridleway { get; set; }

        public string BridlewayDescription { get; set; }

        public bool Footpath { get; set; }

        public string FootpathDescription { get; set; }

        public bool Other { get; set; }

        public string OtherDescription { get; set; }

        public string Comments { get; set; }
        public PublicRightOfWayDto Clone()
        {
            return new PublicRightOfWayDto()
            {
                Bridleway = this.Bridleway,
                BridlewayDescription = this.BridlewayDescription,
                Footpath = this.Footpath,
                FootpathDescription = this.FootpathDescription,
                Other = this.Other,
                OtherDescription = this.OtherDescription,
                Comments = this.Comments,
            };
        }//endofclonemethods
    }

    public class PublicRightOfWayEdit : PropertyBase<PublicRightOfWayEdit>, IDuplicate
    {

        private PublicRightOfWayDto _dto;


        public PublicRightOfWayEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<bool> Bridleway { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> BridlewayDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> Footpath { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> FootpathDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> Other { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> OtherDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Comments { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };


        public int RecordId => Id.Value;


        public PublicRightOfWayDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Bridleway = Bridleway.Value;
            returnVal.BridlewayDescription = BridlewayDescription.Value;
            returnVal.Footpath = Footpath.Value;
            returnVal.FootpathDescription = FootpathDescription.Value;
            returnVal.Other = Other.Value;
            returnVal.OtherDescription = OtherDescription.Value;
            returnVal.Comments = Comments.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PublicRightOfWayEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PublicRightOfWayDto test)
        {
            this.Bridleway = Property<bool>.Make(test.Bridleway,Bridleway);
            this.BridlewayDescription = Property<string>.Make(test.BridlewayDescription,BridlewayDescription);
            this.Footpath = Property<bool>.Make(test.Footpath,Footpath);
            this.FootpathDescription = Property<string>.Make(test.FootpathDescription,FootpathDescription);
            this.Other = Property<bool>.Make(test.Other,Other);
            this.OtherDescription = Property<string>.Make(test.OtherDescription,OtherDescription);
            this.Comments = Property<string>.Make(test.Comments,Comments);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Bridleway.Revert();
            BridlewayDescription.Revert();
            Footpath.Revert();
            FootpathDescription.Revert();
            Other.Revert();
            OtherDescription.Revert();
            Comments.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<PublicRightOfWayEdit> MakeCollection(List<PublicRightOfWayDto> records)
        {

            var newData = new ExtRangeCollection<PublicRightOfWayEdit>();

            foreach (var rec in records)
            {
                var e = new PublicRightOfWayEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class PublicRightOfWayEditList : ListObj<PublicRightOfWayDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private PublicRightOfWayDto _dto;


        public PublicRightOfWayEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public bool Bridleway { get => _current.Bridleway; set { _current.Bridleway = value; OnPropertyChanged(); } }

        public string BridlewayDescription { get => _current.BridlewayDescription; set { _current.BridlewayDescription = value; OnPropertyChanged(); } }

        public bool Footpath { get => _current.Footpath; set { _current.Footpath = value; OnPropertyChanged(); } }

        public string FootpathDescription { get => _current.FootpathDescription; set { _current.FootpathDescription = value; OnPropertyChanged(); } }

        public bool Other { get => _current.Other; set { _current.Other = value; OnPropertyChanged(); } }

        public string OtherDescription { get => _current.OtherDescription; set { _current.OtherDescription = value; OnPropertyChanged(); } }

        public string Comments { get => _current.Comments; set { _current.Comments = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public PublicRightOfWayDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Bridleway = this.Bridleway;
            returnVal.BridlewayDescription = this.BridlewayDescription;
            returnVal.Footpath = this.Footpath;
            returnVal.FootpathDescription = this.FootpathDescription;
            returnVal.Other = this.Other;
            returnVal.OtherDescription = this.OtherDescription;
            returnVal.Comments = this.Comments;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PublicRightOfWayEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PublicRightOfWayDto test)
        {
            _original.Bridleway = test.Bridleway;
            _current.Bridleway = test.Bridleway;
            _original.BridlewayDescription = test.BridlewayDescription;
            _current.BridlewayDescription = test.BridlewayDescription;
            _original.Footpath = test.Footpath;
            _current.Footpath = test.Footpath;
            _original.FootpathDescription = test.FootpathDescription;
            _current.FootpathDescription = test.FootpathDescription;
            _original.Other = test.Other;
            _current.Other = test.Other;
            _original.OtherDescription = test.OtherDescription;
            _current.OtherDescription = test.OtherDescription;
            _original.Comments = test.Comments;
            _current.Comments = test.Comments;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<PublicRightOfWayEditList> MakeCollection(List<PublicRightOfWayDto> records)
        {

            var newData = new ExtRangeCollection<PublicRightOfWayEditList>();

            foreach (var rec in records)
            {
                var e = new PublicRightOfWayEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}