using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace EFStores
{
    public class WoodlandconditionsubsectionDTO
    {
        public int ID { get; set; }
        public int FeatureMonitoringID { get; set; }
        public bool WholeSite { get; set; }
        public int? KeyFeatureID { get; set; }
        public int? StratumID { get; set; }
        public string StratumDescription { get; set; }
        public bool? OverallInterventionDesirable { get; set; }
        public bool? OverallInterventionAchievable { get; set; }
        public string OverallConclusionsAndRecommendations { get; set; }
        public int? TotalTreeCanopyCoverPercentCurrent { get; set; }
        public int? TotalTreeCanopyCoverPercentMin { get; set; }
        public int? TotalTreeCanopyCoverPercentMax { get; set; }
        public int? OpenSpaceSemiNaturalHabitatPercentCurrent { get; set; }
        public int? OpenSpaceSemiNaturalHabitatPercentMin { get; set; }
        public int? OpenSpaceSemiNaturalHabitatPercentMax { get; set; }
        public int? OpenSpaceRidesPercentCurrent { get; set; }
        public int? OpenSpaceRidesPercentMin { get; set; }
        public int? OpenSpaceRidesPercentMax { get; set; }
        public int? OpenSpaceTemporaryPercentCurrent { get; set; }
        public int? OpenSpaceTemporaryPercentMin { get; set; }
        public int? OpenSpaceTemporaryPercentMax { get; set; }
        public int? OpenSpaceWaterFeaturesPercentCurrent { get; set; }
        public int? OpenSpaceWaterFeaturesPercentMin { get; set; }
        public int? OpenSpaceWaterFeaturesPercentMax { get; set; }
        public int? ShrubCoverPercentCurrent { get; set; }
        public int? ShrubCoverPercentMin { get; set; }
        public int? ShrubCoverPercentMax { get; set; }
        public bool? InterventionDesirable { get; set; }
        public bool? InterventionAchievable { get; set; }
        public string NotesAction { get; set; }
        public bool? TAOverall { get; set; }
        public bool? TAPlot1 { get; set; }
        public bool? TAPlot2 { get; set; }
        public bool? TAPlot3 { get; set; }
        public bool? TAPlot4 { get; set; }
        public bool? TAPlot5 { get; set; }
        public bool TAInterventionDesirable { get; set; }
        public bool TAInterventionAchievable { get; set; }
        public string TANotesActions { get; set; }
        public bool? TSOverall { get; set; }
        public bool? TSPlot1 { get; set; }
        public bool? TSPlot2 { get; set; }
        public bool? TSPlot3 { get; set; }
        public bool? TSPlot4 { get; set; }
        public bool? TSPlot5 { get; set; }
        public bool TSCanopyDominatedByOneOrTwoSPP { get; set; }
        public bool TSInterventionDesirable { get; set; }
        public bool TSInterventionAchievable { get; set; }
        public string TSNotesActions { get; set; }
        public bool? SSOverall { get; set; }
        public bool? SSPlot1 { get; set; }
        public bool? SSPlot2 { get; set; }
        public bool? SSPlot3 { get; set; }
        public bool? SSPlot4 { get; set; }
        public bool? SSPlot5 { get; set; }
        public bool SSShrubLayerDominatedByOneOrTwoSPP { get; set; }
        public bool SSInterventionDesirable { get; set; }
        public bool SSInterventionAchievable { get; set; }
        public string SSNotesActions { get; set; }
        public bool? LTROverall { get; set; }
        public bool? LTRPlot1 { get; set; }
        public bool? LTRPlot2 { get; set; }
        public bool? LTRPlot3 { get; set; }
        public bool? LTRPlot4 { get; set; }
        public bool? LTRPlot5 { get; set; }
        public bool LTRInterventionDesirable { get; set; }
        public bool LTRInterventionAchievable { get; set; }
        public string LTRNotesActions { get; set; }
        public bool? LSROverall { get; set; }
        public bool? LSRPlot1 { get; set; }
        public bool? LSRPlot2 { get; set; }
        public bool? LSRPlot3 { get; set; }
        public bool? LSRPlot4 { get; set; }
        public bool? LSRPlot5 { get; set; }
        public bool LSRInterventionDesirable { get; set; }
        public bool LSRInterventionAchievable { get; set; }
        public string LSRNotesActions { get; set; }
        public bool? RTSOverall { get; set; }
        public bool? RTSPlot1 { get; set; }
        public bool? RTSPlot2 { get; set; }
        public bool? RTSPlot3 { get; set; }
        public bool? RTSPlot4 { get; set; }
        public bool? RTSPlot5 { get; set; }
        public bool RTSInterventionDesirable { get; set; }
        public bool RTSInterventionAchievable { get; set; }
        public string RTSNotesActions { get; set; }
        public bool? RSSOverall { get; set; }
        public bool? RSSPlot1 { get; set; }
        public bool? RSSPlot2 { get; set; }
        public bool? RSSPlot3 { get; set; }
        public bool? RSSPlot4 { get; set; }
        public bool? RSSPlot5 { get; set; }
        public bool RSSInterventionDesirable { get; set; }
        public bool RSSInterventionAchievable { get; set; }
        public string RSSNotesActions { get; set; }
        public bool? FOverall { get; set; }
        public bool? FPlot1 { get; set; }
        public bool? FPlot2 { get; set; }
        public bool? FPlot3 { get; set; }
        public bool? FPlot4 { get; set; }
        public bool? FPlot5 { get; set; }
        public bool FInterventionDesirable { get; set; }
        public bool FInterventionAchievable { get; set; }
        public string FNotesActions { get; set; }
        public bool? DOverall { get; set; }
        public bool? DPlot1 { get; set; }
        public bool? DPlot2 { get; set; }
        public bool? DPlot3 { get; set; }
        public bool? DPlot4 { get; set; }
        public bool? DPlot5 { get; set; }
        public bool DInterventionDesirable { get; set; }
        public bool DInterventionAchievable { get; set; }
        public string DNotesActions { get; set; }
        public bool? ADOverall { get; set; }
        public bool? ADPlot1 { get; set; }
        public bool? ADPlot2 { get; set; }
        public bool? ADPlot3 { get; set; }
        public bool? ADPlot4 { get; set; }
        public bool? ADPlot5 { get; set; }
        public bool ADInterventionDesirable { get; set; }
        public bool ADInterventionAchievable { get; set; }
        public string ADNotesActions { get; set; }
        public bool? IOverall { get; set; }
        public bool? IPlot1 { get; set; }
        public bool? IPlot2 { get; set; }
        public bool? IPlot3 { get; set; }
        public bool? IPlot4 { get; set; }
        public bool? IPlot5 { get; set; }
        public bool IInterventionDesirable { get; set; }
        public bool IInterventionAchievable { get; set; }
        public string INotesActions { get; set; }
        public bool? THOverall { get; set; }
        public bool? THPlot1 { get; set; }
        public bool? THPlot2 { get; set; }
        public bool? THPlot3 { get; set; }
        public bool? THPlot4 { get; set; }
        public bool? THPlot5 { get; set; }
        public bool THInterventionDesirable { get; set; }
        public bool THInterventionAchievable { get; set; }
        public string THNotesActions { get; set; }
        public bool? HIOverall { get; set; }
        public bool? HIPlot1 { get; set; }
        public bool? HIPlot2 { get; set; }
        public bool? HIPlot3 { get; set; }
        public bool? HIPlot4 { get; set; }
        public bool? HIPlot5 { get; set; }
        public bool HIInterventionDesirable { get; set; }
        public bool HIInterventionAchievable { get; set; }
        public string HINotesActions { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime LMDT { get; set; }
        public int LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
    }

    public class KeyFeatLookupDTO
    {
        public int ID { get; set; }

        public string Description { get; set; }
    }

    public class ConditionalAssessmentEFStore : BaseEFStore, IConditionalAssessmentsStore
    {
        public ConditionalAssessmentEFStore(EstateContext ec, ICache iCache, IUserStore iUserStore) : 
            base(ec, iCache)
        {
            _iUserStore = iUserStore;
        }

        public CafStrataSummaryDto GetCAFStrataSummaryDTO(int featureMonitoringID)
        {
            var cAfStrataSummaryDto = new CafStrataSummaryDto { CafSummaryObjsList = new List<CAFSummaryObjDTO>() };
           
            var featureLookup = Context.Feature.Include(f => f.Type).Select(f => new KeyFeatureCADTO()
            {
                ID = f.Id,
                Description = f.Type.Description
            });

            var ds = Context.FeatureMonitoring.Include(f => f.Feature)
                .Where(x => x.Feature.Reference == "F97" && x.Id == featureMonitoringID).Select(a=>a.Id).ToList();

            var stratum = Context.WoodlandConditionStratum.ToList();

            var conditions = Context.WoodlandConditionSubSection.Where(f => ds.Contains(f.FeatureMonitoringId))
                .ToList();

            

            foreach (var con in conditions)
            {

                string strataDesc = "Not Applicable";

                var slookup = stratum.FirstOrDefault(f => f.Id == con.StratumId.GetValueOrDefault());

                if (slookup != null)
                {
                    strataDesc = slookup.Description;
                }



                string featureDescription = "Not Applicable";


                var flookup = featureLookup.FirstOrDefault(f => f.ID == con.KeyFeatureId.GetValueOrDefault());

                if (flookup != null)
                {
                    featureDescription = flookup.Description;
                }


                var cafContainer = new CAFSummaryObjDTO()
                {
                    WoodlandConditionSubSectionID = con.Id,
                    StratumID = con.StratumId.GetValueOrDefault(),
                    WholeSite = con.WholeSite,
                    StratumDescription = strataDesc,
                    KeyFeatureID = con.KeyFeatureId.GetValueOrDefault(),
                    FeatureDescription = featureDescription,
                    NoOfPlots = 0,
                    OverallInterventionDesirable = con.OverallInterventionDesirable,
                    OverallInterventionAchievable = con.OverallInterventionAchievable,
                    OverallConclusionsAndRecommendations = con.OverallConclusionsAndRecommendations,

                    InterventionDesirable = con.InterventionDesirable,
                    InterventionAchievable = con.InterventionAchievable,
                    NotesAction = con.NotesAction,

                    TAInterventionDesirable = con.TainterventionDesirable,
                    TAInterventionAchievable = con.TainterventionAchievable,
                    TANotesActions = con.TanotesActions,

                    TSInterventionDesirable = con.TsinterventionDesirable,
                    TSInterventionAchievable = con.TsinterventionAchievable,
                    TSNotesActions = con.TsnotesActions,

                    SSInterventionDesirable = con.SsinterventionDesirable,
                    SSInterventionAchievable = con.SsinterventionAchievable,
                    SSNotesActions = con.SsnotesActions,
                    
                    LTRInterventionDesirable = con.LtrinterventionDesirable,
                    LTRInterventionAchievable = con.LtrinterventionAchievable,
                    LTRNotesActions = con.LtrnotesActions,

                    LSRInterventionDesirable = con.LsrinterventionDesirable,
                    LSRInterventionAchievable = con.LsrinterventionAchievable,
                    LSRNotesActions = con.LsrnotesActions,

                    RTSInterventionDesirable = con.RtsinterventionDesirable,
                    RTSInterventionAchievable = con.RtsinterventionAchievable,
                    RTSNotesActions = con.RtsnotesActions,

                    RSSInterventionDesirable = con.RssinterventionDesirable,
                    RSSInterventionAchievable = con.RssinterventionAchievable,
                    RSSNotesActions = con.RssnotesActions,

                    FInterventionDesirable = con.FinterventionDesirable,
                    FInterventionAchievable = con.FinterventionAchievable,
                    FNotesActions = con.FnotesActions,

                    DInterventionDesirable = con.DinterventionDesirable,
                    DInterventionAchievable = con.DinterventionAchievable,
                    DNotesActions = con.DnotesActions,

                    ADInterventionDesirable = con.AdinterventionDesirable,
                    ADInterventionAchievable = con.AdinterventionAchievable,
                    ADNotesActions = con.AdnotesActions,

                    IInterventionDesirable = con.IinterventionDesirable,
                    IInterventionAchievable = con.IinterventionAchievable,
                    INotesActions = con.InotesActions,

                    THInterventionDesirable = con.ThinterventionDesirable,
                    THInterventionAchievable = con.ThinterventionAchievable,
                    THNotesActions = con.ThnotesActions,

                    HIInterventionDesirable = con.HiinterventionDesirable,
                    HIInterventionAchievable = con.HiinterventionAchievable,
                    HINotesActions = con.HinotesActions,


                };


                cAfStrataSummaryDto.CafSummaryObjsList.Add(cafContainer);
            }



            return cAfStrataSummaryDto;
        }

        public List<WoodlandSubsectionDto> GetCFContainerCollection(int featureMonitoringId)
        {
            var CafContainersList = new List<WoodlandSubsectionDto>();
            
            var featureTypeLookup = Context.WoodlandConditionSubSection.Include(w => w.KeyFeature)
                .ThenInclude(f => f.Type).Where(a => a.FeatureMonitoringId == featureMonitoringId)
                .Select(s => new KeyFeatLookupDTO() { ID = s.Id, Description = s.KeyFeature.Type.Description}).ToList();

            var stratumLookup = GetCAStratums();
            var featuresLookup = GetCAKeyFeatures(featureMonitoringId);


            var conditions = GetWoodlandConditionsForManagementUnitId(featureMonitoringId);


            foreach (var con in conditions)
            {              
                var featurelookedup = featureTypeLookup.FirstOrDefault(f => f.ID == con.Id);

                string desc = "";

                if (featurelookedup != null)
                    desc = featurelookedup.Description;

                var cafContainer = new WoodlandSubsectionDto()
                {
                    Id = con.Id,
                    WholeSite = con.WholeSite,
                    StratumDescription = con.StratumDescription,
                    KeyFeatureId = con.KeyFeatureId.GetValueOrDefault(),
                    KeyFeatureDescription = "KF-" + desc,
                    KeyFeature = featuresLookup.FirstOrDefault(f => f.ID == con.KeyFeatureId.GetValueOrDefault()),

                    StratumId = con.StratumId.GetValueOrDefault(),
                    Stratum = stratumLookup.FirstOrDefault(f=>f.ID == con.StratumId.GetValueOrDefault()),
                    
                    
                    ManagementUnitId = featureMonitoringId
                };


                CafContainersList.Add(cafContainer);
            }

            return CafContainersList;
        }

        private List<WoodlandConditionSubSection> GetWoodlandConditionsForManagementUnitId(int featureMonitoringId)
        {
          //  var IDs = Context.FeatureMonitoring.Include(f => f.Feature)
         //       .Where(x => x.Feature.Reference == "F97" && x.Id == managementUnitID).Select(a => a.Id).ToList();

            //var managementUnitId = Context.FeatureMonitoring
            //    .Include(f => f.Feature).First(x => x.Feature.Reference == "F97" && x.Id == managementUnitID).Feature
            //    .ManagementUnitId;

            var conditions = Context.WoodlandConditionSubSection.Where(f => f.FeatureMonitoringId == featureMonitoringId)
                .ToList();



            return conditions;
        }

        public void UpdateCFContainerCollection(int managementUnitId,int featureMonitoringId, List<WoodlandSubsectionDto> editSet)
        {
            var currentUserId = _iUserStore.CurrentUserId();
            var existingData = Context.WoodlandConditionSubSection.Where(f => f.FeatureMonitoringId== featureMonitoringId).ToList();

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingData.Select(i => i.Id).ToList();

            var deletedRecords = (from existingRecord in existingData where !editSetIds.Contains(existingRecord.Id) select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id)).ToList();

            foreach (var xRec in existingData)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord != null)
                {
                    xRec.Id = matchedRecord.Id;             
                    xRec.WholeSite = matchedRecord.WholeSite;
                    xRec.KeyFeatureId = matchedRecord.KeyFeatureId==0? null : (int?)matchedRecord.KeyFeatureId;
                    xRec.KeyFeature = Context.Feature.FirstOrDefault(f => f.Id == matchedRecord.KeyFeatureId);
                    xRec.StratumId = matchedRecord.StratumId == 0 ? null : (int?) matchedRecord.StratumId;
                    xRec.Stratum =
                        Context.WoodlandConditionStratum.FirstOrDefault(f => f.Id == matchedRecord.StratumId);                    
                }

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                }
            }

            Context.SaveChanges();

            

            //var keyFeatures = newRecords.Select(s => s.KeyFeatureId).ToList();
            //var features = Context.Feature.Where(f => keyFeatures.Contains(f.Id)).ToList();


            //var strata = newRecords.Select(a => a.StratumId).ToList();
            //var statums = Context.WoodlandConditionStratum.Where(w => strata.Contains(w.Id)).ToList();

            



            var recordsToAdd = newRecords.Select(nr => new WoodlandConditionSubSection()
            {
                WholeSite = nr.WholeSite,
                KeyFeatureId = nr.KeyFeatureId == 0 ? null : (int?)nr.KeyFeatureId,
          
                StratumId = nr.StratumId == 0 ? null : (int?)nr.StratumId,
  
                FeatureMonitoringId = featureMonitoringId,         
                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Cruid = currentUserId,
                Crdt = DateTime.Today,
                Dldt = DateTime.Today,
                Dluid = currentUserId              
            }).ToList();

            Context.AddRange(recordsToAdd);

            

            try
            {
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ComboBoxValue> GetCAStratums()
        {
            var results = new List<ComboBoxValue>
            {
                new ComboBoxValue()
                {
                    ID = 0,
                    Name = "Not Set",
                    Description = "Not Set"
                }
            };

            results.AddRange(Context.WoodlandConditionStratum.Select(v => new ComboBoxValue()
            {
                ID = v.Id,
                Name = v.Description,
                Description = v.Description
            }));

            return results;
        }

        public List<ComboBoxValue> GetCAKeyFeatures(int filter)
        {
            var results = new List<ComboBoxValue>
            {
                new ComboBoxValue()
                {
                    ID = 0,
                    Name = "Not Set",
                    Description = "Not Set"
                }
            };

            var parentManagementUnitId = Context.FeatureMonitoring.Include(h => h.Feature)
                .FirstOrDefault(f => f.Id == filter).Feature.ManagementUnitId;


            foreach (var hazAct in Context.FeatureType.Include(i => i.Feature))
            {
                results.AddRange(from v in hazAct.Feature
                                 where v.ManagementUnitId == parentManagementUnitId
                                 select new ComboBoxValue()
                                 {
                                     ID = v.Id,
                                     Description = hazAct.Description,
                                     Name = hazAct.Description
                                 });
            }

            return results;
        }


        public List<ConditionAssessmentEditorEntryDto> GetConditionAssessmentEditorDto(int managementUnitID)
        {

           var conditions= Context.WoodlandConditionExtension.Include(f => f.FeatureMonitoring).ThenInclude(fe=>fe.Feature)
                .Where(fe =>
                    (fe.FeatureMonitoring.Feature.Description == "Condition Assessment" || fe.FeatureMonitoring.Feature.Description == "Woodland Condition") &&
                    fe.FeatureMonitoring.Feature.ManagementUnitId == managementUnitID).Select(s => new ConditionAssessmentEditorEntryDto()
                {
                    FeatureMonitoringID = s.FeatureMonitoringId,
                    FeatureID = s.FeatureMonitoring.FeatureId,
                    Description = s.FeatureMonitoring.Feature.Description,                   
                    PlannedObservationDate = s.FeatureMonitoring.PlannedObservationDate,
                    ActualObservationDate = s.FeatureMonitoring.ActualObservationDate,
                    DeadlineActionDate = s.FeatureMonitoring.DeadlineActionDate,
                    ActualActionDate = s.FeatureMonitoring.ActualActionDate,
                    PredictionShortTermObjective = s.FeatureMonitoring.PredictionShortTermObjective,
                    ActualObservation = s.FeatureMonitoring.ActualObservation,
                    PlannedObservation = s.FeatureMonitoring.PlannedObservation,
                    SuggestionsAndActions = s.FeatureMonitoring.SuggestionsAndActions,
                    Surveyor = s.Surveyor,
                    AreaHa = s.AreaHa,
                    AreaAWHa = s.AreaAwha,
                    ChangeInAreaAWSinceLastSurveyHa = s.ChangeInAreaSinceLastSurveyHa,
                    ChangeInAreaSinceLastSurveyHa = s.ChangeInAreaSinceLastSurveyHa,
                    ConclusionsAndRecommendations = s.ConclusionsAndRecommendations,
                    Id = s.Id
                })
                .ToList();

   
            return conditions;
        }

        public void UpdateConditionAssessmentEditorEntryDtos(int managementUnitId, List<ConditionAssessmentEditorEntryDto> editSet)
        {
            var existingData = Context.WoodlandConditionExtension.Include(f => f.FeatureMonitoring)
                .ThenInclude(fe => fe.Feature)
                .Where(fe =>
                    (fe.FeatureMonitoring.Feature.Description == "Condition Assessment" ||
                     fe.FeatureMonitoring.Feature.Description == "Woodland Condition") &&
                    fe.FeatureMonitoring.Feature.ManagementUnitId == managementUnitId);

            var currentUserId = _iUserStore.CurrentUserId();
         //   var existingData = Context.WoodlandConditionExtension.Where(f => f.FeatureMonitoringId == featureMonitoringId).ToList();

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingData.Select(i => i.Id).ToList();

            var deletedRecords = (from existingRecord in existingData where !editSetIds.Contains(existingRecord.Id) select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id)).ToList();


            foreach (var r in editSet)
            {
                var fm = Context.FeatureMonitoring.FirstOrDefault(f => f.Id == r.FeatureMonitoringID);

                if (fm != null)
                {
                    fm.PlannedObservationDate = r.PlannedObservationDate;
                    fm.PlannedObservation = r.PlannedObservation;
                    fm.ActualObservationDate = r.ActualObservationDate;
                    fm.DeadlineActionDate = r.DeadlineActionDate;
                    fm.ActualActionDate = r.ActualActionDate;
                    fm.ActualObservation = r.ActualObservation;
                    fm.SuggestionsAndActions = r.SuggestionsAndActions;
                }
            }


            foreach (var xRec in existingData)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord != null)
                {
                    xRec.Id = matchedRecord.Id;
                    xRec.FeatureMonitoring =
                        Context.FeatureMonitoring.FirstOrDefault(f => f.Id == matchedRecord.FeatureMonitoringID);
                    xRec.AreaAwha = matchedRecord.AreaAWHa.GetValueOrDefault();
                    xRec.AreaHa = matchedRecord.AreaHa.GetValueOrDefault();
                    xRec.ChangeInAreaAwsinceLastSurveyHa =
                        matchedRecord.ChangeInAreaSinceLastSurveyHa.GetValueOrDefault();
                    xRec.ChangeInAreaSinceLastSurveyHa =
                        matchedRecord.ChangeInAreaSinceLastSurveyHa.GetValueOrDefault();
                    xRec.ConclusionsAndRecommendations = matchedRecord.ConclusionsAndRecommendations;
                    xRec.OverallAchievable = matchedRecord.OverallAchievable.GetValueOrDefault();
                    xRec.OverallDesirable = matchedRecord.OverallDesirable.GetValueOrDefault();
                    xRec.Surveyor = matchedRecord.Surveyor;

                }

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                }
            }


          //  var featureMonitor = Context.Feature.Include(f=>f.FeatureMonitoring).FirstOrDefault(m=>m.ManagementUnitId == managementUnitId);

           
            newRecords.ForEach(x =>
            {
                if (x.FeatureMonitoringID == 0)
                {
                    var fm = new FeatureMonitoring()
                    {
                        ActualActionDate = x.ActualActionDate,
                        ActualObservation = x.ActualObservation,
                        ActualObservationDate = x.ActualObservationDate,
                        DeadlineActionDate = x.DeadlineActionDate,
                        PlannedObservation = x.PlannedObservation,
                        PlannedObservationDate = x.PlannedObservationDate,
                        FeatureId = Context.Feature.FirstOrDefault(f=>f.ManagementUnitId== managementUnitId && (f.Description == "Condition Assessment" ) && !f.Deleted).Id
                    };


                    Context.Add(fm);

                    Context.SaveChanges();

                    x.FeatureMonitoringID = fm.Id;
                }
            });


            var recordsToAdd = newRecords.Select(nr => new WoodlandConditionExtension()
            {
                
                FeatureMonitoringId = nr.FeatureMonitoringID,
                AreaAwha = nr.AreaAWHa.GetValueOrDefault(),
                AreaHa = nr.AreaHa.GetValueOrDefault(),
                ChangeInAreaAwsinceLastSurveyHa =
                    nr.ChangeInAreaSinceLastSurveyHa.GetValueOrDefault(),
                ChangeInAreaSinceLastSurveyHa =
                    nr.ChangeInAreaSinceLastSurveyHa.GetValueOrDefault(),
                ConclusionsAndRecommendations = nr.ConclusionsAndRecommendations,
                OverallAchievable = nr.OverallAchievable.GetValueOrDefault(),
                OverallDesirable = nr.OverallDesirable.GetValueOrDefault(),
                Surveyor = nr.Surveyor,
                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Cruid = currentUserId,
                Crdt = DateTime.Today,
                Dldt = DateTime.Today,
                Dluid = currentUserId
            }).ToList();

            Context.AddRange(recordsToAdd);

            try
            {
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ConditionAssessmentListDTO> GetConditionAssessmentListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            #region idiot select query that needs turning into c# at some point
            string magicString = "SELECT ID,\r\n       FeatureMonitoringID,\r\n       WholeSite,\r\n       KeyFeatureID,\r\n       StratumID,\r\n       StratumDescription,\r\n       OverallInterventionDesirable,\r\n       OverallInterventionAchievable,\r\n       OverallConclusionsAndRecommendations,\r\n       TotalTreeCanopyCoverPercentCurrent,\r\n       TotalTreeCanopyCoverPercentMin,\r\n       TotalTreeCanopyCoverPercentMax,\r\n       OpenSpaceSemiNaturalHabitatPercentCurrent,\r\n       OpenSpaceSemiNaturalHabitatPercentMin,\r\n       OpenSpaceSemiNaturalHabitatPercentMax,\r\n       OpenSpaceRidesPercentCurrent,\r\n       OpenSpaceRidesPercentMin,\r\n       OpenSpaceRidesPercentMax,\r\n       OpenSpaceTemporaryPercentCurrent,\r\n       OpenSpaceTemporaryPercentMin,\r\n       OpenSpaceTemporaryPercentMax,\r\n       OpenSpaceWaterFeaturesPercentCurrent,\r\n       OpenSpaceWaterFeaturesPercentMin,\r\n       OpenSpaceWaterFeaturesPercentMax,\r\n       ShrubCoverPercentCurrent,\r\n       ShrubCoverPercentMin,\r\n       ShrubCoverPercentMax,\r\n       InterventionDesirable,\r\n       InterventionAchievable,\r\n       NotesAction,\r\n       CAST(ISNULL(TAVeteranPollardsAncientCoppiceStoolsID, 0) | ISNULL(TA100_200YearsID, 0) | ISNULL(TA50_100YearsID, 0) | ISNULL(TA20_50YearsID, 0) | ISNULL(TA20YearsID, 0) AS BIT) AS TAOverall,\r\n       CAST(ISNULL(TAVeteranPollardsAncientCoppiceStoolsPlot1ID, 0) | ISNULL(TA100_200YearsPlot1ID, 0) | ISNULL(TA50_100YearsPlot1ID, 0) | ISNULL(TA20_50YearsPlot1ID, 0) | ISNULL(TA20YearsPlot1ID, 0) AS BIT) AS TAPlot1,\r\n       CAST(ISNULL(TAVeteranPollardsAncientCoppiceStoolsPlot2ID, 0) | ISNULL(TA100_200YearsPlot2ID, 0) | ISNULL(TA50_100YearsPlot2ID, 0) | ISNULL(TA20_50YearsPlot2ID, 0) | ISNULL(TA20YearsPlot2ID, 0) AS BIT) AS TAPlot2,\r\n       CAST(ISNULL(TAVeteranPollardsAncientCoppiceStoolsPlot3ID, 0) | ISNULL(TA100_200YearsPlot3ID, 0) | ISNULL(TA50_100YearsPlot3ID, 0) | ISNULL(TA20_50YearsPlot3ID, 0) | ISNULL(TA20YearsPlot3ID, 0) AS BIT) AS TAPlot3,\r\n       CAST(ISNULL(TAVeteranPollardsAncientCoppiceStoolsPlot4ID, 0) | ISNULL(TA100_200YearsPlot4ID, 0) | ISNULL(TA50_100YearsPlot4ID, 0) | ISNULL(TA20_50YearsPlot4ID, 0) | ISNULL(TA20YearsPlot4ID, 0) AS BIT) AS TAPlot4,\r\n       CAST(ISNULL(TAVeteranPollardsAncientCoppiceStoolsPlot5ID, 0) | ISNULL(TA100_200YearsPlot5ID, 0) | ISNULL(TA50_100YearsPlot5ID, 0) | ISNULL(TA20_50YearsPlot5ID, 0) | ISNULL(TA20YearsPlot5ID, 0) AS BIT) AS TAPlot5,\r\n       TAInterventionDesirable,\r\n       TAInterventionAchievable,\r\n       TANotesActions,\r\n       CAST(ISNULL(TSNativesNumberPresent, 0) | ISNULL(TSNonNativesNumberPresent, 0) AS BIT) AS TSOverall,\r\n       CAST(ISNULL(TSNativesNumberPresentPlot1, 0) | ISNULL(TSNonNativesNumberPresentPlot1, 0) AS BIT) AS TSPlot1,\r\n       CAST(ISNULL(TSNativesNumberPresentPlot2, 0) | ISNULL(TSNonNativesNumberPresentPlot2, 0) AS BIT) AS TSPlot2,\r\n       CAST(ISNULL(TSNativesNumberPresentPlot3, 0) | ISNULL(TSNonNativesNumberPresentPlot3, 0) AS BIT) AS TSPlot3,\r\n       CAST(ISNULL(TSNativesNumberPresentPlot4, 0) | ISNULL(TSNonNativesNumberPresentPlot4, 0) AS BIT) AS TSPlot4,\r\n       CAST(ISNULL(TSNativesNumberPresentPlot5, 0) | ISNULL(TSNonNativesNumberPresentPlot5, 0) AS BIT) AS TSPlot5,\r\n       TSCanopyDominatedByOneOrTwoSPP,\r\n       TSInterventionDesirable,\r\n       TSInterventionAchievable,\r\n       TSNotesActions,\r\n       CAST(ISNULL(SSNativesNumberPresent, 0) | ISNULL(SSNonNativesNumberPresent, 0) | ISNULL(SSDAFOROfCoverID, 0) AS BIT) AS SSOverall,\r\n       CAST(ISNULL(SSNativesNumberPresentPlot1, 0) | ISNULL(SSNonNativesNumberPresentPlot1, 0) | ISNULL(SSDAFOROfCoverPlot1ID, 0) AS BIT) AS SSPlot1,\r\n       CAST(ISNULL(SSNativesNumberPresentPlot2, 0) | ISNULL(SSNonNativesNumberPresentPlot2, 0) | ISNULL(SSDAFOROfCoverPlot2ID, 0) AS BIT) AS SSPlot2,\r\n       CAST(ISNULL(SSNativesNumberPresentPlot3, 0) | ISNULL(SSNonNativesNumberPresentPlot3, 0) | ISNULL(SSDAFOROfCoverPlot3ID, 0) AS BIT) AS SSPlot3,\r\n       CAST(ISNULL(SSNativesNumberPresentPlot4, 0) | ISNULL(SSNonNativesNumberPresentPlot4, 0) | ISNULL(SSDAFOROfCoverPlot4ID, 0) AS BIT) AS SSPlot4,\r\n       CAST(ISNULL(SSNativesNumberPresentPlot5, 0) | ISNULL(SSNonNativesNumberPresentPlot5, 0) | ISNULL(SSDAFOROfCoverPlot5ID, 0) AS BIT) AS SSPlot5,\r\n       SSShrubLayerDominatedByOneOrTwoSPP,\r\n       SSInterventionDesirable,\r\n       SSInterventionAchievable,\r\n       SSNotesActions,\r\n       CAST(ISNULL(LTRSeedlingsLess10cmID, 0) | ISNULL(LTRSeedlings10_100cmID, 0) | ISNULL(LTRSaplingsGreater100cmID, 0) | ISNULL(LTRCoppiceRegrowthOrSuckeringID, 0) AS BIT) AS LTROverall,\r\n       CAST(ISNULL(LTRSeedlingsLess10cmPlot1ID, 0) | ISNULL(LTRSeedlings10_100cmPlot1ID, 0) | ISNULL(LTRSaplingsGreater100cmPlot1ID, 0) | ISNULL(LTRCoppiceRegrowthOrSuckeringPlot1ID, 0) AS BIT) AS LTRPlot1,\r\n       CAST(ISNULL(LTRSeedlingsLess10cmPlot2ID, 0) | ISNULL(LTRSeedlings10_100cmPlot2ID, 0) | ISNULL(LTRSaplingsGreater100cmPlot2ID, 0) | ISNULL(LTRCoppiceRegrowthOrSuckeringPlot2ID, 0) AS BIT) AS LTRPlot2,\r\n       CAST(ISNULL(LTRSeedlingsLess10cmPlot3ID, 0) | ISNULL(LTRSeedlings10_100cmPlot3ID, 0) | ISNULL(LTRSaplingsGreater100cmPlot3ID, 0) | ISNULL(LTRCoppiceRegrowthOrSuckeringPlot3ID, 0) AS BIT) AS LTRPlot3,\r\n       CAST(ISNULL(LTRSeedlingsLess10cmPlot4ID, 0) | ISNULL(LTRSeedlings10_100cmPlot4ID, 0) | ISNULL(LTRSaplingsGreater100cmPlot4ID, 0) | ISNULL(LTRCoppiceRegrowthOrSuckeringPlot4ID, 0) AS BIT) AS LTRPlot4,\r\n       CAST(ISNULL(LTRSeedlingsLess10cmPlot5ID, 0) | ISNULL(LTRSeedlings10_100cmPlot5ID, 0) | ISNULL(LTRSaplingsGreater100cmPlot5ID, 0) | ISNULL(LTRCoppiceRegrowthOrSuckeringPlot5ID, 0) AS BIT) AS LTRPlot5,\r\n       LTRInterventionDesirable,\r\n       LTRInterventionAchievable,\r\n       LTRNotesActions,\r\n       CAST(ISNULL(LSRSeedlingsLess10cmID, 0) | ISNULL(LSRSeedlings10_100cmID, 0) | ISNULL(LSRSaplingsGreater100cmID, 0) | ISNULL(LSRCoppiceRegrowthOrSuckeringID, 0) AS BIT) AS LSROverall,\r\n       CAST(ISNULL(LSRSeedlingsLess10cmPlot1ID, 0) | ISNULL(LSRSeedlings10_100cmPlot1ID, 0) | ISNULL(LSRSaplingsGreater100cmPlot1ID, 0) | ISNULL(LSRCoppiceRegrowthOrSuckeringPlot1ID, 0) AS BIT) AS LSRPlot1,\r\n       CAST(ISNULL(LSRSeedlingsLess10cmPlot2ID, 0) | ISNULL(LSRSeedlings10_100cmPlot2ID, 0) | ISNULL(LSRSaplingsGreater100cmPlot2ID, 0) | ISNULL(LSRCoppiceRegrowthOrSuckeringPlot2ID, 0) AS BIT) AS LSRPlot2,\r\n       CAST(ISNULL(LSRSeedlingsLess10cmPlot3ID, 0) | ISNULL(LSRSeedlings10_100cmPlot3ID, 0) | ISNULL(LSRSaplingsGreater100cmPlot3ID, 0) | ISNULL(LSRCoppiceRegrowthOrSuckeringPlot3ID, 0) AS BIT) AS LSRPlot3,\r\n       CAST(ISNULL(LSRSeedlingsLess10cmPlot4ID, 0) | ISNULL(LSRSeedlings10_100cmPlot4ID, 0) | ISNULL(LSRSaplingsGreater100cmPlot4ID, 0) | ISNULL(LSRCoppiceRegrowthOrSuckeringPlot4ID, 0) AS BIT) AS LSRPlot4,\r\n       CAST(ISNULL(LSRSeedlingsLess10cmPlot5ID, 0) | ISNULL(LSRSeedlings10_100cmPlot5ID, 0) | ISNULL(LSRSaplingsGreater100cmPlot5ID, 0) | ISNULL(LSRCoppiceRegrowthOrSuckeringPlot5ID, 0) AS BIT) AS LSRPlot5,\r\n       LSRInterventionDesirable,\r\n       LSRInterventionAchievable,\r\n       LSRNotesActions,\r\n       CAST(ISNULL(RTSNativesNumberPresent, 0) | ISNULL(RTSNonNativesNumberPresent, 0) AS BIT) AS RTSOverall,\r\n       CAST(ISNULL(RTSNativesNumberPresentPlot1, 0) | ISNULL(RTSNonNativesNumberPresentPlot1, 0) AS BIT) AS RTSPlot1,\r\n       CAST(ISNULL(RTSNativesNumberPresentPlot2, 0) | ISNULL(RTSNonNativesNumberPresentPlot2, 0) AS BIT) AS RTSPlot2,\r\n       CAST(ISNULL(RTSNativesNumberPresentPlot3, 0) | ISNULL(RTSNonNativesNumberPresentPlot3, 0) AS BIT) AS RTSPlot3,\r\n       CAST(ISNULL(RTSNativesNumberPresentPlot4, 0) | ISNULL(RTSNonNativesNumberPresentPlot4, 0) AS BIT) AS RTSPlot4,\r\n       CAST(ISNULL(RTSNativesNumberPresentPlot5, 0) | ISNULL(RTSNonNativesNumberPresentPlot5, 0) AS BIT) AS RTSPlot5,\r\n       RTSInterventionDesirable,\r\n       RTSInterventionAchievable,\r\n       RTSNotesActions,\r\n       CAST(ISNULL(RSSNativesNumberPresent, 0) | ISNULL(RSSNonNativesNumberPresent, 0) AS BIT) AS RSSOverall,\r\n       CAST(ISNULL(RSSNativesNumberPresentPlot1, 0) | ISNULL(RSSNonNativesNumberPresentPlot1, 0) AS BIT) AS RSSPlot1,\r\n       CAST(ISNULL(RSSNativesNumberPresentPlot2, 0) | ISNULL(RSSNonNativesNumberPresentPlot2, 0) AS BIT) AS RSSPlot2,\r\n       CAST(ISNULL(RSSNativesNumberPresentPlot3, 0) | ISNULL(RSSNonNativesNumberPresentPlot3, 0) AS BIT) AS RSSPlot3,\r\n       CAST(ISNULL(RSSNativesNumberPresentPlot4, 0) | ISNULL(RSSNonNativesNumberPresentPlot4, 0) AS BIT) AS RSSPlot4,\r\n       CAST(ISNULL(RSSNativesNumberPresentPlot5, 0) | ISNULL(RSSNonNativesNumberPresentPlot5, 0) AS BIT) AS RSSPlot5,\r\n       RSSInterventionDesirable,\r\n       RSSInterventionAchievable,\r\n       RSSNotesActions,\r\n       CAST(ISNULL(FAncientWoodlandPlantsSpecialistsID, 0) | ISNULL(FOtherWoodlandPlantsGeneralistsID, 0) | ISNULL(FOtherNativePlantsID, 0) | ISNULL(FCoarseVegetationID, 0) | ISNULL(FOtherPlantsID, 0) | ISNULL(FNoVegetationID, 0) AS BIT) AS FOverall,\r\n       CAST(ISNULL(FAncientWoodlandPlantsSpecialistsPlot1ID, 0) | ISNULL(FOtherWoodlandPlantsGeneralistsPlot1ID, 0) | ISNULL(FOtherNativePlantsPlot1ID, 0) | ISNULL(FCoarseVegetationPlot1ID, 0) | ISNULL(FOtherPlantsPlot1ID, 0) | ISNULL(FNoVegetationPlot1ID, 0) AS BIT) AS FPlot1,\r\n       CAST(ISNULL(FAncientWoodlandPlantsSpecialistsPlot2ID, 0) | ISNULL(FOtherWoodlandPlantsGeneralistsPlot2ID, 0) | ISNULL(FOtherNativePlantsPlot2ID, 0) | ISNULL(FCoarseVegetationPlot2ID, 0) | ISNULL(FOtherPlantsPlot2ID, 0) | ISNULL(FNoVegetationPlot2ID, 0) AS BIT) AS FPlot2,\r\n       CAST(ISNULL(FAncientWoodlandPlantsSpecialistsPlot3ID, 0) | ISNULL(FOtherWoodlandPlantsGeneralistsPlot3ID, 0) | ISNULL(FOtherNativePlantsPlot3ID, 0) | ISNULL(FCoarseVegetationPlot3ID, 0) | ISNULL(FOtherPlantsPlot3ID, 0) | ISNULL(FNoVegetationPlot3ID, 0) AS BIT) AS FPlot3,\r\n       CAST(ISNULL(FAncientWoodlandPlantsSpecialistsPlot4ID, 0) | ISNULL(FOtherWoodlandPlantsGeneralistsPlot4ID, 0) | ISNULL(FOtherNativePlantsPlot4ID, 0) | ISNULL(FCoarseVegetationPlot4ID, 0) | ISNULL(FOtherPlantsPlot4ID, 0) | ISNULL(FNoVegetationPlot4ID, 0) AS BIT) AS FPlot4,\r\n       CAST(ISNULL(FAncientWoodlandPlantsSpecialistsPlot5ID, 0) | ISNULL(FOtherWoodlandPlantsGeneralistsPlot5ID, 0) | ISNULL(FOtherNativePlantsPlot5ID, 0) | ISNULL(FCoarseVegetationPlot5ID, 0) | ISNULL(FOtherPlantsPlot5ID, 0) | ISNULL(FNoVegetationPlot5ID, 0) AS BIT) AS FPlot5,\r\n       FInterventionDesirable,\r\n       FInterventionAchievable,\r\n       FNotesActions,\r\n       CAST(ISNULL(DStandingID, 0) | ISNULL(DFallenID, 0) AS BIT) AS DOverall,\r\n       CAST(ISNULL(DStandingPlot1ID, 0) | ISNULL(DFallenPlot1ID, 0) AS BIT) AS DPlot1,\r\n       CAST(ISNULL(DStandingPlot2ID, 0) | ISNULL(DFallenPlot2ID, 0) AS BIT) AS DPlot2,\r\n       CAST(ISNULL(DStandingPlot3ID, 0) | ISNULL(DFallenPlot3ID, 0) AS BIT) AS DPlot3,\r\n       CAST(ISNULL(DStandingPlot4ID, 0) | ISNULL(DFallenPlot4ID, 0) AS BIT) AS DPlot4,\r\n       CAST(ISNULL(DStandingPlot5ID, 0) | ISNULL(DFallenPlot5ID, 0) AS BIT) AS DPlot5,\r\n       DInterventionDesirable,\r\n       DInterventionAchievable,\r\n       DNotesActions,\r\n       CAST(ISNULL(ADSquirrelsID, 0) | ISNULL(ADDeerID, 0) | ISNULL(ADRabBITsID, 0) | ISNULL(ADOtherID, 0) AS BIT) AS ADOverall,\r\n       CAST(ISNULL(ADSquirrelsPlot1ID, 0) | ISNULL(ADDeerPlot1ID, 0) | ISNULL(ADRabBITsPlot1ID, 0) | ISNULL(ADOtherPlot1ID, 0) AS BIT) AS ADPlot1,\r\n       CAST(ISNULL(ADSquirrelsPlot2ID, 0) | ISNULL(ADDeerPlot2ID, 0) | ISNULL(ADRabBITsPlot2ID, 0) | ISNULL(ADOtherPlot2ID, 0) AS BIT) AS ADPlot2,\r\n       CAST(ISNULL(ADSquirrelsPlot3ID, 0) | ISNULL(ADDeerPlot3ID, 0) | ISNULL(ADRabBITsPlot3ID, 0) | ISNULL(ADOtherPlot3ID, 0) AS BIT) AS ADPlot3,\r\n       CAST(ISNULL(ADSquirrelsPlot4ID, 0) | ISNULL(ADDeerPlot4ID, 0) | ISNULL(ADRabBITsPlot4ID, 0) | ISNULL(ADOtherPlot4ID, 0) AS BIT) AS ADPlot4,\r\n       CAST(ISNULL(ADSquirrelsPlot5ID, 0) | ISNULL(ADDeerPlot5ID, 0) | ISNULL(ADRabBITsPlot5ID, 0) | ISNULL(ADOtherPlot5ID, 0) AS BIT) AS ADPlot5,\r\n       ADInterventionDesirable,\r\n       ADInterventionAchievable,\r\n       ADNotesActions,\r\n       CAST(ISNULL(IRhododendronID, 0) | ISNULL(IHimalayanBalsamID, 0) | ISNULL(IJapaneseKnotweedID, 0) | ISNULL(IOtherID, 0) AS BIT) AS IOverall,\r\n       CAST(ISNULL(IRhododendronPlot1ID, 0) | ISNULL(IHimalayanBalsamPlot1ID, 0) | ISNULL(IJapaneseKnotweedPlot1ID, 0) | ISNULL(IOtherPlot1ID, 0) AS BIT) AS IPlot1,\r\n       CAST(ISNULL(IRhododendronPlot2ID, 0) | ISNULL(IHimalayanBalsamPlot2ID, 0) | ISNULL(IJapaneseKnotweedPlot2ID, 0) | ISNULL(IOtherPlot2ID, 0) AS BIT) AS IPlot2,\r\n       CAST(ISNULL(IRhododendronPlot3ID, 0) | ISNULL(IHimalayanBalsamPlot3ID, 0) | ISNULL(IJapaneseKnotweedPlot3ID, 0) | ISNULL(IOtherPlot3ID, 0) AS BIT) AS IPlot3,\r\n       CAST(ISNULL(IRhododendronPlot4ID, 0) | ISNULL(IHimalayanBalsamPlot4ID, 0) | ISNULL(IJapaneseKnotweedPlot4ID, 0) | ISNULL(IOtherPlot4ID, 0) AS BIT) AS IPlot4,\r\n       CAST(ISNULL(IRhododendronPlot5ID, 0) | ISNULL(IHimalayanBalsamPlot5ID, 0) | ISNULL(IJapaneseKnotweedPlot5ID, 0) | ISNULL(IOtherPlot5ID, 0) AS BIT) AS IPlot5,\r\n       IInterventionDesirable,\r\n       IInterventionAchievable,\r\n       INotesActions,\r\n       CAST(ISNULL(THNotifiablePestOrDiseaseID, 0) | ISNULL(THOtherDiseaseOrPestID, 0) AS BIT) AS THOverall,\r\n       CAST(ISNULL(THNotifiablePestOrDiseasePlot1ID, 0) | ISNULL(THOtherDiseaseOrPestPlot1ID, 0) AS BIT) AS THPlot1,\r\n       CAST(ISNULL(THNotifiablePestOrDiseasePlot2ID, 0) | ISNULL(THOtherDiseaseOrPestPlot2ID, 0) AS BIT) AS THPlot2,\r\n       CAST(ISNULL(THNotifiablePestOrDiseasePlot3ID, 0) | ISNULL(THOtherDiseaseOrPestPlot3ID, 0) AS BIT) AS THPlot3,\r\n       CAST(ISNULL(THNotifiablePestOrDiseasePlot4ID, 0) | ISNULL(THOtherDiseaseOrPestPlot4ID, 0) AS BIT) AS THPlot4,\r\n       CAST(ISNULL(THNotifiablePestOrDiseasePlot5ID, 0) | ISNULL(THOtherDiseaseOrPestPlot5ID, 0) AS BIT) AS THPlot5,\r\n       THInterventionDesirable,\r\n       THInterventionAchievable,\r\n       THNotesActions,\r\n       CAST(ISNULL(HIOneOffImpactsID, 0) | ISNULL(HIContinuousImpactsID, 0) AS BIT) AS HIOverall,\r\n       CAST(ISNULL(HIOneOffImpactsPlot1ID, 0) | ISNULL(HIContinuousImpactsPlot1ID, 0) AS BIT) AS HIPlot1,\r\n       CAST(ISNULL(HIOneOffImpactsPlot2ID, 0) | ISNULL(HIContinuousImpactsPlot2ID, 0) AS BIT) AS HIPlot2,\r\n       CAST(ISNULL(HIOneOffImpactsPlot3ID, 0) | ISNULL(HIContinuousImpactsPlot3ID, 0) AS BIT) AS HIPlot3,\r\n       CAST(ISNULL(HIOneOffImpactsPlot4ID, 0) | ISNULL(HIContinuousImpactsPlot4ID, 0) AS BIT) AS HIPlot4,\r\n       CAST(ISNULL(HIOneOffImpactsPlot5ID, 0) | ISNULL(HIContinuousImpactsPlot5ID, 0) AS BIT) AS HIPlot5,\r\n       HIInterventionDesirable,\r\n       HIInterventionAchievable,\r\n       HINotesActions,\r\n       Deleted,\r\n       IsProtected,\r\n       IsHistorical,\r\n       IsDefaultValue,\r\n       LMDT,\r\n       LMUID,\r\n       CRDT,\r\n       CRUID,\r\n       DLDT,\r\n       DLUID\r\nFROM dbo.WoodlandConditionSubSection AS s";

            #endregion

         
            var returnList = new List<ConditionAssessmentListDTO>();
      
            var features = Context.Feature.Where(m => m.Reference == "F97" && !m.Deleted).ToList();

            var featureMonitoring = Context.FeatureMonitoring.Include(f=>f.Feature).Where(f=>f.Feature.Reference == "F97").ToList();

            var woodlandconditionsubsection = ExecSQL<WoodlandconditionsubsectionDTO>(magicString, Context);



            foreach (var v in _cache.ManagementUnitDtos.OrderBy(o => o.Name))
            {

                ConditionAssessmentListDTO cdass = new ConditionAssessmentListDTO();

              
                // get features for management unit
                var managementUnitFeatures = features.Where(m => m.ManagementUnitId == v.Id);


                int noInterventions = 0;
                int noDesirableInterventions = 0;
                int noTotalNoOfPlots = 0;
                int counditionCount = 0;
                bool wholeSite = false;
                int stratum = 0;
                //loop through features
                foreach (var feature in managementUnitFeatures)
                {

                    var featureMonitor =
                        featureMonitoring.Where(
                                fm => fm.FeatureId == feature.Id && fm.ActualObservationDate != null && !fm.Deleted)
                            .OrderBy(o => o.ActualObservationDate.GetValueOrDefault())
                            .FirstOrDefault();

                    counditionCount = featureMonitoring.Count(fm => fm.FeatureId == feature.Id && !fm.Deleted);

                    if (featureMonitor != null)
                    {
                        var subSections =
                            woodlandconditionsubsection.Where(w => w.FeatureMonitoringID == featureMonitor.Id);


                        foreach (var sub in subSections)
                        {


                            noInterventions = sub.GetAchievableInterventions();
                            noDesirableInterventions = sub.GetDesirableInterventions();
                            noTotalNoOfPlots = sub.GetTotalNoOfPlots();
                            wholeSite = sub.WholeSite;
                            stratum = sub.StratumID.GetValueOrDefault();
                        }

                    }
                    else
                    {
                        noInterventions = 0;
                        noDesirableInterventions = 0;
                        noTotalNoOfPlots = 0;
                    }
                }

                cdass.TotalNoOfPlots = noTotalNoOfPlots;
                cdass.DesirableInterventions = noDesirableInterventions;
                cdass.AchievableInterventions = noInterventions;
                cdass.NoOfConditionsAssessments = counditionCount;
                cdass.Name = v.Name == "" ? "Name not entered" : v.Name;
                cdass.CostCentre = v.Id;
                cdass.WholeSite = wholeSite;
                cdass.NoOfStrata = stratum;
                cdass.Region = RegionName(v.RegionId);
                cdass.RegionId = v.RegionId.GetValueOrDefault();
                cdass.WoodlandOfficerID = v.WoodlandOfficerId;
                cdass.DeputyID = v.DeputyId.GetValueOrDefault();
                cdass.ApplicationId = v.ApplicationId;
                cdass.Manager = UserName(v.WoodlandOfficerId);
                cdass.ManagementUnitID = v.Id;
                returnList.Add(cdass);
            }






            returnList = returnList.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList();


            return returnList;
        }

        public CafkfSummaries GetKfSummaries(int featureMonitoringID)
        {
            var result = new CafkfSummaries();

            var woodlandConditionSubSectionsExt = Context.WoodlandConditionExtension
                .Where(f => f.FeatureMonitoringId == featureMonitoringID)
                .Select(s => new WoodlandConditionExtension()
                {
                    Id = s.Id,    
                    ConclusionsAndRecommendations = s.ConclusionsAndRecommendations,
                    OverallDesirable = s.OverallDesirable,
                    OverallAchievable = s.OverallAchievable
                }).ToList();

            var woodlandConditionSubSections = Context.WoodlandConditionSubSection.Include(f => f.FeatureMonitoring)
                .ThenInclude(fe => fe.Feature).ThenInclude(fa => fa.Type).Where(w => !w.Deleted && w.FeatureMonitoringId == featureMonitoringID);


            var summaries = new List<CafkfSummary>();


            foreach (var condition in woodlandConditionSubSections)
            {
                summaries.Add(new CafkfSummary()
                {
                    WoodlandConditionSubSectionId = condition.Id,
                    OverallInterventionAchievable = condition.OverallInterventionAchievable.GetValueOrDefault(),
                    OverallInterventionDesirable = condition.OverallInterventionAchievable.GetValueOrDefault(),
                    OverallConclusionsAndRecommendations = condition.OverallConclusionsAndRecommendations,
                    Description = condition.StratumDescription
                });
            }

            result.SummariesList = summaries;

            result.OverallSummary = new CafkfSummary();

            if (woodlandConditionSubSectionsExt.Count > 0)
            {
                result.OverallSummary.OverallConclusionsAndRecommendations =
                    woodlandConditionSubSectionsExt[0].ConclusionsAndRecommendations;
                result.OverallSummary.OverallInterventionAchievable =
                    woodlandConditionSubSectionsExt[0].OverallAchievable;
                result.OverallSummary.OverallInterventionDesirable =
                    woodlandConditionSubSectionsExt[0].OverallDesirable;
            }

            return result;
        }
        public void UpdateCafkfSummaries(int Id, CafkfSummaries cafkfSummaries)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);



            throw new NotImplementedException();
        }


        public CAFOverallDTO GetCafOverallDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            if (con == null) con = new WoodlandConditionSubSection();

            var cafOverall = new CAFOverallDTO()
            {
               
                FeatureID = con.KeyFeatureId.GetValueOrDefault(),
                Notes = con.NotesAction,
                InterventionAchievable = con.InterventionAchievable.GetValueOrDefault(),
                InterventionDesirable = con.InterventionDesirable.GetValueOrDefault(),
                OpenSpaceRidesCurrent = con.OpenSpaceRidesPercentCurrent.GetValueOrDefault(),
                OpenSpaceRidesMax = con.OpenSpaceRidesPercentMax.GetValueOrDefault(),
                OpenSpaceRidesMin = con.OpenSpaceRidesPercentMin.GetValueOrDefault(),
                OpenSpaceSemiNaturalHabitatCurrent = con.OpenSpaceSemiNaturalHabitatPercentCurrent.GetValueOrDefault(),
                OpenSpaceSemiNaturalHabitatMax = con.OpenSpaceSemiNaturalHabitatPercentMax.GetValueOrDefault(),
                OpenSpaceSemiNaturalHabitatMin = con.OpenSpaceSemiNaturalHabitatPercentMin.GetValueOrDefault(),
                OpenSpaceTemporaryCurrent = con.OpenSpaceTemporaryPercentCurrent.GetValueOrDefault(),
                OpenSpaceTemporaryMax = con.OpenSpaceTemporaryPercentMax.GetValueOrDefault(),
                OpenSpaceTemporaryMin = con.OpenSpaceTemporaryPercentMin.GetValueOrDefault(),
                OpenSpaceWaterFeaturesCurrent = con.OpenSpaceWaterFeaturesPercentCurrent.GetValueOrDefault(),
                OpenSpaceWaterFeaturesMax = con.OpenSpaceWaterFeaturesPercentMax.GetValueOrDefault(),
                OpenSpaceWaterFeaturesMin = con.OpenSpaceWaterFeaturesPercentMin.GetValueOrDefault(),
                ShrubCoverCurrent = con.ShrubCoverPercentCurrent.GetValueOrDefault(),
                ShrubCoverMax = con.ShrubCoverPercentMax.GetValueOrDefault(),
                ShrubCoverMin = con.ShrubCoverPercentMin.GetValueOrDefault(),
                TotalOpenSpace = con.OpenSpaceSemiNaturalHabitatPercentCurrent.GetValueOrDefault() + con.OpenSpaceWaterFeaturesPercentCurrent.GetValueOrDefault(),
                TotalTreeCanopyOpenSpace = con.OpenSpaceSemiNaturalHabitatPercentCurrent.GetValueOrDefault()
                         + con.OpenSpaceWaterFeaturesPercentCurrent.GetValueOrDefault() + con.TotalTreeCanopyCoverPercentCurrent.GetValueOrDefault(),
                TotalTreeCanopyCoverCurrent = con.TotalTreeCanopyCoverPercentCurrent.GetValueOrDefault(),
                TotalTreeCanopyCoverMin = con.TotalTreeCanopyCoverPercentMin.GetValueOrDefault(),
                TotalTreeCanopyCoverMax = con.OpenSpaceTemporaryPercentMax.GetValueOrDefault()
            };


            return cafOverall;
        }

        public void UpdateCAFOverallDTO(int Id, CAFOverallDTO cafkfSummaries)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);


            //FeatureID = con.KeyFeatureId.GetValueOrDefault(),
            con.KeyFeatureId = cafkfSummaries.FeatureID == 0 ? null : (int?)cafkfSummaries.FeatureID;           
            //    Notes = con.NotesAction,
            con.NotesAction = cafkfSummaries.Notes;
            //    InterventionAchievable = con.InterventionAchievable.GetValueOrDefault(),
            con.InterventionAchievable = cafkfSummaries.InterventionAchievable;
            //    InterventionDesirable = con.InterventionDesirable.GetValueOrDefault(),
            con.InterventionDesirable = cafkfSummaries.InterventionDesirable;
            //    OpenSpaceRidesCurrent = con.OpenSpaceRidesPercentCurrent.GetValueOrDefault(),
            con.OpenSpaceRidesPercentCurrent = cafkfSummaries.OpenSpaceRidesCurrent;
            //    OpenSpaceRidesMax = con.OpenSpaceRidesPercentMax.GetValueOrDefault(),
            con.OpenSpaceRidesPercentMax = cafkfSummaries.OpenSpaceRidesMax;
            //    OpenSpaceRidesMin = con.OpenSpaceRidesPercentMin.GetValueOrDefault(),
            con.OpenSpaceRidesPercentMin = cafkfSummaries.OpenSpaceRidesMin;
            //    OpenSpaceSemiNaturalHabitatCurrent = con.OpenSpaceSemiNaturalHabitatPercentCurrent.GetValueOrDefault(),
            con.OpenSpaceSemiNaturalHabitatPercentCurrent = cafkfSummaries.OpenSpaceSemiNaturalHabitatCurrent;
            //    OpenSpaceSemiNaturalHabitatMax = con.OpenSpaceSemiNaturalHabitatPercentMax.GetValueOrDefault(),
            con.OpenSpaceSemiNaturalHabitatPercentMax = cafkfSummaries.OpenSpaceSemiNaturalHabitatMax;
            //    OpenSpaceSemiNaturalHabitatMin = con.OpenSpaceSemiNaturalHabitatPercentMin.GetValueOrDefault(),
            con.OpenSpaceSemiNaturalHabitatPercentMin = cafkfSummaries.OpenSpaceSemiNaturalHabitatMin;
            //    OpenSpaceTemporaryCurrent = con.OpenSpaceTemporaryPercentCurrent.GetValueOrDefault(),
            con.OpenSpaceTemporaryPercentCurrent = cafkfSummaries.OpenSpaceTemporaryCurrent;
            //    OpenSpaceTemporaryMax = con.OpenSpaceTemporaryPercentMax.GetValueOrDefault(),
            con.OpenSpaceTemporaryPercentMax = cafkfSummaries.OpenSpaceTemporaryMax;
            //    OpenSpaceTemporaryMin = con.OpenSpaceTemporaryPercentMin.GetValueOrDefault(),
            con.OpenSpaceTemporaryPercentMin = cafkfSummaries.OpenSpaceTemporaryMin;
            //    OpenSpaceWaterFeaturesCurrent = con.OpenSpaceWaterFeaturesPercentCurrent.GetValueOrDefault(),
            con.OpenSpaceWaterFeaturesPercentCurrent = cafkfSummaries.OpenSpaceWaterFeaturesCurrent;
            //    OpenSpaceWaterFeaturesMax = con.OpenSpaceWaterFeaturesPercentMax.GetValueOrDefault(),
            con.OpenSpaceWaterFeaturesPercentMax = cafkfSummaries.OpenSpaceWaterFeaturesCurrent;


            //    OpenSpaceWaterFeaturesMin = con.OpenSpaceWaterFeaturesPercentMin.GetValueOrDefault(),
            con.OpenSpaceWaterFeaturesPercentMin = cafkfSummaries.OpenSpaceWaterFeaturesMin;




            //    ShrubCoverCurrent = con.ShrubCoverPercentCurrent.GetValueOrDefault(),
            con.ShrubCoverPercentCurrent = cafkfSummaries.ShrubCoverCurrent;



            //    ShrubCoverMax = con.ShrubCoverPercentMax.GetValueOrDefault(),
            con.ShrubCoverPercentMax = cafkfSummaries.ShrubCoverMax;


            //    ShrubCoverMin = con.ShrubCoverPercentMin.GetValueOrDefault(),
            con.ShrubCoverPercentMin = cafkfSummaries.ShrubCoverMin;


            //    TotalOpenSpace = con.OpenSpaceSemiNaturalHabitatPercentCurrent.GetValueOrDefault() + con.OpenSpaceWaterFeaturesPercentCurrent.GetValueOrDefault(),
            con.OpenSpaceSemiNaturalHabitatPercentCurrent = cafkfSummaries.TotalOpenSpace;
           
            
            //    TotalTreeCanopyOpenSpace = con.OpenSpaceSemiNaturalHabitatPercentCurrent.GetValueOrDefault()
            //             + con.OpenSpaceWaterFeaturesPercentCurrent.GetValueOrDefault() + con.TotalTreeCanopyCoverPercentCurrent.GetValueOrDefault(),
           // con.OpenSpaceWaterFeaturesPercentMax = cafkfSummaries.OpenSpaceWaterFeaturesCurrent;
          

            //    TotalTreeCanopyCoverCurrent = con.TotalTreeCanopyCoverPercentCurrent.GetValueOrDefault(),
            con.TotalTreeCanopyCoverPercentCurrent = cafkfSummaries.TotalTreeCanopyCoverCurrent;
                       
            //    TotalTreeCanopyCoverMin = con.TotalTreeCanopyCoverPercentMin.GetValueOrDefault(),
            con.TotalTreeCanopyCoverPercentMin = cafkfSummaries.TotalTreeCanopyCoverMin;
          
            //    TotalTreeCanopyCoverMax = con.OpenSpaceTemporaryPercentMax.GetValueOrDefault()
            con.OpenSpaceTemporaryPercentMax = cafkfSummaries.TotalTreeCanopyCoverMax;

            Context.SaveChanges();
        }


        #region tree species

        public CATTreeSpeciesDTO GetCatTreeSpeciesDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
            if (con == null) con = new WoodlandConditionSubSection();
            var cafTreeSpecies = new CATTreeSpeciesDTO()
            {
                NativesNumberPresent = new CATPlotObj()
                {
                    //Overall = con.TsnativesNumberPresent.GetValueOrDefault(),
                    //Plot1 = con.TsnativesNumberPresentPlot1.GetValueOrDefault(),
                    //Plot2 = con.TsnativesNumberPresentPlot1.GetValueOrDefault(),
                    //Plot3 = con.TsnativesNumberPresentPlot1.GetValueOrDefault(),
                    //Plot4 = con.TsnativesNumberPresentPlot1.GetValueOrDefault(),
                    //Plot5 = con.TsnativesNumberPresentPlot1.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.TsnativesNumberPresent.GetValueOrDefault(), Value = con.TsnativesNumberPresent.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.TsnativesNumberPresentPlot1.GetValueOrDefault(), Value = con.TsnativesNumberPresentPlot1.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.TsnativesNumberPresentPlot2.GetValueOrDefault(), Value = con.TsnativesNumberPresentPlot2.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.TsnativesNumberPresentPlot3.GetValueOrDefault(), Value = con.TsnativesNumberPresentPlot3.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.TsnativesNumberPresentPlot4.GetValueOrDefault(), Value = con.TsnativesNumberPresentPlot4.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.TsnativesNumberPresentPlot5.GetValueOrDefault(), Value = con.TsnativesNumberPresentPlot5.GetValueOrDefault() },

                },
                NonNativesNumberPresent = new CATPlotObj()
                {
                    //Overall = con.TsnonNativesNumberPresent.GetValueOrDefault(),
                    //Plot1 = con.TsnonNativesNumberPresentPlot1.GetValueOrDefault(),
                    //Plot2 = con.TsnonNativesNumberPresentPlot2.GetValueOrDefault(),
                    //Plot3 = con.TsnonNativesNumberPresentPlot3.GetValueOrDefault(),
                    //Plot4 = con.TsnonNativesNumberPresentPlot4.GetValueOrDefault(),
                    //Plot5 = con.TsnonNativesNumberPresentPlot5.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.TsnonNativesNumberPresent.GetValueOrDefault(), Value = con.TsnonNativesNumberPresent.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.TsnonNativesNumberPresentPlot1.GetValueOrDefault(), Value = con.TsnonNativesNumberPresentPlot1.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.TsnonNativesNumberPresentPlot2.GetValueOrDefault(), Value = con.TsnonNativesNumberPresentPlot2.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.TsnonNativesNumberPresentPlot3.GetValueOrDefault(), Value = con.TsnonNativesNumberPresentPlot3.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.TsnonNativesNumberPresentPlot4.GetValueOrDefault(), Value = con.TsnonNativesNumberPresentPlot4.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.TsnonNativesNumberPresentPlot5.GetValueOrDefault(), Value = con.TsnonNativesNumberPresentPlot5.GetValueOrDefault() },


                },
                InterventionAchievable = con.InterventionAchievable.GetValueOrDefault(),
                InterventionDesirable = con.InterventionDesirable.GetValueOrDefault(),
                CanopyDominatedSpp = new CATPlotObjBool()
                {
                    //Overall = con.TscanopyDominatedByOneOrTwoSpp,
                    //Plot1 = con.TscanopyDominatedByOneOrTwoSppplot1,
                    //Plot2 = con.TscanopyDominatedByOneOrTwoSppplot2,
                    //Plot3 = con.TscanopyDominatedByOneOrTwoSppplot3,
                    //Plot4 = con.TscanopyDominatedByOneOrTwoSppplot4,
                    //Plot5 = con.TscanopyDominatedByOneOrTwoSppplot5

                    Overall = new Property<bool>() { Original = con.TscanopyDominatedByOneOrTwoSpp, Value = con.TscanopyDominatedByOneOrTwoSpp },
                    Plot1 = new Property<bool>() { Original = con.TscanopyDominatedByOneOrTwoSppplot1, Value = con.TscanopyDominatedByOneOrTwoSppplot1 },
                    Plot2 = new Property<bool>() { Original = con.TscanopyDominatedByOneOrTwoSppplot2, Value = con.TscanopyDominatedByOneOrTwoSppplot2 },
                    Plot3 = new Property<bool>() { Original = con.TscanopyDominatedByOneOrTwoSppplot3, Value = con.TscanopyDominatedByOneOrTwoSppplot3 },
                    Plot4 = new Property<bool>() { Original = con.TscanopyDominatedByOneOrTwoSppplot4, Value = con.TscanopyDominatedByOneOrTwoSppplot4 },
                    Plot5 = new Property<bool>() { Original = con.TscanopyDominatedByOneOrTwoSppplot5, Value = con.TscanopyDominatedByOneOrTwoSppplot5 },


                }

            };

            return cafTreeSpecies;
        }

        public void UpdateCATTreeSpeciesDTO(int Id, CATTreeSpeciesDTO cafkfSummaries)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            con.TsnotesActions = cafkfSummaries.Notes;
            con.TsinterventionAchievable = cafkfSummaries.InterventionAchievable;
            con.TsinterventionDesirable = cafkfSummaries.InterventionDesirable;

            con.TscanopyDominatedByOneOrTwoSpp = cafkfSummaries.CanopyDominatedSpp.Overall.Value;
            con.TscanopyDominatedByOneOrTwoSppplot1 = cafkfSummaries.CanopyDominatedSpp.Plot1.Value;
            con.TscanopyDominatedByOneOrTwoSppplot2 = cafkfSummaries.CanopyDominatedSpp.Plot2.Value;
            con.TscanopyDominatedByOneOrTwoSppplot3 = cafkfSummaries.CanopyDominatedSpp.Plot3.Value;
            con.TscanopyDominatedByOneOrTwoSppplot4 = cafkfSummaries.CanopyDominatedSpp.Plot4.Value;
            con.TscanopyDominatedByOneOrTwoSppplot5 = cafkfSummaries.CanopyDominatedSpp.Plot5.Value;

            con.TsnonNativesNumberPresent = cafkfSummaries.NonNativesNumberPresent.Overall.Value;
            con.TsnonNativesNumberPresentPlot1 = cafkfSummaries.NonNativesNumberPresent.Plot1.Value;
            con.TsnonNativesNumberPresentPlot2 = cafkfSummaries.NonNativesNumberPresent.Plot2.Value;
            con.TsnonNativesNumberPresentPlot3 = cafkfSummaries.NonNativesNumberPresent.Plot3.Value;
            con.TsnonNativesNumberPresentPlot4 = cafkfSummaries.NonNativesNumberPresent.Plot4.Value;
            con.TsnonNativesNumberPresentPlot5 = cafkfSummaries.NonNativesNumberPresent.Plot5.Value;

            con.TsnativesNumberPresent = cafkfSummaries.NativesNumberPresent.Overall.Value;
            con.TsnativesNumberPresentPlot1 = cafkfSummaries.NativesNumberPresent.Plot1.Value;
            con.TsnativesNumberPresentPlot2 = cafkfSummaries.NativesNumberPresent.Plot2.Value;
            con.TsnativesNumberPresentPlot3 = cafkfSummaries.NativesNumberPresent.Plot3.Value;
            con.TsnativesNumberPresentPlot4 = cafkfSummaries.NativesNumberPresent.Plot4.Value;
            con.TsnativesNumberPresentPlot5 = cafkfSummaries.NativesNumberPresent.Plot5.Value;

            Context.SaveChanges();
        }

        #endregion

        #region shrub species 

        public CATShrubSpeciesDTO GetCatShrubSpeciesDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
            if (con == null) con = new WoodlandConditionSubSection();
            var shrubspecies = new CATShrubSpeciesDTO()
            {
                NativesNumberPresent = new CATPlotObj()
                {                 
                    Overall = new Property<int>() { Original = con.SsnativesNumberPresent.GetValueOrDefault(), Value = con.SsnativesNumberPresent.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.SsnativesNumberPresentPlot1.GetValueOrDefault(), Value = con.SsnativesNumberPresentPlot1.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.SsnativesNumberPresentPlot2.GetValueOrDefault(), Value = con.SsnativesNumberPresentPlot2.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.SsnativesNumberPresentPlot3.GetValueOrDefault(), Value = con.SsnativesNumberPresentPlot3.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.SsnativesNumberPresentPlot4.GetValueOrDefault(), Value = con.SsnativesNumberPresentPlot4.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.SsnativesNumberPresentPlot5.GetValueOrDefault(), Value = con.SsnativesNumberPresentPlot5.GetValueOrDefault() },
                },
                NonNativesNumberPresent = new CATPlotObj()
                {                   
                    Overall = new Property<int>() { Original = con.SsnonNativesNumberPresent.GetValueOrDefault(), Value = con.SsnonNativesNumberPresent.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.SsnonNativesNumberPresentPlot1.GetValueOrDefault(), Value = con.SsnonNativesNumberPresentPlot1.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.SsnonNativesNumberPresentPlot2.GetValueOrDefault(), Value = con.SsnonNativesNumberPresentPlot2.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.SsnonNativesNumberPresentPlot3.GetValueOrDefault(), Value = con.SsnonNativesNumberPresentPlot3.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.SsnonNativesNumberPresentPlot4.GetValueOrDefault(), Value = con.SsnonNativesNumberPresentPlot4.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.SsnonNativesNumberPresentPlot5.GetValueOrDefault(), Value = con.SsnonNativesNumberPresentPlot5.GetValueOrDefault() },

                },
                Notes = con.SsnotesActions,
                InterventionDesirable = con.SsinterventionDesirable,
                InterventionAchievable = con.SsinterventionAchievable,
                DAFORCover = new CATPlotObj()
                {
                    //Overall = con.SsdaforofCoverId.GetValueOrDefault(),
                    //Plot1 = con.SsdaforofCoverPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.SsdaforofCoverPlot1Id.GetValueOrDefault(),
                    //Plot3 = con.SsdaforofCoverPlot1Id.GetValueOrDefault(),
                    //Plot4 = con.SsdaforofCoverPlot1Id.GetValueOrDefault(),
                    //Plot5 = con.SsdaforofCoverPlot1Id.GetValueOrDefault()

                    Overall = new Property<int>() { Original = con.SsdaforofCoverId.GetValueOrDefault(), Value = con.SsdaforofCoverId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.SsdaforofCoverPlot1Id.GetValueOrDefault(), Value = con.SsdaforofCoverPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.SsdaforofCoverPlot2Id.GetValueOrDefault(), Value = con.SsdaforofCoverPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.SsdaforofCoverPlot3Id.GetValueOrDefault(), Value = con.SsdaforofCoverPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.SsdaforofCoverPlot4Id.GetValueOrDefault(), Value = con.SsdaforofCoverPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.SsdaforofCoverPlot5Id.GetValueOrDefault(), Value = con.SsdaforofCoverPlot5Id.GetValueOrDefault() },

                },
                ShrubLayerDominatedByOneOrTwoSPP = new CATPlotObjBool()
                {
                    //Overall = con.SsshrubLayerDominatedByOneOrTwoSpp,
                    //Plot1 = con.SsshrubLayerDominatedByOneOrTwoSppplot1,
                    //Plot2 = con.SsshrubLayerDominatedByOneOrTwoSppplot2,
                    //Plot3 = con.SsshrubLayerDominatedByOneOrTwoSppplot3,
                    //Plot4 = con.SsshrubLayerDominatedByOneOrTwoSppplot4,
                    //Plot5 = con.SsshrubLayerDominatedByOneOrTwoSppplot5


                    Overall = new Property<bool>() { Original = con.SsshrubLayerDominatedByOneOrTwoSpp, Value = con.SsshrubLayerDominatedByOneOrTwoSpp },
                    Plot1 = new Property<bool>() { Original = con.SsshrubLayerDominatedByOneOrTwoSppplot1, Value = con.SsshrubLayerDominatedByOneOrTwoSppplot1 },
                    Plot2 = new Property<bool>() { Original = con.SsshrubLayerDominatedByOneOrTwoSppplot2, Value = con.SsshrubLayerDominatedByOneOrTwoSppplot2 },
                    Plot3 = new Property<bool>() { Original = con.SsshrubLayerDominatedByOneOrTwoSppplot3, Value = con.SsshrubLayerDominatedByOneOrTwoSppplot3 },
                    Plot4 = new Property<bool>() { Original = con.SsshrubLayerDominatedByOneOrTwoSppplot4, Value = con.SsshrubLayerDominatedByOneOrTwoSppplot4 },
                    Plot5 = new Property<bool>() { Original = con.SsshrubLayerDominatedByOneOrTwoSppplot5, Value = con.SsshrubLayerDominatedByOneOrTwoSppplot5 },
                }
            };

            return shrubspecies;

        }

        public void UpdateCATShrubSpeciesDTO(int Id, CATShrubSpeciesDTO cafkfSummaries)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            con.SsnativesNumberPresent = cafkfSummaries.NativesNumberPresent.Overall.Value;
            con.SsnativesNumberPresentPlot1 = cafkfSummaries.NativesNumberPresent.Plot1.Value;
            con.SsnativesNumberPresentPlot2 = cafkfSummaries.NativesNumberPresent.Plot2.Value;
            con.SsnativesNumberPresentPlot3 = cafkfSummaries.NativesNumberPresent.Plot3.Value;
            con.SsnativesNumberPresentPlot4 = cafkfSummaries.NativesNumberPresent.Plot4.Value;
            con.SsnativesNumberPresentPlot5 = cafkfSummaries.NativesNumberPresent.Plot5.Value;

            con.SsnonNativesNumberPresent = cafkfSummaries.NativesNumberPresent.Overall.Value;
            con.SsnonNativesNumberPresentPlot1 = cafkfSummaries.NonNativesNumberPresent.Plot1.Value;
            con.SsnonNativesNumberPresentPlot2 = cafkfSummaries.NonNativesNumberPresent.Plot2.Value;
            con.SsnonNativesNumberPresentPlot3 = cafkfSummaries.NonNativesNumberPresent.Plot3.Value;
            con.SsnonNativesNumberPresentPlot4 = cafkfSummaries.NonNativesNumberPresent.Plot4.Value;
            con.SsnonNativesNumberPresentPlot5 = cafkfSummaries.NonNativesNumberPresent.Plot5.Value;
            
            con.SsnotesActions = cafkfSummaries.Notes;            
            con.SsinterventionDesirable = cafkfSummaries.InterventionDesirable;            
            con.SsinterventionAchievable = cafkfSummaries.InterventionAchievable;

            con.SsdaforofCoverId = cafkfSummaries.DAFORCover.Overall.Value;
            con.SsdaforofCoverPlot1Id = cafkfSummaries.DAFORCover.Plot1.Value;
            con.SsdaforofCoverPlot2Id = cafkfSummaries.DAFORCover.Plot2.Value;
            con.SsdaforofCoverPlot3Id = cafkfSummaries.DAFORCover.Plot3.Value;
            con.SsdaforofCoverPlot4Id = cafkfSummaries.DAFORCover.Plot4.Value;
            con.SsdaforofCoverPlot5Id = cafkfSummaries.DAFORCover.Plot5.Value;


            con.SsshrubLayerDominatedByOneOrTwoSpp = cafkfSummaries.ShrubLayerDominatedByOneOrTwoSPP.Overall.Value;
            con.SsshrubLayerDominatedByOneOrTwoSppplot1 = cafkfSummaries.ShrubLayerDominatedByOneOrTwoSPP.Plot1.Value;
            con.SsshrubLayerDominatedByOneOrTwoSppplot2 = cafkfSummaries.ShrubLayerDominatedByOneOrTwoSPP.Plot2.Value;
            con.SsshrubLayerDominatedByOneOrTwoSppplot3 = cafkfSummaries.ShrubLayerDominatedByOneOrTwoSPP.Plot3.Value;
            con.SsshrubLayerDominatedByOneOrTwoSppplot4 = cafkfSummaries.ShrubLayerDominatedByOneOrTwoSPP.Plot4.Value;
            con.SsshrubLayerDominatedByOneOrTwoSppplot5 = cafkfSummaries.ShrubLayerDominatedByOneOrTwoSPP.Plot5.Value;

            Context.SaveChanges();
        }

        #endregion

        #region level shrub regeneration

        public CATLevelOfShrubRegenerationDTO GetCatLevelOfShrubRegenerationDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
            if (con == null) con = new WoodlandConditionSubSection();

            var catLevelOfShrubRegenerationDTO = new CATLevelOfShrubRegenerationDTO()
            {
                SeedlingsLessTen = new CATPlotObj()
                {
                    //Overall = con.LsrseedlingsLess10cmId.GetValueOrDefault(),
                    //Plot1 = con.Ta2050yearsId.GetValueOrDefault(),
                    //Plot2 = con.Ta2050yearsId.GetValueOrDefault(),
                    //Plot3 = con.Ta2050yearsId.GetValueOrDefault(),
                    //Plot4 = con.Ta2050yearsId.GetValueOrDefault(),
                    //Plot5 = con.Ta2050yearsId.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.LsrseedlingsLess10cmId.GetValueOrDefault(), Value = con.LsrseedlingsLess10cmId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.LsrseedlingsLess10cmPlot1Id.GetValueOrDefault(), Value = con.LsrseedlingsLess10cmPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.LsrseedlingsLess10cmPlot2Id.GetValueOrDefault(), Value = con.LsrseedlingsLess10cmPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.LsrseedlingsLess10cmPlot3Id.GetValueOrDefault(), Value = con.LsrseedlingsLess10cmPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.LsrseedlingsLess10cmPlot4Id.GetValueOrDefault(), Value = con.LsrseedlingsLess10cmPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.LsrseedlingsLess10cmPlot5Id.GetValueOrDefault(), Value = con.LsrseedlingsLess10cmPlot5Id.GetValueOrDefault() },

                },
                SeedlingsTenHundred = new CATPlotObj()
                {
                    //Overall = con.Ltrseedlings10100cmId.GetValueOrDefault(),
                    //Plot1 = con.Ltrseedlings10100cmPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.Ltrseedlings10100cmPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.Ltrseedlings10100cmPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.Ltrseedlings10100cmPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.Ltrseedlings10100cmPlot5Id.GetValueOrDefault(),


                    Overall = new Property<int>() { Original = con.Ltrseedlings10100cmId.GetValueOrDefault(), Value = con.Ltrseedlings10100cmId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.Ltrseedlings10100cmPlot1Id.GetValueOrDefault(), Value = con.Ltrseedlings10100cmPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.Ltrseedlings10100cmPlot2Id.GetValueOrDefault(), Value = con.Ltrseedlings10100cmPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.Ltrseedlings10100cmPlot3Id.GetValueOrDefault(), Value = con.Ltrseedlings10100cmPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.Ltrseedlings10100cmPlot4Id.GetValueOrDefault(), Value = con.Ltrseedlings10100cmPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.Ltrseedlings10100cmPlot5Id.GetValueOrDefault(), Value = con.Ltrseedlings10100cmPlot5Id.GetValueOrDefault() },
                },
                CoppiceRegrowthOrSuckering = new CATPlotObj()
                {
                    //Overall = con.LtrcoppiceRegrowthOrSuckeringId.GetValueOrDefault(),
                    //Plot1 = con.LtrcoppiceRegrowthOrSuckeringPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.LtrcoppiceRegrowthOrSuckeringPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.LtrcoppiceRegrowthOrSuckeringPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.LtrcoppiceRegrowthOrSuckeringPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.LtrcoppiceRegrowthOrSuckeringPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.LtrcoppiceRegrowthOrSuckeringId.GetValueOrDefault(), Value = con.LtrcoppiceRegrowthOrSuckeringId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.LtrcoppiceRegrowthOrSuckeringPlot1Id.GetValueOrDefault(), Value = con.LtrcoppiceRegrowthOrSuckeringPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.LtrcoppiceRegrowthOrSuckeringPlot2Id.GetValueOrDefault(), Value = con.LtrcoppiceRegrowthOrSuckeringPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.LtrcoppiceRegrowthOrSuckeringPlot3Id.GetValueOrDefault(), Value = con.LtrcoppiceRegrowthOrSuckeringPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.LtrcoppiceRegrowthOrSuckeringPlot4Id.GetValueOrDefault(), Value = con.LtrcoppiceRegrowthOrSuckeringPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.LtrcoppiceRegrowthOrSuckeringPlot5Id.GetValueOrDefault(), Value = con.LtrcoppiceRegrowthOrSuckeringPlot5Id.GetValueOrDefault() },
                },
                SeedlingsGreaterHundred = new CATPlotObj()
                {
                    //Overall = con.LtrsaplingsGreater100cmId.GetValueOrDefault(),
                    //Plot1 = con.LtrsaplingsGreater100cmPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.LtrsaplingsGreater100cmPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.LtrsaplingsGreater100cmPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.LtrsaplingsGreater100cmPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.LtrsaplingsGreater100cmPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.LtrsaplingsGreater100cmId.GetValueOrDefault(), Value = con.LtrsaplingsGreater100cmId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.LtrsaplingsGreater100cmPlot1Id.GetValueOrDefault(), Value = con.LtrsaplingsGreater100cmPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.LtrsaplingsGreater100cmPlot2Id.GetValueOrDefault(), Value = con.LtrsaplingsGreater100cmPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.LtrsaplingsGreater100cmPlot3Id.GetValueOrDefault(), Value = con.LtrsaplingsGreater100cmPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.LtrsaplingsGreater100cmPlot4Id.GetValueOrDefault(), Value = con.LtrsaplingsGreater100cmPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.LtrsaplingsGreater100cmPlot5Id.GetValueOrDefault(), Value = con.LtrsaplingsGreater100cmPlot5Id.GetValueOrDefault() },
                },
                Notes = con.LtrnotesActions,
                InterventionDesirable = con.LtrinterventionAchievable,
                InterventionAchievable = con.LtrinterventionDesirable,
            };

            return catLevelOfShrubRegenerationDTO;
        }
        public void UpdateCATLevelOfShrubRegenerationDTO(int Id, CATLevelOfShrubRegenerationDTO cafkfSummaries)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            con.LsrnotesActions = cafkfSummaries.Notes;
            con.LsrinterventionAchievable = cafkfSummaries.InterventionAchievable;
            con.LsrinterventionDesirable = cafkfSummaries.InterventionDesirable;

            con.LsrseedlingsLess10cmId = cafkfSummaries.SeedlingsLessTen.Overall.Value;
            con.LsrseedlingsLess10cmPlot1Id = cafkfSummaries.SeedlingsLessTen.Plot1.Value;
            con.LsrseedlingsLess10cmPlot2Id = cafkfSummaries.SeedlingsLessTen.Plot2.Value;
            con.LsrseedlingsLess10cmPlot3Id = cafkfSummaries.SeedlingsLessTen.Plot3.Value;
            con.LsrseedlingsLess10cmPlot4Id = cafkfSummaries.SeedlingsLessTen.Plot4.Value;
            con.LsrseedlingsLess10cmPlot5Id = cafkfSummaries.SeedlingsLessTen.Plot5.Value;

            //Ltrseedlings10100cmId
            con.Ltrseedlings10100cmId = cafkfSummaries.SeedlingsTenHundred.Overall.Value;
            con.Ltrseedlings10100cmPlot1Id = cafkfSummaries.SeedlingsTenHundred.Plot1.Value;
            con.Ltrseedlings10100cmPlot2Id = cafkfSummaries.SeedlingsTenHundred.Plot2.Value;
            con.Ltrseedlings10100cmPlot3Id = cafkfSummaries.SeedlingsTenHundred.Plot3.Value;
            con.Ltrseedlings10100cmPlot4Id = cafkfSummaries.SeedlingsTenHundred.Plot4.Value;
            con.Ltrseedlings10100cmPlot5Id = cafkfSummaries.SeedlingsTenHundred.Plot5.Value;

            //LtrcoppiceRegrowthOrSuckeringId            
            con.LtrcoppiceRegrowthOrSuckeringId = cafkfSummaries.CoppiceRegrowthOrSuckering.Overall.Value;
            con.LtrcoppiceRegrowthOrSuckeringPlot1Id = cafkfSummaries.CoppiceRegrowthOrSuckering.Plot1.Value;
            con.LtrcoppiceRegrowthOrSuckeringPlot2Id = cafkfSummaries.CoppiceRegrowthOrSuckering.Plot2.Value;
            con.LtrcoppiceRegrowthOrSuckeringPlot3Id = cafkfSummaries.CoppiceRegrowthOrSuckering.Plot3.Value;
            con.LtrcoppiceRegrowthOrSuckeringPlot4Id = cafkfSummaries.CoppiceRegrowthOrSuckering.Plot4.Value;
            con.LtrcoppiceRegrowthOrSuckeringPlot5Id = cafkfSummaries.CoppiceRegrowthOrSuckering.Plot5.Value;


            //LtrsaplingsGreater100cmId
            con.LtrsaplingsGreater100cmId = cafkfSummaries.SeedlingsGreaterHundred.Overall.Value;
            con.LtrsaplingsGreater100cmPlot1Id = cafkfSummaries.SeedlingsGreaterHundred.Plot1.Value;
            con.LtrsaplingsGreater100cmPlot2Id = cafkfSummaries.SeedlingsGreaterHundred.Plot2.Value;
            con.LtrsaplingsGreater100cmPlot3Id = cafkfSummaries.SeedlingsGreaterHundred.Plot3.Value;
            con.LtrsaplingsGreater100cmPlot4Id = cafkfSummaries.SeedlingsGreaterHundred.Plot4.Value;
            con.LtrsaplingsGreater100cmPlot5Id = cafkfSummaries.SeedlingsGreaterHundred.Plot5.Value;


            Context.SaveChanges();
        }

        #endregion

        #region level of tree regeneration

        public CATLevelOfTreeRegenerationDTO GetCatLevelOfTreeRegenerationDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
            if (con == null) con = new WoodlandConditionSubSection();
            var cafTreeRegeneration = new CATLevelOfTreeRegenerationDTO()
            {
                SeedlingsLessTen = new CATPlotObj()
                {
                    //Overall = con.LtrseedlingsLess10cmId.GetValueOrDefault(),
                    //Plot1 = con.LtrseedlingsLess10cmPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.LtrseedlingsLess10cmPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.LtrseedlingsLess10cmPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.LtrseedlingsLess10cmPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.LtrseedlingsLess10cmPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.LtrseedlingsLess10cmId.GetValueOrDefault(), Value = con.LtrseedlingsLess10cmId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.LtrseedlingsLess10cmPlot1Id.GetValueOrDefault(), Value = con.LtrseedlingsLess10cmPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.LtrseedlingsLess10cmPlot2Id.GetValueOrDefault(), Value = con.LtrseedlingsLess10cmPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.LtrseedlingsLess10cmPlot3Id.GetValueOrDefault(), Value = con.LtrseedlingsLess10cmPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.LtrseedlingsLess10cmPlot4Id.GetValueOrDefault(), Value = con.LtrseedlingsLess10cmPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.LtrseedlingsLess10cmPlot5Id.GetValueOrDefault(), Value = con.LtrseedlingsLess10cmPlot5Id.GetValueOrDefault() },

                },
                SeedlingsTenHundred = new CATPlotObj()
                {
                    //Overall = con.Ltrseedlings10100cmId.GetValueOrDefault(),
                    //Plot1 = con.Ltrseedlings10100cmPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.Ltrseedlings10100cmPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.Ltrseedlings10100cmPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.Ltrseedlings10100cmPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.Ltrseedlings10100cmPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.Ltrseedlings10100cmId.GetValueOrDefault(), Value = con.Ltrseedlings10100cmId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.Ltrseedlings10100cmPlot1Id.GetValueOrDefault(), Value = con.Ltrseedlings10100cmPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.Ltrseedlings10100cmPlot2Id.GetValueOrDefault(), Value = con.Ltrseedlings10100cmPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.Ltrseedlings10100cmPlot3Id.GetValueOrDefault(), Value = con.Ltrseedlings10100cmPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.Ltrseedlings10100cmPlot4Id.GetValueOrDefault(), Value = con.Ltrseedlings10100cmPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.Ltrseedlings10100cmPlot5Id.GetValueOrDefault(), Value = con.Ltrseedlings10100cmPlot5Id.GetValueOrDefault() },

                },
                CoppiceRegrowthOrSuckering = new CATPlotObj()
                {
                    //Overall = con.LtrcoppiceRegrowthOrSuckeringId.GetValueOrDefault(),
                    //Plot1 = con.LtrcoppiceRegrowthOrSuckeringPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.LtrcoppiceRegrowthOrSuckeringPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.LtrcoppiceRegrowthOrSuckeringPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.LtrcoppiceRegrowthOrSuckeringPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.LtrcoppiceRegrowthOrSuckeringPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.LtrcoppiceRegrowthOrSuckeringId.GetValueOrDefault(), Value = con.LtrcoppiceRegrowthOrSuckeringId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.LtrcoppiceRegrowthOrSuckeringPlot1Id.GetValueOrDefault(), Value = con.LtrcoppiceRegrowthOrSuckeringPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.LtrcoppiceRegrowthOrSuckeringPlot2Id.GetValueOrDefault(), Value = con.LtrcoppiceRegrowthOrSuckeringPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.LtrcoppiceRegrowthOrSuckeringPlot3Id.GetValueOrDefault(), Value = con.LtrcoppiceRegrowthOrSuckeringPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.LtrcoppiceRegrowthOrSuckeringPlot4Id.GetValueOrDefault(), Value = con.LtrcoppiceRegrowthOrSuckeringPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.LtrcoppiceRegrowthOrSuckeringPlot5Id.GetValueOrDefault(), Value = con.LtrcoppiceRegrowthOrSuckeringPlot5Id.GetValueOrDefault() },

                },
                SeedlingsGreaterHundred = new CATPlotObj()
                {
                    //Overall = con.LtrsaplingsGreater100cmId.GetValueOrDefault(),
                    //Plot1 = con.LtrsaplingsGreater100cmPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.LtrsaplingsGreater100cmPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.LtrsaplingsGreater100cmPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.LtrsaplingsGreater100cmPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.LtrsaplingsGreater100cmPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.LtrsaplingsGreater100cmId.GetValueOrDefault(), Value = con.LtrsaplingsGreater100cmId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.LtrsaplingsGreater100cmPlot1Id.GetValueOrDefault(), Value = con.LtrsaplingsGreater100cmPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.LtrsaplingsGreater100cmPlot2Id.GetValueOrDefault(), Value = con.LtrsaplingsGreater100cmPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.LtrsaplingsGreater100cmPlot3Id.GetValueOrDefault(), Value = con.LtrsaplingsGreater100cmPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.LtrsaplingsGreater100cmPlot4Id.GetValueOrDefault(), Value = con.LtrsaplingsGreater100cmPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.LtrsaplingsGreater100cmPlot5Id.GetValueOrDefault(), Value = con.LtrsaplingsGreater100cmPlot5Id.GetValueOrDefault() },



                },
                Notes = con.LtrnotesActions,
                InterventionDesirable = con.LtrinterventionDesirable,
                InterventionAchievable = con.LtrinterventionAchievable,

            };

            return cafTreeRegeneration;
        }

        public void UpdateCATLevelOfTreeRegenerationDTO(int Id, CATLevelOfTreeRegenerationDTO cafkfSummaries)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            con.LtrnotesActions = cafkfSummaries.Notes;
            con.LtrinterventionAchievable = cafkfSummaries.InterventionAchievable;
            con.LtrinterventionDesirable = cafkfSummaries.InterventionDesirable;


            //LtrseedlingsLess10cmId      
            con.LtrseedlingsLess10cmId = cafkfSummaries.SeedlingsLessTen.Overall.Value;
            con.LtrseedlingsLess10cmPlot1Id = cafkfSummaries.SeedlingsLessTen.Plot1.Value;
            con.LtrseedlingsLess10cmPlot2Id = cafkfSummaries.SeedlingsLessTen.Plot2.Value;
            con.LtrseedlingsLess10cmPlot3Id = cafkfSummaries.SeedlingsLessTen.Plot3.Value;
            con.LtrseedlingsLess10cmPlot4Id = cafkfSummaries.SeedlingsLessTen.Plot4.Value;
            con.LtrseedlingsLess10cmPlot5Id = cafkfSummaries.SeedlingsLessTen.Plot5.Value;

            //Ltrseedlings10100cmId
            con.Ltrseedlings10100cmId = cafkfSummaries.SeedlingsTenHundred.Overall.Value;
            con.Ltrseedlings10100cmPlot1Id = cafkfSummaries.SeedlingsTenHundred.Plot1.Value;
            con.Ltrseedlings10100cmPlot2Id = cafkfSummaries.SeedlingsTenHundred.Plot2.Value;
            con.Ltrseedlings10100cmPlot3Id = cafkfSummaries.SeedlingsTenHundred.Plot3.Value;
            con.Ltrseedlings10100cmPlot4Id = cafkfSummaries.SeedlingsTenHundred.Plot4.Value;
            con.Ltrseedlings10100cmPlot5Id = cafkfSummaries.SeedlingsTenHundred.Plot5.Value;


            //LtrcoppiceRegrowthOrSuckeringId
            con.LtrcoppiceRegrowthOrSuckeringId = cafkfSummaries.CoppiceRegrowthOrSuckering.Overall.Value;
            con.LtrcoppiceRegrowthOrSuckeringPlot1Id = cafkfSummaries.CoppiceRegrowthOrSuckering.Plot1.Value;
            con.LtrcoppiceRegrowthOrSuckeringPlot2Id = cafkfSummaries.CoppiceRegrowthOrSuckering.Plot2.Value;
            con.LtrcoppiceRegrowthOrSuckeringPlot3Id = cafkfSummaries.CoppiceRegrowthOrSuckering.Plot3.Value;
            con.LtrcoppiceRegrowthOrSuckeringPlot4Id = cafkfSummaries.CoppiceRegrowthOrSuckering.Plot4.Value;
            con.LtrcoppiceRegrowthOrSuckeringPlot5Id = cafkfSummaries.CoppiceRegrowthOrSuckering.Plot5.Value;

            //LtrsaplingsGreater100cmId

            con.LtrsaplingsGreater100cmId = cafkfSummaries.SeedlingsGreaterHundred.Overall.Value;
            con.LtrsaplingsGreater100cmPlot1Id = cafkfSummaries.SeedlingsGreaterHundred.Plot1.Value;
            con.LtrsaplingsGreater100cmPlot2Id = cafkfSummaries.SeedlingsGreaterHundred.Plot2.Value;
            con.LtrsaplingsGreater100cmPlot3Id = cafkfSummaries.SeedlingsGreaterHundred.Plot3.Value;
            con.LtrsaplingsGreater100cmPlot4Id = cafkfSummaries.SeedlingsGreaterHundred.Plot4.Value;
            con.LtrsaplingsGreater100cmPlot5Id = cafkfSummaries.SeedlingsGreaterHundred.Plot5.Value;


            Context.SaveChanges();
        }

        #endregion

        #region regeneration tree species

        public CATRegenerationTreeSpeciesDTO GetCatRegenerationTreeSpeciesDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
            if (con == null) con = new WoodlandConditionSubSection();

            var catRegenerationTreeSpeciesDTO = new CATRegenerationTreeSpeciesDTO()
            {

                Notes = con.NotesAction,
                InterventionAchievable = con.RtsinterventionAchievable,
                InterventionDesirable = con.RtsinterventionDesirable,
                NonNativesNumberPresent = new CATPlotObj()
                {
                    //Overall = con.RtsnonNativesNumberPresent.GetValueOrDefault(),
                    //Plot1 = con.RtsnonNativesNumberPresentPlot1.GetValueOrDefault(),
                    //Plot2 = con.RtsnonNativesNumberPresentPlot2.GetValueOrDefault(),
                    //Plot3 = con.RtsnonNativesNumberPresentPlot3.GetValueOrDefault(),
                    //Plot4 = con.RtsnonNativesNumberPresentPlot4.GetValueOrDefault(),
                    //Plot5 = con.RtsnonNativesNumberPresentPlot5.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.RtsnonNativesNumberPresent.GetValueOrDefault(), Value = con.RtsnonNativesNumberPresent.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.RtsnonNativesNumberPresentPlot1.GetValueOrDefault(), Value = con.RtsnonNativesNumberPresentPlot1.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.RtsnonNativesNumberPresentPlot2.GetValueOrDefault(), Value = con.RtsnonNativesNumberPresentPlot2.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.RtsnonNativesNumberPresentPlot3.GetValueOrDefault(), Value = con.RtsnonNativesNumberPresentPlot3.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.RtsnonNativesNumberPresentPlot4.GetValueOrDefault(), Value = con.RtsnonNativesNumberPresentPlot4.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.RtsnonNativesNumberPresentPlot5.GetValueOrDefault(), Value = con.RtsnonNativesNumberPresentPlot5.GetValueOrDefault() },


                },

                DominatedByOneOrTwoSPP = new CATPlotObjBool()
                {
                    //Overall = con.RtsdominatedByOneOrTwoSpp,
                    //Plot1 = con.RtsdominatedByOneOrTwoSppplot1,
                    //Plot2 = con.RtsdominatedByOneOrTwoSppplot2,
                    //Plot3 = con.RtsdominatedByOneOrTwoSppplot3,
                    //Plot4 = con.RtsdominatedByOneOrTwoSppplot4,
                    //Plot5 = con.RtsdominatedByOneOrTwoSppplot5

                    Overall = new Property<bool>() { Original = con.RtsdominatedByOneOrTwoSpp, Value = con.RtsdominatedByOneOrTwoSpp },
                    Plot1 = new Property<bool>() { Original = con.RtsdominatedByOneOrTwoSppplot1, Value = con.RtsdominatedByOneOrTwoSppplot1 },
                    Plot2 = new Property<bool>() { Original = con.RtsdominatedByOneOrTwoSppplot2, Value = con.RtsdominatedByOneOrTwoSppplot2 },
                    Plot3 = new Property<bool>() { Original = con.RtsdominatedByOneOrTwoSppplot3, Value = con.RtsdominatedByOneOrTwoSppplot3 },
                    Plot4 = new Property<bool>() { Original = con.RtsdominatedByOneOrTwoSppplot4, Value = con.RtsdominatedByOneOrTwoSppplot4 },
                    Plot5 = new Property<bool>() { Original = con.RtsdominatedByOneOrTwoSppplot5, Value = con.RtsdominatedByOneOrTwoSppplot5 },
                },

                NativesNumberPresent = new CATPlotObj()
                {
                    //Overall = Convert.ToInt32(con.RtsnativesNumberPresent),
                    //Plot1 = Convert.ToInt32(con.RtsnativesNumberPresentPlot1),
                    //Plot2 = Convert.ToInt32(con.RtsnativesNumberPresentPlot2),
                    //Plot3 = Convert.ToInt32(con.RtsnativesNumberPresentPlot3),
                    //Plot4 = Convert.ToInt32(con.RtsnativesNumberPresentPlot4),
                    //Plot5 = Convert.ToInt32(con.RtsnativesNumberPresentPlot5),

                    Overall = new Property<int>() { Original = con.RtsnativesNumberPresent.GetValueOrDefault(), Value = con.RtsnativesNumberPresent.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.RtsnativesNumberPresentPlot1.GetValueOrDefault(), Value = con.RtsnativesNumberPresentPlot1.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.RtsnativesNumberPresentPlot2.GetValueOrDefault(), Value = con.RtsnativesNumberPresentPlot2.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.RtsnativesNumberPresentPlot3.GetValueOrDefault(), Value = con.RtsnativesNumberPresentPlot3.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.RtsnativesNumberPresentPlot4.GetValueOrDefault(), Value = con.RtsnativesNumberPresentPlot4.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.RtsnativesNumberPresentPlot5.GetValueOrDefault(), Value = con.RtsnativesNumberPresentPlot5.GetValueOrDefault() },

                }
            };

            return catRegenerationTreeSpeciesDTO;
        }

        public void UpdateCATRegenerationTreeSpeciesDTO(int Id, CATRegenerationTreeSpeciesDTO cafkfSummaries)
        {       
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            con.RtsnotesActions = cafkfSummaries.Notes;
            con.RtsinterventionAchievable = cafkfSummaries.InterventionAchievable;
            con.RtsinterventionDesirable = cafkfSummaries.InterventionDesirable;

            con.RtsnonNativesNumberPresent = cafkfSummaries.NonNativesNumberPresent.Overall.Value;
            con.RtsnonNativesNumberPresentPlot1 = cafkfSummaries.NonNativesNumberPresent.Plot1.Value;
            con.RtsnonNativesNumberPresentPlot2 = cafkfSummaries.NonNativesNumberPresent.Plot2.Value;
            con.RtsnonNativesNumberPresentPlot3 = cafkfSummaries.NonNativesNumberPresent.Plot3.Value;
            con.RtsnonNativesNumberPresentPlot4 = cafkfSummaries.NonNativesNumberPresent.Plot4.Value;
            con.RtsnonNativesNumberPresentPlot5 = cafkfSummaries.NonNativesNumberPresent.Plot5.Value;

            con.RtsdominatedByOneOrTwoSpp = cafkfSummaries.DominatedByOneOrTwoSPP.Overall.Value;
            con.RtsdominatedByOneOrTwoSppplot1 = cafkfSummaries.DominatedByOneOrTwoSPP.Plot1.Value;
            con.RtsdominatedByOneOrTwoSppplot2 = cafkfSummaries.DominatedByOneOrTwoSPP.Plot2.Value;
            con.RtsdominatedByOneOrTwoSppplot3 = cafkfSummaries.DominatedByOneOrTwoSPP.Plot3.Value;
            con.RtsdominatedByOneOrTwoSppplot4 = cafkfSummaries.DominatedByOneOrTwoSPP.Plot4.Value;
            con.RtsdominatedByOneOrTwoSppplot5 = cafkfSummaries.DominatedByOneOrTwoSPP.Plot5.Value;

            con.RtsnativesNumberPresent = cafkfSummaries.NativesNumberPresent.Overall.Value;
            con.RtsnativesNumberPresentPlot1 = cafkfSummaries.NativesNumberPresent.Plot1.Value;
            con.RtsnativesNumberPresentPlot2 = cafkfSummaries.NativesNumberPresent.Plot2.Value;
            con.RtsnativesNumberPresentPlot3 = cafkfSummaries.NativesNumberPresent.Plot3.Value;
            con.RtsnativesNumberPresentPlot4 = cafkfSummaries.NativesNumberPresent.Plot4.Value;
            con.RtsnativesNumberPresentPlot5 = cafkfSummaries.NativesNumberPresent.Plot5.Value;


            Context.SaveChanges();
        }

        #endregion

        #region regeneration shrub species

        public CATRegenerationTreeSpeciesDTO GetCatRegenerationShrubSpeciesDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
            if (con == null) con = new WoodlandConditionSubSection();

            var catRegenerationShrubSpeciesDTO = new CATRegenerationTreeSpeciesDTO()
            {

                Notes = con.NotesAction,
                InterventionAchievable = con.RssinterventionAchievable,
                InterventionDesirable = con.RssinterventionDesirable,

                NonNativesNumberPresent = new CATPlotObj()
                {
                    //Overall = con.RssnonNativesNumberPresent.GetValueOrDefault(),
                    //Plot1 = con.RssnonNativesNumberPresentPlot1.GetValueOrDefault(),
                    //Plot2 = con.RssnonNativesNumberPresentPlot2.GetValueOrDefault(),
                    //Plot3 = con.RssnonNativesNumberPresentPlot3.GetValueOrDefault(),
                    //Plot4 = con.RssnonNativesNumberPresentPlot4.GetValueOrDefault(),
                    //Plot5 = con.RssnonNativesNumberPresentPlot5.GetValueOrDefault(),


                    Overall = new Property<int>() { Original = con.RssnonNativesNumberPresent.GetValueOrDefault(), Value = con.RssnonNativesNumberPresent.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.RssnonNativesNumberPresentPlot1.GetValueOrDefault(), Value = con.RssnonNativesNumberPresentPlot1.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.RssnonNativesNumberPresentPlot2.GetValueOrDefault(), Value = con.RssnonNativesNumberPresentPlot2.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.RssnonNativesNumberPresentPlot3.GetValueOrDefault(), Value = con.RssnonNativesNumberPresentPlot3.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.RssnonNativesNumberPresentPlot4.GetValueOrDefault(), Value = con.RssnonNativesNumberPresentPlot4.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.RssnonNativesNumberPresentPlot5.GetValueOrDefault(), Value = con.RssnonNativesNumberPresentPlot5.GetValueOrDefault() },

                },

                DominatedByOneOrTwoSPP = new CATPlotObjBool()
                {
                    //Overall = con.RssdominatedByOneOrTwoSpp,
                    //Plot1 = con.RssdominatedByOneOrTwoSppplot1,
                    //Plot2 = con.RssdominatedByOneOrTwoSppplot2,
                    //Plot3 = con.RssdominatedByOneOrTwoSppplot3,
                    //Plot4 = con.RssdominatedByOneOrTwoSppplot4,
                    //Plot5 = con.RssdominatedByOneOrTwoSppplot5

                    Overall = new Property<bool>() { Original = con.RssdominatedByOneOrTwoSpp, Value = con.RtsdominatedByOneOrTwoSpp },
                    Plot1 = new Property<bool>() { Original = con.RssdominatedByOneOrTwoSppplot1, Value = con.RtsdominatedByOneOrTwoSppplot1 },
                    Plot2 = new Property<bool>() { Original = con.RtsdominatedByOneOrTwoSppplot2, Value = con.RtsdominatedByOneOrTwoSppplot2 },
                    Plot3 = new Property<bool>() { Original = con.RtsdominatedByOneOrTwoSppplot3, Value = con.RtsdominatedByOneOrTwoSppplot3 },
                    Plot4 = new Property<bool>() { Original = con.RtsdominatedByOneOrTwoSppplot4, Value = con.RtsdominatedByOneOrTwoSppplot4 },
                    Plot5 = new Property<bool>() { Original = con.RtsdominatedByOneOrTwoSppplot5, Value = con.RtsdominatedByOneOrTwoSppplot5 },
                },

                NativesNumberPresent = new CATPlotObj()
                {
                    //Overall = Convert.ToInt32(con.RssnativesNumberPresent),
                    //Plot1 = Convert.ToInt32(con.RssnativesNumberPresentPlot1),
                    //Plot2 = Convert.ToInt32(con.RssnativesNumberPresentPlot2),
                    //Plot3 = Convert.ToInt32(con.RssnativesNumberPresentPlot3),
                    //Plot4 = Convert.ToInt32(con.RssnativesNumberPresentPlot4),
                    //Plot5 = Convert.ToInt32(con.RssnativesNumberPresentPlot5),

                    Overall = new Property<int>() { Original = con.RssnativesNumberPresent.GetValueOrDefault(), Value = con.RssnativesNumberPresent.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.RssnativesNumberPresentPlot1.GetValueOrDefault(), Value = con.RssnativesNumberPresentPlot1.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.RssnativesNumberPresentPlot2.GetValueOrDefault(), Value = con.RssnativesNumberPresentPlot2.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.RssnativesNumberPresentPlot3.GetValueOrDefault(), Value = con.RssnativesNumberPresentPlot3.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.RssnativesNumberPresentPlot4.GetValueOrDefault(), Value = con.RssnativesNumberPresentPlot4.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.RssnativesNumberPresentPlot5.GetValueOrDefault(), Value = con.RssnativesNumberPresentPlot5.GetValueOrDefault() },

                }
            };

            return catRegenerationShrubSpeciesDTO;
        }

        public void UpdateCATRegenerationShrubSpeciesDTO(int Id, CATRegenerationTreeSpeciesDTO cafkfSummaries)
        {
          
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            con.RssnotesActions = cafkfSummaries.Notes;
            con.RssinterventionAchievable = cafkfSummaries.InterventionAchievable;
            con.RssinterventionDesirable = cafkfSummaries.InterventionDesirable;

            con.RssnonNativesNumberPresent = cafkfSummaries.NonNativesNumberPresent.Overall.Value;
            con.RssnonNativesNumberPresentPlot1 = cafkfSummaries.NonNativesNumberPresent.Plot1.Value;
            con.RssnonNativesNumberPresentPlot2 = cafkfSummaries.NonNativesNumberPresent.Plot2.Value;
            con.RssnonNativesNumberPresentPlot3 = cafkfSummaries.NonNativesNumberPresent.Plot3.Value;
            con.RssnonNativesNumberPresentPlot4 = cafkfSummaries.NonNativesNumberPresent.Plot4.Value;
            con.RssnonNativesNumberPresentPlot5 = cafkfSummaries.NonNativesNumberPresent.Plot5.Value;

            con.RssdominatedByOneOrTwoSpp = cafkfSummaries.DominatedByOneOrTwoSPP.Overall.Value;
            con.RssdominatedByOneOrTwoSppplot1 = cafkfSummaries.DominatedByOneOrTwoSPP.Plot1.Value;
            con.RssdominatedByOneOrTwoSppplot2 = cafkfSummaries.DominatedByOneOrTwoSPP.Plot2.Value;
            con.RssdominatedByOneOrTwoSppplot3 = cafkfSummaries.DominatedByOneOrTwoSPP.Plot3.Value;
            con.RssdominatedByOneOrTwoSppplot4 = cafkfSummaries.DominatedByOneOrTwoSPP.Plot4.Value;
            con.RssdominatedByOneOrTwoSppplot5 = cafkfSummaries.DominatedByOneOrTwoSPP.Plot5.Value;

            con.RssnativesNumberPresent = cafkfSummaries.NativesNumberPresent.Overall.Value;
            con.RssnativesNumberPresentPlot1 = cafkfSummaries.NativesNumberPresent.Plot1.Value;
            con.RssnativesNumberPresentPlot2 = cafkfSummaries.NativesNumberPresent.Plot2.Value;
            con.RssnativesNumberPresentPlot3 = cafkfSummaries.NativesNumberPresent.Plot3.Value;
            con.RssnativesNumberPresentPlot4 = cafkfSummaries.NativesNumberPresent.Plot4.Value;
            con.RssnativesNumberPresentPlot5 = cafkfSummaries.NativesNumberPresent.Plot5.Value;


            Context.SaveChanges();
        }

        #endregion

        #region flora

        public CATFloraDTO GetCatFloraDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
            if (con == null) con = new WoodlandConditionSubSection();

            var catFloraDTO = new CATFloraDTO()
            {
                InterventionAchievable = con.FinterventionAchievable,
                InterventionDesirable = con.FinterventionDesirable,
                Notes = con.FnotesActions,
                Ancientwoodlandplantsspecialists = new CATPlotObj()
                {
                    //Overall = con.FancientWoodlandPlantsSpecialistsId.GetValueOrDefault(),
                    //Plot1 = con.FancientWoodlandPlantsSpecialistsPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.FancientWoodlandPlantsSpecialistsPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.FancientWoodlandPlantsSpecialistsPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.FancientWoodlandPlantsSpecialistsPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.FancientWoodlandPlantsSpecialistsPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.FancientWoodlandPlantsSpecialistsId.GetValueOrDefault(), Value = con.FancientWoodlandPlantsSpecialistsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.FancientWoodlandPlantsSpecialistsPlot1Id.GetValueOrDefault(), Value = con.FancientWoodlandPlantsSpecialistsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.FancientWoodlandPlantsSpecialistsPlot2Id.GetValueOrDefault(), Value = con.FancientWoodlandPlantsSpecialistsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.FancientWoodlandPlantsSpecialistsPlot3Id.GetValueOrDefault(), Value = con.FancientWoodlandPlantsSpecialistsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.FancientWoodlandPlantsSpecialistsPlot4Id.GetValueOrDefault(), Value = con.FancientWoodlandPlantsSpecialistsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.FancientWoodlandPlantsSpecialistsPlot5Id.GetValueOrDefault(), Value = con.FancientWoodlandPlantsSpecialistsPlot5Id.GetValueOrDefault() },

                },

                Otherwoodlandplantsgeneralists = new CATPlotObj()
                {
                    //Overall = con.FotherWoodlandPlantsGeneralistsId.GetValueOrDefault(),
                    //Plot1 = con.FancientWoodlandPlantsSpecialistsPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.FancientWoodlandPlantsSpecialistsPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.FancientWoodlandPlantsSpecialistsPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.FancientWoodlandPlantsSpecialistsPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.FancientWoodlandPlantsSpecialistsPlot5Id.GetValueOrDefault(),


                    Overall = new Property<int>() { Original = con.FotherWoodlandPlantsGeneralistsId.GetValueOrDefault(), Value = con.FotherWoodlandPlantsGeneralistsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.FotherWoodlandPlantsGeneralistsPlot1Id.GetValueOrDefault(), Value = con.FotherWoodlandPlantsGeneralistsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.FotherWoodlandPlantsGeneralistsPlot2Id.GetValueOrDefault(), Value = con.FotherWoodlandPlantsGeneralistsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.FotherWoodlandPlantsGeneralistsPlot3Id.GetValueOrDefault(), Value = con.FotherWoodlandPlantsGeneralistsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.FotherWoodlandPlantsGeneralistsPlot4Id.GetValueOrDefault(), Value = con.FotherWoodlandPlantsGeneralistsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.FotherWoodlandPlantsGeneralistsPlot5Id.GetValueOrDefault(), Value = con.FotherWoodlandPlantsGeneralistsPlot5Id.GetValueOrDefault() },

                },

                Othernativeplantsegseminaturalopenground = new CATPlotObj()
                {
                    //Overall = con.FotherNativePlantsId.GetValueOrDefault(),
                    //Plot1 = con.FotherNativePlantsPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.FotherNativePlantsPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.FotherNativePlantsPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.FotherNativePlantsPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.FotherNativePlantsPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.FotherNativePlantsId.GetValueOrDefault(), Value = con.FotherNativePlantsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.FotherNativePlantsPlot1Id.GetValueOrDefault(), Value = con.FotherNativePlantsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.FotherNativePlantsPlot2Id.GetValueOrDefault(), Value = con.FotherNativePlantsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.FotherNativePlantsPlot3Id.GetValueOrDefault(), Value = con.FotherNativePlantsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.FotherNativePlantsPlot4Id.GetValueOrDefault(), Value = con.FotherNativePlantsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.FotherNativePlantsPlot5Id.GetValueOrDefault(), Value = con.FotherNativePlantsPlot5Id.GetValueOrDefault() },


                },

                Coarsevegetationbrackenbramble = new CATPlotObj()
                {
                    //Overall = con.FcoarseVegetationId.GetValueOrDefault(),
                    //Plot1 = con.FcoarseVegetationPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.FcoarseVegetationPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.FcoarseVegetationPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.FcoarseVegetationPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.FcoarseVegetationPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.FcoarseVegetationId.GetValueOrDefault(), Value = con.FcoarseVegetationId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.FcoarseVegetationPlot1Id.GetValueOrDefault(), Value = con.FcoarseVegetationPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.FcoarseVegetationPlot2Id.GetValueOrDefault(), Value = con.FcoarseVegetationPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.FcoarseVegetationPlot3Id.GetValueOrDefault(), Value = con.FcoarseVegetationPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.FcoarseVegetationPlot4Id.GetValueOrDefault(), Value = con.FcoarseVegetationPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.FcoarseVegetationPlot5Id.GetValueOrDefault(), Value = con.FcoarseVegetationPlot5Id.GetValueOrDefault() },

                },

                Otherplants = new CATPlotObj()
                {
                    //Overall = con.FotherPlantsId.GetValueOrDefault(),
                    //Plot1 = con.FotherPlantsPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.FotherPlantsPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.FotherPlantsPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.FotherPlantsPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.FotherPlantsPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.FotherPlantsId.GetValueOrDefault(), Value = con.FotherPlantsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.FotherPlantsPlot1Id.GetValueOrDefault(), Value = con.FotherPlantsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.FotherPlantsPlot2Id.GetValueOrDefault(), Value = con.FotherPlantsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.FotherPlantsPlot3Id.GetValueOrDefault(), Value = con.FotherPlantsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.FotherPlantsPlot4Id.GetValueOrDefault(), Value = con.FotherPlantsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.FotherPlantsPlot5Id.GetValueOrDefault(), Value = con.FotherPlantsPlot5Id.GetValueOrDefault() },

                },

                Novegetation = new CATPlotObj()
                {
                    //Overall = con.FnoVegetationId.GetValueOrDefault(),
                    //Plot1 = con.FnoVegetationPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.FnoVegetationPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.FnoVegetationPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.FnoVegetationPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.FnoVegetationPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.FnoVegetationId.GetValueOrDefault(), Value = con.FnoVegetationId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.FnoVegetationPlot1Id.GetValueOrDefault(), Value = con.FnoVegetationPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.FnoVegetationPlot2Id.GetValueOrDefault(), Value = con.FnoVegetationPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.FnoVegetationPlot3Id.GetValueOrDefault(), Value = con.FnoVegetationPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.FnoVegetationPlot4Id.GetValueOrDefault(), Value = con.FnoVegetationPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.FnoVegetationPlot5Id.GetValueOrDefault(), Value = con.FnoVegetationPlot5Id.GetValueOrDefault() },


                },


            };


            return catFloraDTO;
        }


        public void UpdateCATFloraDTO(int Id, CATFloraDTO cafkfSummaries)
        {

            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            //Overall = con.FancientWoodlandPlantsSpecialistsId.GetValueOrDefault(),

            con.FnotesActions = cafkfSummaries.Notes;
            con.FinterventionAchievable = cafkfSummaries.InterventionAchievable;
            con.FinterventionDesirable = cafkfSummaries.InterventionDesirable;

            con.FancientWoodlandPlantsSpecialistsId = cafkfSummaries.Ancientwoodlandplantsspecialists.Overall.Value;
            con.FancientWoodlandPlantsSpecialistsPlot1Id = cafkfSummaries.Ancientwoodlandplantsspecialists.Plot1.Value;
            con.FancientWoodlandPlantsSpecialistsPlot2Id = cafkfSummaries.Ancientwoodlandplantsspecialists.Plot2.Value;
            con.FancientWoodlandPlantsSpecialistsPlot3Id = cafkfSummaries.Ancientwoodlandplantsspecialists.Plot3.Value;
            con.FancientWoodlandPlantsSpecialistsPlot4Id = cafkfSummaries.Ancientwoodlandplantsspecialists.Plot4.Value;
            con.FancientWoodlandPlantsSpecialistsPlot5Id = cafkfSummaries.Ancientwoodlandplantsspecialists.Plot5.Value;

            //Overall = con.FotherWoodlandPlantsGeneralistsId.GetValueOrDefault(),
            con.FotherWoodlandPlantsGeneralistsId = cafkfSummaries.Otherwoodlandplantsgeneralists.Overall.Value;
            con.FotherWoodlandPlantsGeneralistsPlot1Id = cafkfSummaries.Otherwoodlandplantsgeneralists.Plot1.Value;
            con.FotherWoodlandPlantsGeneralistsPlot2Id = cafkfSummaries.Otherwoodlandplantsgeneralists.Plot2.Value;
            con.FotherWoodlandPlantsGeneralistsPlot3Id = cafkfSummaries.Otherwoodlandplantsgeneralists.Plot3.Value;
            con.FotherWoodlandPlantsGeneralistsPlot4Id = cafkfSummaries.Otherwoodlandplantsgeneralists.Plot4.Value;
            con.FotherWoodlandPlantsGeneralistsPlot5Id = cafkfSummaries.Otherwoodlandplantsgeneralists.Plot5.Value;

            //Overall = con.FotherNativePlantsId.GetValueOrDefault(),
            con.FotherNativePlantsId = cafkfSummaries.Othernativeplantsegseminaturalopenground.Overall.Value;
            con.FotherNativePlantsPlot1Id = cafkfSummaries.Othernativeplantsegseminaturalopenground.Plot1.Value;
            con.FotherNativePlantsPlot2Id = cafkfSummaries.Othernativeplantsegseminaturalopenground.Plot2.Value;
            con.FotherNativePlantsPlot3Id = cafkfSummaries.Othernativeplantsegseminaturalopenground.Plot3.Value;
            con.FotherNativePlantsPlot4Id = cafkfSummaries.Othernativeplantsegseminaturalopenground.Plot4.Value;
            con.FotherNativePlantsPlot5Id = cafkfSummaries.Othernativeplantsegseminaturalopenground.Plot5.Value;

            //Overall = con.FotherPlantsId.GetValueOrDefault(),
            con.FotherPlantsId = cafkfSummaries.Otherplants.Overall.Value;
            con.FotherPlantsPlot1Id = cafkfSummaries.Otherplants.Plot1.Value;
            con.FotherPlantsPlot2Id = cafkfSummaries.Otherplants.Plot2.Value;
            con.FotherPlantsPlot3Id = cafkfSummaries.Otherplants.Plot3.Value;
            con.FotherPlantsPlot4Id = cafkfSummaries.Otherplants.Plot4.Value;
            con.FotherPlantsPlot5Id = cafkfSummaries.Otherplants.Plot5.Value;

            //Overall = con.FnoVegetationId.GetValueOrDefault(),
            con.FnoVegetationId = cafkfSummaries.Novegetation.Overall.Value;
            con.FnoVegetationPlot1Id = cafkfSummaries.Novegetation.Plot1.Value;
            con.FnoVegetationPlot2Id = cafkfSummaries.Novegetation.Plot2.Value;
            con.FnoVegetationPlot3Id = cafkfSummaries.Novegetation.Plot3.Value;
            con.FnoVegetationPlot4Id = cafkfSummaries.Novegetation.Plot4.Value;
            con.FnoVegetationPlot5Id = cafkfSummaries.Novegetation.Plot5.Value;

            Context.SaveChanges();
        }

        #endregion

        #region deadwood

        public CATDeadWoodDTO GetCatDeadWoodDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
            if (con == null) con = new WoodlandConditionSubSection();
            var catDeadWoodDTO = new CATDeadWoodDTO()
            {
                Standing = new CATPlotObj()
                {
                    //Overall = con.DstandingId.GetValueOrDefault(),
                    //Plot1 = con.DstandingPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.DstandingPlot1Id.GetValueOrDefault(),
                    //Plot3 = con.DstandingPlot1Id.GetValueOrDefault(),
                    //Plot4 = con.DstandingPlot1Id.GetValueOrDefault(),
                    //Plot5 = con.DstandingPlot1Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.DstandingId.GetValueOrDefault(), Value = con.DstandingId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.DstandingPlot1Id.GetValueOrDefault(), Value = con.DstandingPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.DstandingPlot2Id.GetValueOrDefault(), Value = con.DstandingPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.DstandingPlot3Id.GetValueOrDefault(), Value = con.DstandingPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.DstandingPlot4Id.GetValueOrDefault(), Value = con.DstandingPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.DstandingPlot5Id.GetValueOrDefault(), Value = con.DstandingPlot5Id.GetValueOrDefault() },
                },
                Fallen = new CATPlotObj()
                {
                    //Overall = con.DfallenId.GetValueOrDefault(),
                    //Plot1 = con.DfallenPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.DfallenPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.DfallenPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.DfallenPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.DfallenPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.DfallenId.GetValueOrDefault(), Value = con.DfallenId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.DfallenPlot1Id.GetValueOrDefault(), Value = con.DfallenPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.DfallenPlot2Id.GetValueOrDefault(), Value = con.DfallenPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.DfallenPlot3Id.GetValueOrDefault(), Value = con.DfallenPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.DfallenPlot4Id.GetValueOrDefault(), Value = con.DfallenPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.DfallenPlot5Id.GetValueOrDefault(), Value = con.DfallenPlot5Id.GetValueOrDefault() },
                },
                Notes = con.DnotesActions,
                InterventionDesirable = con.DinterventionDesirable,
                InterventionAchievable = con.DinterventionAchievable
            };

            return catDeadWoodDTO;
        }
        public void UpdateCATDeadWoodDTO(int Id, CATDeadWoodDTO cafkfSummaries)
        {

            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            con.DnotesActions = cafkfSummaries.Notes;
            con.DinterventionAchievable = cafkfSummaries.InterventionAchievable;
            con.DinterventionDesirable = cafkfSummaries.InterventionDesirable;

            con.DstandingId = cafkfSummaries.Standing.Overall.Value;
            con.DstandingPlot1Id = cafkfSummaries.Standing.Plot1.Value;
            con.DstandingPlot2Id = cafkfSummaries.Standing.Plot2.Value;
            con.DstandingPlot3Id = cafkfSummaries.Standing.Plot3.Value;
            con.DstandingPlot4Id = cafkfSummaries.Standing.Plot4.Value;
            con.DstandingPlot5Id = cafkfSummaries.Standing.Plot5.Value;

            con.DfallenId = cafkfSummaries.Fallen.Overall.Value;
            con.DfallenPlot1Id = cafkfSummaries.Fallen.Plot1.Value;
            con.DfallenPlot2Id = cafkfSummaries.Fallen.Plot2.Value;
            con.DfallenPlot3Id = cafkfSummaries.Fallen.Plot3.Value;
            con.DfallenPlot4Id = cafkfSummaries.Fallen.Plot4.Value;
            con.DfallenPlot5Id = cafkfSummaries.Fallen.Plot5.Value;
            
            Context.SaveChanges();
        }
        #endregion

        #region animal damage

        

        public CATAnimalDamageDTO GetCatAnimalDamageDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            if(con == null) con = new WoodlandConditionSubSection();

            var catAnimalDamageDTO = new CATAnimalDamageDTO()
            {
                Notes = con.AdnotesActions,
                InterventionDesirable = con.AdinterventionAchievable,
                InterventionAchievable = con.AdinterventionAchievable,
                Deer = new CATPlotObj()
                {
                    //Overall = con.AddeerId.GetValueOrDefault(),
                    //Plot1 = con.AddeerPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.AddeerPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.AddeerPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.AddeerPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.AddeerPlot5Id.GetValueOrDefault(),


                    Overall = new Property<int>() { Original = con.AddeerId.GetValueOrDefault(), Value = con.AddeerId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.AddeerPlot1Id.GetValueOrDefault(), Value = con.AddeerPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.AddeerPlot2Id.GetValueOrDefault(), Value = con.AddeerPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.AddeerPlot3Id.GetValueOrDefault(), Value = con.AddeerPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.AddeerPlot4Id.GetValueOrDefault(), Value = con.AddeerPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.AddeerPlot5Id.GetValueOrDefault(), Value = con.AddeerPlot5Id.GetValueOrDefault() },
                },

                Other = new CATPlotObj()
                {
                    //Overall = con.AdotherId.GetValueOrDefault(),
                    //Plot1 = con.AdotherPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.AdotherPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.AdotherPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.AdotherPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.AdotherPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.AdotherId.GetValueOrDefault(), Value = con.AdotherId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.AdotherPlot1Id.GetValueOrDefault(), Value = con.AdotherPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.AdotherPlot2Id.GetValueOrDefault(), Value = con.AdotherPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.AdotherPlot3Id.GetValueOrDefault(), Value = con.AdotherPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.AdotherPlot4Id.GetValueOrDefault(), Value = con.AdotherPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.AdotherPlot5Id.GetValueOrDefault(), Value = con.AdotherPlot5Id.GetValueOrDefault() },
                },

                Rabbits = new CATPlotObj()
                {
                    //Overall = con.AdrabBitsId.GetValueOrDefault(),
                    //Plot1 = con.AdrabBitsId.GetValueOrDefault(),
                    //Plot2 = con.AdrabBitsId.GetValueOrDefault(),
                    //Plot3 = con.AdrabBitsId.GetValueOrDefault(),
                    //Plot4 = con.AdrabBitsId.GetValueOrDefault(),
                    //Plot5 = con.AdrabBitsId.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.AdrabBitsId.GetValueOrDefault(), Value = con.AdrabBitsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.AdrabBitsPlot1Id.GetValueOrDefault(), Value = con.AdrabBitsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.AdrabBitsPlot2Id.GetValueOrDefault(), Value = con.AdrabBitsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.AdrabBitsPlot3Id.GetValueOrDefault(), Value = con.AdrabBitsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.AdrabBitsPlot4Id.GetValueOrDefault(), Value = con.AdrabBitsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.AdrabBitsPlot5Id.GetValueOrDefault(), Value = con.AdrabBitsPlot5Id.GetValueOrDefault() },
                },

                Squirrels = new CATPlotObj()
                {
                    //Overall = con.AdsquirrelsId.GetValueOrDefault(),
                    //Plot1 = con.AdsquirrelsPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.AdsquirrelsPlot1Id.GetValueOrDefault(),
                    //Plot3 = con.AdsquirrelsPlot1Id.GetValueOrDefault(),
                    //Plot4 = con.AdsquirrelsPlot1Id.GetValueOrDefault(),
                    //Plot5 = con.AdsquirrelsPlot1Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.AdsquirrelsId.GetValueOrDefault(), Value = con.AdsquirrelsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.AdsquirrelsPlot1Id.GetValueOrDefault(), Value = con.AdsquirrelsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.AdsquirrelsPlot2Id.GetValueOrDefault(), Value = con.AdsquirrelsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.AdsquirrelsPlot3Id.GetValueOrDefault(), Value = con.AdsquirrelsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.AdsquirrelsPlot4Id.GetValueOrDefault(), Value = con.AdsquirrelsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.AdsquirrelsPlot5Id.GetValueOrDefault(), Value = con.AdsquirrelsPlot5Id.GetValueOrDefault() },
                }


            };

            return catAnimalDamageDTO;
        }

        public void UpdateCATAnimalDamageDTO(int Id, CATAnimalDamageDTO cafkfSummaries)
        {
          
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            con.AdnotesActions = cafkfSummaries.Notes;
            con.AdinterventionAchievable = cafkfSummaries.InterventionAchievable;
            con.AdinterventionDesirable = cafkfSummaries.InterventionDesirable;


            con.AddeerId = cafkfSummaries.Deer.Overall.Value;
            con.AddeerPlot1Id = cafkfSummaries.Deer.Plot1.Value;
            con.AddeerPlot2Id = cafkfSummaries.Deer.Plot2.Value;
            con.AddeerPlot3Id = cafkfSummaries.Deer.Plot3.Value;
            con.AddeerPlot4Id = cafkfSummaries.Deer.Plot4.Value;
            con.AddeerPlot5Id = cafkfSummaries.Deer.Plot5.Value;


            con.AdotherId = cafkfSummaries.Other.Overall.Value;
            con.AdotherPlot1Id = cafkfSummaries.Other.Plot1.Value;
            con.AdotherPlot2Id = cafkfSummaries.Other.Plot2.Value;
            con.AdotherPlot3Id = cafkfSummaries.Other.Plot3.Value;
            con.AdotherPlot4Id = cafkfSummaries.Other.Plot4.Value;
            con.AdotherPlot5Id = cafkfSummaries.Other.Plot5.Value;

            con.AdrabBitsId = cafkfSummaries.Rabbits.Overall.Value;
            con.AdrabBitsPlot1Id = cafkfSummaries.Rabbits.Plot1.Value;
            con.AdrabBitsPlot2Id = cafkfSummaries.Rabbits.Plot2.Value;
            con.AdrabBitsPlot3Id = cafkfSummaries.Rabbits.Plot3.Value;
            con.AdrabBitsPlot4Id = cafkfSummaries.Rabbits.Plot4.Value;
            con.AdrabBitsPlot5Id = cafkfSummaries.Rabbits.Plot5.Value;


            con.AdsquirrelsId = cafkfSummaries.Squirrels.Overall.Value;
            con.AdsquirrelsPlot1Id = cafkfSummaries.Squirrels.Plot1.Value;
            con.AdsquirrelsPlot2Id = cafkfSummaries.Squirrels.Plot2.Value;
            con.AdsquirrelsPlot3Id = cafkfSummaries.Squirrels.Plot3.Value;
            con.AdsquirrelsPlot4Id = cafkfSummaries.Squirrels.Plot4.Value;
            con.AdsquirrelsPlot5Id = cafkfSummaries.Squirrels.Plot5.Value;

            Context.SaveChanges();
        }

        #endregion

        #region invasives

        public CATInvasivesDTO GetCatInvasivesDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
            if (con == null) con = new WoodlandConditionSubSection();
            var catInvasivesDTO = new CATInvasivesDTO()
            {
                Notes = con.InotesActions,
                InterventionDesirable = con.IinterventionDesirable,
                InterventionAchievable = con.IinterventionAchievable,

                Other = new CATPlotObj()
                {
                    //Overall = con.IotherId.GetValueOrDefault(),
                    //Plot1 = con.IotherPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.IotherPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.IotherPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.IotherPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.IotherPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.IotherId.GetValueOrDefault(), Value = con.IotherId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.IotherPlot1Id.GetValueOrDefault(), Value = con.IotherPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.IotherPlot2Id.GetValueOrDefault(), Value = con.IotherPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.IotherPlot3Id.GetValueOrDefault(), Value = con.IotherPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.IotherPlot4Id.GetValueOrDefault(), Value = con.IotherPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.IotherPlot5Id.GetValueOrDefault(), Value = con.IotherPlot5Id.GetValueOrDefault() },
                },

                Himalayanbalsam = new CATPlotObj()
                {
                    //Overall = con.IhimalayanBalsamId.GetValueOrDefault(),
                    //Plot1 = con.IhimalayanBalsamPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.IhimalayanBalsamPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.IhimalayanBalsamPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.IhimalayanBalsamPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.IhimalayanBalsamPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.IhimalayanBalsamId.GetValueOrDefault(), Value = con.IhimalayanBalsamId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.IhimalayanBalsamPlot1Id.GetValueOrDefault(), Value = con.IhimalayanBalsamPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.IhimalayanBalsamPlot2Id.GetValueOrDefault(), Value = con.IhimalayanBalsamPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.IhimalayanBalsamPlot3Id.GetValueOrDefault(), Value = con.IhimalayanBalsamPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.IhimalayanBalsamPlot4Id.GetValueOrDefault(), Value = con.IhimalayanBalsamPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.IhimalayanBalsamPlot5Id.GetValueOrDefault(), Value = con.IhimalayanBalsamPlot5Id.GetValueOrDefault() },
                },

                Japaneseknotweed = new CATPlotObj()
                {
                    //Overall = con.IjapaneseKnotweedId.GetValueOrDefault(),
                    //Plot1 = con.IjapaneseKnotweedPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.IjapaneseKnotweedPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.IjapaneseKnotweedPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.IjapaneseKnotweedPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.IjapaneseKnotweedPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.IjapaneseKnotweedId.GetValueOrDefault(), Value = con.IjapaneseKnotweedId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.IjapaneseKnotweedPlot1Id.GetValueOrDefault(), Value = con.IjapaneseKnotweedPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.IjapaneseKnotweedPlot2Id.GetValueOrDefault(), Value = con.IjapaneseKnotweedPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.IjapaneseKnotweedPlot3Id.GetValueOrDefault(), Value = con.IjapaneseKnotweedPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.IjapaneseKnotweedPlot4Id.GetValueOrDefault(), Value = con.IjapaneseKnotweedPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.IjapaneseKnotweedPlot5Id.GetValueOrDefault(), Value = con.IjapaneseKnotweedPlot5Id.GetValueOrDefault() },
                },

                Rhododendron = new CATPlotObj()
                {
                    //Overall = con.IrhododendronId.GetValueOrDefault(),
                    //Plot1 = con.IrhododendronPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.IrhododendronPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.IrhododendronPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.IrhododendronPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.IrhododendronPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.IrhododendronId.GetValueOrDefault(), Value = con.IrhododendronId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.IrhododendronPlot1Id.GetValueOrDefault(), Value = con.IrhododendronPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.IrhododendronPlot2Id.GetValueOrDefault(), Value = con.IrhododendronPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.IrhododendronPlot3Id.GetValueOrDefault(), Value = con.IrhododendronPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.IrhododendronPlot4Id.GetValueOrDefault(), Value = con.IrhododendronPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.IrhododendronPlot5Id.GetValueOrDefault(), Value = con.IrhododendronPlot5Id.GetValueOrDefault() },
                }
            };

            return catInvasivesDTO;
        }

        public void UpdateCATInvasivesDTO(int Id, CATInvasivesDTO cafkfSummaries)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            con.InotesActions = cafkfSummaries.Notes;
            con.IinterventionAchievable = cafkfSummaries.InterventionAchievable;
            con.IinterventionDesirable = cafkfSummaries.InterventionAchievable;

            con.IotherId = cafkfSummaries.Other.Overall.Value;
            con.IotherPlot1Id = cafkfSummaries.Other.Plot1.Value;
            con.IotherPlot2Id = cafkfSummaries.Other.Plot2.Value;
            con.IotherPlot3Id = cafkfSummaries.Other.Plot3.Value;
            con.IotherPlot4Id = cafkfSummaries.Other.Plot4.Value;
            con.IotherPlot5Id = cafkfSummaries.Other.Plot5.Value;


            con.IhimalayanBalsamId = cafkfSummaries.Himalayanbalsam.Overall.Value;
            con.IhimalayanBalsamPlot1Id = cafkfSummaries.Himalayanbalsam.Plot1.Value;
            con.IhimalayanBalsamPlot2Id = cafkfSummaries.Himalayanbalsam.Plot2.Value;
            con.IhimalayanBalsamPlot3Id = cafkfSummaries.Himalayanbalsam.Plot3.Value;
            con.IhimalayanBalsamPlot4Id = cafkfSummaries.Himalayanbalsam.Plot4.Value;
            con.IhimalayanBalsamPlot5Id = cafkfSummaries.Himalayanbalsam.Plot5.Value;

            con.IjapaneseKnotweedId = cafkfSummaries.Japaneseknotweed.Overall.Value;
            con.IjapaneseKnotweedPlot1Id = cafkfSummaries.Japaneseknotweed.Plot1.Value;
            con.IjapaneseKnotweedPlot2Id = cafkfSummaries.Japaneseknotweed.Plot2.Value;
            con.IjapaneseKnotweedPlot3Id = cafkfSummaries.Japaneseknotweed.Plot3.Value;
            con.IjapaneseKnotweedPlot4Id = cafkfSummaries.Japaneseknotweed.Plot4.Value;
            con.IjapaneseKnotweedPlot5Id = cafkfSummaries.Japaneseknotweed.Plot5.Value;

            con.IrhododendronId = cafkfSummaries.Rhododendron.Overall.Value;
            con.IrhododendronPlot1Id = cafkfSummaries.Rhododendron.Plot1.Value;
            con.IrhododendronPlot2Id = cafkfSummaries.Rhododendron.Plot2.Value;
            con.IrhododendronPlot3Id = cafkfSummaries.Rhododendron.Plot3.Value;
            con.IrhododendronPlot4Id = cafkfSummaries.Rhododendron.Plot4.Value;
            con.IrhododendronPlot5Id = cafkfSummaries.Rhododendron.Plot5.Value;


            Context.SaveChanges();
        }

        #endregion

        #region cat tree health

        public CATTreeHealthDTO GetCatTreeHealthDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
            if (con == null) con = new WoodlandConditionSubSection();

            var catTreeHealthDTO = new CATTreeHealthDTO()
            {
                Notes = con.ThnotesActions,
                InterventionDesirable = con.ThinterventionDesirable,
                InterventionAchievable = con.ThinterventionAchievable,

                Notifiablepestordisease = new CATPlotObj()
                {
                    //Overall = con.ThnotifiablePestOrDiseaseId.GetValueOrDefault(),
                    //Plot1 = con.ThnotifiablePestOrDiseasePlot1Id.GetValueOrDefault(),
                    //Plot2 = con.ThnotifiablePestOrDiseasePlot2Id.GetValueOrDefault(),
                    //Plot3 = con.ThnotifiablePestOrDiseasePlot3Id.GetValueOrDefault(),
                    //Plot4 = con.ThnotifiablePestOrDiseasePlot4Id.GetValueOrDefault(),
                    //Plot5 = con.ThnotifiablePestOrDiseasePlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.ThnotifiablePestOrDiseaseId.GetValueOrDefault(), Value = con.ThnotifiablePestOrDiseaseId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.ThnotifiablePestOrDiseasePlot1Id.GetValueOrDefault(), Value = con.ThnotifiablePestOrDiseasePlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.ThnotifiablePestOrDiseasePlot2Id.GetValueOrDefault(), Value = con.ThnotifiablePestOrDiseasePlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.ThnotifiablePestOrDiseasePlot3Id.GetValueOrDefault(), Value = con.ThnotifiablePestOrDiseasePlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.ThnotifiablePestOrDiseasePlot4Id.GetValueOrDefault(), Value = con.ThnotifiablePestOrDiseasePlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.ThnotifiablePestOrDiseasePlot5Id.GetValueOrDefault(), Value = con.ThnotifiablePestOrDiseasePlot5Id.GetValueOrDefault() },
                },

                Otherdiseaseorpest = new CATPlotObj()
                {
                    //Overall = con.ThotherDiseaseOrPestId.GetValueOrDefault(),
                    //Plot1 = con.ThotherDiseaseOrPestPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.ThotherDiseaseOrPestPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.ThotherDiseaseOrPestPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.ThotherDiseaseOrPestPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.ThotherDiseaseOrPestPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.ThotherDiseaseOrPestId.GetValueOrDefault(), Value = con.ThotherDiseaseOrPestId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.ThotherDiseaseOrPestPlot1Id.GetValueOrDefault(), Value = con.ThotherDiseaseOrPestPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.ThotherDiseaseOrPestPlot2Id.GetValueOrDefault(), Value = con.ThotherDiseaseOrPestPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.ThotherDiseaseOrPestPlot3Id.GetValueOrDefault(), Value = con.ThotherDiseaseOrPestPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.ThotherDiseaseOrPestPlot4Id.GetValueOrDefault(), Value = con.ThotherDiseaseOrPestPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.ThotherDiseaseOrPestPlot5Id.GetValueOrDefault(), Value = con.ThotherDiseaseOrPestPlot5Id.GetValueOrDefault() },
                },

            };

            return catTreeHealthDTO;
        }

        public void UpdateCATTreeHealthDTO(int Id, CATTreeHealthDTO cafkfSummaries)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            con.ThnotesActions = cafkfSummaries.Notes;
            con.ThinterventionAchievable = cafkfSummaries.InterventionAchievable;
            con.ThinterventionDesirable = cafkfSummaries.InterventionDesirable;
 
            con.ThnotifiablePestOrDiseaseId = cafkfSummaries.Notifiablepestordisease.Overall.Value;
            con.ThnotifiablePestOrDiseasePlot1Id = cafkfSummaries.Notifiablepestordisease.Plot1.Value;
            con.ThnotifiablePestOrDiseasePlot2Id = cafkfSummaries.Notifiablepestordisease.Plot2.Value;
            con.ThnotifiablePestOrDiseasePlot3Id = cafkfSummaries.Notifiablepestordisease.Plot3.Value;
            con.ThnotifiablePestOrDiseasePlot4Id = cafkfSummaries.Notifiablepestordisease.Plot4.Value;
            con.ThnotifiablePestOrDiseasePlot5Id = cafkfSummaries.Notifiablepestordisease.Plot5.Value;

            con.ThotherDiseaseOrPestId = cafkfSummaries.Otherdiseaseorpest.Overall.Value;
            con.ThotherDiseaseOrPestPlot1Id = cafkfSummaries.Otherdiseaseorpest.Plot1.Value;
            con.ThotherDiseaseOrPestPlot2Id = cafkfSummaries.Otherdiseaseorpest.Plot2.Value;
            con.ThotherDiseaseOrPestPlot3Id = cafkfSummaries.Otherdiseaseorpest.Plot3.Value;
            con.ThotherDiseaseOrPestPlot4Id = cafkfSummaries.Otherdiseaseorpest.Plot4.Value;
            con.ThotherDiseaseOrPestPlot5Id = cafkfSummaries.Otherdiseaseorpest.Plot5.Value;

            Context.SaveChanges();
        }

        #endregion

        #region human impacts
        public CATHumanImpactsDTO GetCatHumanImpactsDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
            if (con == null) con = new WoodlandConditionSubSection();

            var catHumanImpactsDTO = new CATHumanImpactsDTO()
            {

                
                Notes = con.HinotesActions,
                InterventionDesirable = con.HiinterventionDesirable,
                InterventionAchievable = con.HiinterventionAchievable,
                Continuousimpacts = new CATPlotObj()
                {
                    //Overall = con.HicontinuousImpactsId.GetValueOrDefault(),
                    //Plot1 = con.HicontinuousImpactsPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.HicontinuousImpactsPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.HicontinuousImpactsPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.HicontinuousImpactsPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.HicontinuousImpactsPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.HicontinuousImpactsId.GetValueOrDefault(), Value = con.HicontinuousImpactsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.HicontinuousImpactsPlot1Id.GetValueOrDefault(), Value = con.HicontinuousImpactsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.HicontinuousImpactsPlot2Id.GetValueOrDefault(), Value = con.HicontinuousImpactsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.HicontinuousImpactsPlot3Id.GetValueOrDefault(), Value = con.HicontinuousImpactsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.HicontinuousImpactsPlot4Id.GetValueOrDefault(), Value = con.HicontinuousImpactsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.HicontinuousImpactsPlot5Id.GetValueOrDefault(), Value = con.HicontinuousImpactsPlot5Id.GetValueOrDefault() },
                },
                Oneoffimpacts = new CATPlotObj()
                {
                    ////Overall = con.HioneOffImpactsId.GetValueOrDefault(),
                    ////Plot1 = con.HioneOffImpactsPlot1Id.GetValueOrDefault(),
                    ////Plot2 = con.HioneOffImpactsPlot1Id.GetValueOrDefault(),
                    ////Plot3 = con.HioneOffImpactsPlot1Id.GetValueOrDefault(),
                    ////Plot4 = con.HioneOffImpactsPlot1Id.GetValueOrDefault(),
                    ////Plot5 = con.HioneOffImpactsPlot1Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.HioneOffImpactsId.GetValueOrDefault(), Value = con.HioneOffImpactsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.HioneOffImpactsPlot1Id.GetValueOrDefault(), Value = con.HioneOffImpactsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.HioneOffImpactsPlot2Id.GetValueOrDefault(), Value = con.HioneOffImpactsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.HioneOffImpactsPlot3Id.GetValueOrDefault(), Value = con.HioneOffImpactsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.HioneOffImpactsPlot4Id.GetValueOrDefault(), Value = con.HioneOffImpactsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.HioneOffImpactsPlot5Id.GetValueOrDefault(), Value = con.HioneOffImpactsPlot5Id.GetValueOrDefault() },

                }


            };

            return catHumanImpactsDTO;
        }
        
        public void UpdateCATHumanImpactsDTO(int Id, CATHumanImpactsDTO cafkfSummaries)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
 
            con.HinotesActions = cafkfSummaries.Notes;
            con.HiinterventionDesirable = cafkfSummaries.InterventionDesirable;
            con.HiinterventionAchievable= cafkfSummaries.InterventionAchievable;
            
            con.HicontinuousImpactsId = cafkfSummaries.Continuousimpacts.Overall.Value;
            con.HicontinuousImpactsPlot1Id = cafkfSummaries.Continuousimpacts.Plot1.Value;
            con.HicontinuousImpactsPlot2Id = cafkfSummaries.Continuousimpacts.Plot2.Value;
            con.HicontinuousImpactsPlot3Id = cafkfSummaries.Continuousimpacts.Plot3.Value;
            con.HicontinuousImpactsPlot4Id = cafkfSummaries.Continuousimpacts.Plot4.Value;
            con.HicontinuousImpactsPlot5Id = cafkfSummaries.Continuousimpacts.Plot5.Value;

            con.HioneOffImpactsId = cafkfSummaries.Oneoffimpacts.Overall.Value;
            con.HicontinuousImpactsPlot1Id = cafkfSummaries.Oneoffimpacts.Plot1.Value;
            con.HicontinuousImpactsPlot2Id = cafkfSummaries.Oneoffimpacts.Plot2.Value;
            con.HicontinuousImpactsPlot3Id = cafkfSummaries.Oneoffimpacts.Plot3.Value;
            con.HicontinuousImpactsPlot4Id = cafkfSummaries.Oneoffimpacts.Plot4.Value;
            con.HicontinuousImpactsPlot5Id = cafkfSummaries.Oneoffimpacts.Plot5.Value;



            Context.SaveChanges();

        }

        #endregion

        #region tree ages 
        public CATTreeAgesDTO GetCatTreeAgesDto(int Id)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);
            if (con == null) con = new WoodlandConditionSubSection();

            var cafTreeAges = new CATTreeAgesDTO()
            {
                Notes = con.TanotesActions,
                InterventionDesirable = con.TainterventionDesirable,
                InterventionAchievable = con.TainterventionAchievable,


                VeteranPollardsAncientCoppiceStools = new CATPlotObj()
                {
                    //Overall = con.TaveteranPollardsAncientCoppiceStoolsId.GetValueOrDefault(),
                    //Plot1 = con.TaveteranPollardsAncientCoppiceStoolsPlot1Id.GetValueOrDefault(),
                    //Plot2 = con.TaveteranPollardsAncientCoppiceStoolsPlot2Id.GetValueOrDefault(),
                    //Plot3 = con.TaveteranPollardsAncientCoppiceStoolsPlot3Id.GetValueOrDefault(),
                    //Plot4 = con.TaveteranPollardsAncientCoppiceStoolsPlot4Id.GetValueOrDefault(),
                    //Plot5 = con.TaveteranPollardsAncientCoppiceStoolsPlot5Id.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.TaveteranPollardsAncientCoppiceStoolsId.GetValueOrDefault(), Value = con.TaveteranPollardsAncientCoppiceStoolsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.TaveteranPollardsAncientCoppiceStoolsPlot1Id.GetValueOrDefault(), Value = con.TaveteranPollardsAncientCoppiceStoolsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.TaveteranPollardsAncientCoppiceStoolsPlot2Id.GetValueOrDefault(), Value = con.TaveteranPollardsAncientCoppiceStoolsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.TaveteranPollardsAncientCoppiceStoolsPlot3Id.GetValueOrDefault(), Value = con.TaveteranPollardsAncientCoppiceStoolsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.TaveteranPollardsAncientCoppiceStoolsPlot4Id.GetValueOrDefault(), Value = con.TaveteranPollardsAncientCoppiceStoolsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.TaveteranPollardsAncientCoppiceStoolsPlot5Id.GetValueOrDefault(), Value = con.TaveteranPollardsAncientCoppiceStoolsPlot5Id.GetValueOrDefault() },

                },
                FiftyHundredYears = new CATPlotObj()
                {
                    //Overall = con.Ta50100yearsId.GetValueOrDefault(),
                    //Plot1 = con.Ta50100yearsId.GetValueOrDefault(),
                    //Plot2 = con.Ta50100yearsId.GetValueOrDefault(),
                    //Plot3 = con.Ta50100yearsId.GetValueOrDefault(),
                    //Plot4 = con.Ta50100yearsId.GetValueOrDefault(),
                    //Plot5 = con.Ta50100yearsId.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.Ta50100yearsId.GetValueOrDefault(), Value = con.Ta50100yearsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.Ta50100yearsPlot1Id.GetValueOrDefault(), Value = con.Ta50100yearsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.Ta50100yearsPlot2Id.GetValueOrDefault(), Value = con.Ta50100yearsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.Ta50100yearsPlot3Id.GetValueOrDefault(), Value = con.Ta50100yearsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.Ta50100yearsPlot4Id.GetValueOrDefault(), Value = con.Ta50100yearsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.Ta50100yearsPlot5Id.GetValueOrDefault(), Value = con.Ta50100yearsPlot5Id.GetValueOrDefault() },

                },

                LessThanTwentyYears = new CATPlotObj()
                {
                    //Overall = con.Ta20yearsId.GetValueOrDefault(),
                    //Plot1 = con.Ta20yearsId.GetValueOrDefault(),
                    //Plot2 = con.Ta20yearsId.GetValueOrDefault(),
                    //Plot3 = con.Ta20yearsId.GetValueOrDefault(),
                    //Plot4 = con.Ta20yearsId.GetValueOrDefault(),
                    //Plot5 = con.Ta20yearsId.GetValueOrDefault(),


                    Overall = new Property<int>() { Original = con.Ta20yearsId.GetValueOrDefault(), Value = con.Ta20yearsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.Ta50100yearsPlot1Id.GetValueOrDefault(), Value = con.Ta50100yearsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.Ta50100yearsPlot2Id.GetValueOrDefault(), Value = con.Ta50100yearsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.Ta50100yearsPlot3Id.GetValueOrDefault(), Value = con.Ta50100yearsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.Ta50100yearsPlot4Id.GetValueOrDefault(), Value = con.Ta50100yearsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.Ta50100yearsPlot5Id.GetValueOrDefault(), Value = con.Ta50100yearsPlot5Id.GetValueOrDefault() },
                },

                OneTwoHundredYears = new CATPlotObj()
                {
                    //Overall = con.Ta100200yearsId.GetValueOrDefault(),
                    //Plot1 = con.Ta100200yearsId.GetValueOrDefault(),
                    //Plot2 = con.Ta100200yearsId.GetValueOrDefault(),
                    //Plot3 = con.Ta100200yearsId.GetValueOrDefault(),
                    //Plot4 = con.Ta100200yearsId.GetValueOrDefault(),
                    //Plot5 = con.Ta100200yearsId.GetValueOrDefault(),

                    Overall = new Property<int>() { Original = con.Ta100200yearsId.GetValueOrDefault(), Value = con.Ta100200yearsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.Ta100200yearsPlot1Id.GetValueOrDefault(), Value = con.Ta100200yearsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.Ta100200yearsPlot2Id.GetValueOrDefault(), Value = con.Ta100200yearsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.Ta100200yearsPlot3Id.GetValueOrDefault(), Value = con.Ta100200yearsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.Ta100200yearsPlot4Id.GetValueOrDefault(), Value = con.Ta100200yearsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.Ta100200yearsPlot5Id.GetValueOrDefault(), Value = con.Ta100200yearsPlot5Id.GetValueOrDefault() },
                },

                TwentyFiftyYears = new CATPlotObj()
                {
                    //Overall = con.Ta2050yearsId.GetValueOrDefault(),
                    //Plot1 = con.Ta2050yearsId.GetValueOrDefault(),
                    //Plot2 = con.Ta2050yearsId.GetValueOrDefault(),
                    //Plot3 = con.Ta2050yearsId.GetValueOrDefault(),
                    //Plot4 = con.Ta2050yearsId.GetValueOrDefault(),
                    //Plot5 = con.Ta2050yearsId.GetValueOrDefault(),


                    Overall = new Property<int>() { Original = con.Ta2050yearsId.GetValueOrDefault(), Value = con.Ta2050yearsId.GetValueOrDefault() },
                    Plot1 = new Property<int>() { Original = con.Ta2050yearsPlot1Id.GetValueOrDefault(), Value = con.Ta2050yearsPlot1Id.GetValueOrDefault() },
                    Plot2 = new Property<int>() { Original = con.Ta2050yearsPlot2Id.GetValueOrDefault(), Value = con.Ta2050yearsPlot2Id.GetValueOrDefault() },
                    Plot3 = new Property<int>() { Original = con.Ta2050yearsPlot3Id.GetValueOrDefault(), Value = con.Ta2050yearsPlot3Id.GetValueOrDefault() },
                    Plot4 = new Property<int>() { Original = con.Ta2050yearsPlot4Id.GetValueOrDefault(), Value = con.Ta2050yearsPlot4Id.GetValueOrDefault() },
                    Plot5 = new Property<int>() { Original = con.Ta2050yearsPlot5Id.GetValueOrDefault(), Value = con.Ta2050yearsPlot5Id.GetValueOrDefault() },
                }



            };

            return cafTreeAges;
        }
               
        public void UpdateCATTreeAgesDTO(int Id, CATTreeAgesDTO cafkfSummaries)
        {
            var con = Context.WoodlandConditionSubSection.FirstOrDefault(f => f.Id == Id);

            con.TanotesActions = cafkfSummaries.Notes;
            con.TainterventionAchievable = cafkfSummaries.InterventionAchievable;
            con.TainterventionDesirable = cafkfSummaries.InterventionDesirable;


            //Overall = con.TaveteranPollardsAncientCoppiceStoolsId.GetValueOrDefault(),

            con.TaveteranPollardsAncientCoppiceStoolsId =
                cafkfSummaries.VeteranPollardsAncientCoppiceStools.Overall.Value;
            con.TaveteranPollardsAncientCoppiceStoolsPlot1Id = cafkfSummaries.VeteranPollardsAncientCoppiceStools.Plot1.Value;
            con.TaveteranPollardsAncientCoppiceStoolsPlot2Id = cafkfSummaries.VeteranPollardsAncientCoppiceStools.Plot2.Value;
            con.TaveteranPollardsAncientCoppiceStoolsPlot3Id = cafkfSummaries.VeteranPollardsAncientCoppiceStools.Plot3.Value;
            con.TaveteranPollardsAncientCoppiceStoolsPlot4Id = cafkfSummaries.VeteranPollardsAncientCoppiceStools.Plot4.Value;
            con.TaveteranPollardsAncientCoppiceStoolsPlot5Id = cafkfSummaries.VeteranPollardsAncientCoppiceStools.Plot5.Value;
       
            
            //Overall = con.Ta50100yearsId.GetValueOrDefault(),
            con.Ta50100yearsId = cafkfSummaries.FiftyHundredYears.Overall.Value;
            con.Ta50100yearsPlot1Id = cafkfSummaries.FiftyHundredYears.Plot1.Value;
            con.Ta50100yearsPlot2Id = cafkfSummaries.FiftyHundredYears.Plot2.Value;
            con.Ta50100yearsPlot3Id = cafkfSummaries.FiftyHundredYears.Plot3.Value;
            con.Ta50100yearsPlot4Id = cafkfSummaries.FiftyHundredYears.Plot4.Value;
            con.Ta50100yearsPlot5Id = cafkfSummaries.FiftyHundredYears.Plot5.Value;

            //Overall = con.Ta20yearsId.GetValueOrDefault(
            con.Ta20yearsId = cafkfSummaries.FiftyHundredYears.Overall.Value;
            con.Ta20yearsPlot1Id = cafkfSummaries.FiftyHundredYears.Plot1.Value;
            con.Ta20yearsPlot2Id = cafkfSummaries.FiftyHundredYears.Plot2.Value;
            con.Ta20yearsPlot3Id = cafkfSummaries.FiftyHundredYears.Plot3.Value;
            con.Ta20yearsPlot4Id = cafkfSummaries.FiftyHundredYears.Plot4.Value;
            con.Ta20yearsPlot5Id = cafkfSummaries.FiftyHundredYears.Plot5.Value;

            //Overall = con.Ta100200yearsId.GetValueOrDefault(),
            //Overall = con.Ta2050yearsId.GetValueOrDefault(),


            Context.SaveChanges();
        }

        #endregion
    }
}
