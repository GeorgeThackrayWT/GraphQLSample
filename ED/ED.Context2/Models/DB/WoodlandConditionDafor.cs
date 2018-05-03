using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class WoodlandConditionDafor
    {
        public WoodlandConditionDafor()
        {
            WoodlandConditionSubSectionAddeer = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAddeerPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAddeerPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAddeerPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAddeerPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAddeerPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdother = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdotherPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdotherPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdotherPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdotherPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdotherPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdrabBits = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdrabBitsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdrabBitsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdrabBitsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdrabBitsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdrabBitsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdsquirrels = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdsquirrelsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdsquirrelsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdsquirrelsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdsquirrelsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionAdsquirrelsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionDfallen = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionDfallenPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionDfallenPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionDfallenPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionDfallenPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionDfallenPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionDstanding = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionDstandingPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionDstandingPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionDstandingPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionDstandingPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionDstandingPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFancientWoodlandPlantsSpecialists = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFcoarseVegetation = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFcoarseVegetationPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFcoarseVegetationPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFcoarseVegetationPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFcoarseVegetationPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFcoarseVegetationPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFnoVegetation = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFnoVegetationPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFnoVegetationPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFnoVegetationPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFnoVegetationPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFnoVegetationPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherNativePlants = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherNativePlantsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherNativePlantsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherNativePlantsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherNativePlantsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherNativePlantsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherPlants = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherPlantsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherPlantsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherPlantsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherPlantsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherPlantsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherWoodlandPlantsGeneralists = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionHicontinuousImpacts = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionHicontinuousImpactsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionHicontinuousImpactsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionHicontinuousImpactsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionHicontinuousImpactsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionHicontinuousImpactsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionHioneOffImpacts = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionHioneOffImpactsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionHioneOffImpactsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionHioneOffImpactsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionHioneOffImpactsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionHioneOffImpactsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIhimalayanBalsam = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIhimalayanBalsamPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIhimalayanBalsamPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIhimalayanBalsamPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIhimalayanBalsamPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIhimalayanBalsamPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIjapaneseKnotweed = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIjapaneseKnotweedPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIjapaneseKnotweedPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIjapaneseKnotweedPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIjapaneseKnotweedPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIjapaneseKnotweedPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIother = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIotherPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIotherPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIotherPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIotherPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIotherPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIrhododendron = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIrhododendronPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIrhododendronPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIrhododendronPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIrhododendronPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionIrhododendronPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckering = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrsaplingsGreater100cm = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrseedlings10100cm = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrseedlings10100cmPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrseedlings10100cmPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrseedlings10100cmPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrseedlings10100cmPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrseedlings10100cmPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrseedlingsLess10cm = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrseedlingsLess10cmPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrseedlingsLess10cmPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrseedlingsLess10cmPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrseedlingsLess10cmPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLsrseedlingsLess10cmPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckering = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrsaplingsGreater100cm = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrseedlings10100cm = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrseedlings10100cmPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrseedlings10100cmPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrseedlings10100cmPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrseedlings10100cmPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrseedlings10100cmPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrseedlingsLess10cm = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrseedlingsLess10cmPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrseedlingsLess10cmPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrseedlingsLess10cmPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrseedlingsLess10cmPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionLtrseedlingsLess10cmPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionSsdaforofCover = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionSsdaforofCoverPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionSsdaforofCoverPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionSsdaforofCoverPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionSsdaforofCoverPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionSsdaforofCoverPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa100200years = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa100200yearsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa100200yearsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa100200yearsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa100200yearsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa100200yearsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa2050years = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa2050yearsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa2050yearsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa2050yearsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa2050yearsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa2050yearsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa20years = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa20yearsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa20yearsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa20yearsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa20yearsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa20yearsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa50100years = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa50100yearsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa50100yearsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa50100yearsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa50100yearsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTa50100yearsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStools = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionThnotifiablePestOrDisease = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot5 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionThotherDiseaseOrPest = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionThotherDiseaseOrPestPlot1 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionThotherDiseaseOrPestPlot2 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionThotherDiseaseOrPestPlot3 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionThotherDiseaseOrPestPlot4 = new HashSet<WoodlandConditionSubSection>();
            WoodlandConditionSubSectionThotherDiseaseOrPestPlot5 = new HashSet<WoodlandConditionSubSection>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
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

        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAddeer { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAddeerPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAddeerPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAddeerPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAddeerPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAddeerPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdother { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdotherPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdotherPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdotherPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdotherPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdotherPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdrabBits { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdrabBitsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdrabBitsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdrabBitsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdrabBitsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdrabBitsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdsquirrels { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdsquirrelsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdsquirrelsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdsquirrelsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdsquirrelsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionAdsquirrelsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionDfallen { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionDfallenPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionDfallenPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionDfallenPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionDfallenPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionDfallenPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionDstanding { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionDstandingPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionDstandingPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionDstandingPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionDstandingPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionDstandingPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFancientWoodlandPlantsSpecialists { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFcoarseVegetation { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFcoarseVegetationPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFcoarseVegetationPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFcoarseVegetationPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFcoarseVegetationPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFcoarseVegetationPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFnoVegetation { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFnoVegetationPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFnoVegetationPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFnoVegetationPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFnoVegetationPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFnoVegetationPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherNativePlants { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherNativePlantsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherNativePlantsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherNativePlantsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherNativePlantsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherNativePlantsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherPlants { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherPlantsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherPlantsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherPlantsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherPlantsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherPlantsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherWoodlandPlantsGeneralists { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionHicontinuousImpacts { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionHicontinuousImpactsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionHicontinuousImpactsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionHicontinuousImpactsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionHicontinuousImpactsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionHicontinuousImpactsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionHioneOffImpacts { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionHioneOffImpactsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionHioneOffImpactsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionHioneOffImpactsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionHioneOffImpactsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionHioneOffImpactsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIhimalayanBalsam { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIhimalayanBalsamPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIhimalayanBalsamPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIhimalayanBalsamPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIhimalayanBalsamPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIhimalayanBalsamPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIjapaneseKnotweed { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIjapaneseKnotweedPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIjapaneseKnotweedPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIjapaneseKnotweedPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIjapaneseKnotweedPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIjapaneseKnotweedPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIother { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIotherPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIotherPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIotherPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIotherPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIotherPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIrhododendron { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIrhododendronPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIrhododendronPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIrhododendronPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIrhododendronPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionIrhododendronPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckering { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrsaplingsGreater100cm { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrseedlings10100cm { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrseedlings10100cmPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrseedlings10100cmPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrseedlings10100cmPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrseedlings10100cmPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrseedlings10100cmPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrseedlingsLess10cm { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrseedlingsLess10cmPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrseedlingsLess10cmPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrseedlingsLess10cmPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrseedlingsLess10cmPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLsrseedlingsLess10cmPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckering { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrsaplingsGreater100cm { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrseedlings10100cm { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrseedlings10100cmPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrseedlings10100cmPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrseedlings10100cmPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrseedlings10100cmPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrseedlings10100cmPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrseedlingsLess10cm { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrseedlingsLess10cmPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrseedlingsLess10cmPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrseedlingsLess10cmPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrseedlingsLess10cmPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionLtrseedlingsLess10cmPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionSsdaforofCover { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionSsdaforofCoverPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionSsdaforofCoverPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionSsdaforofCoverPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionSsdaforofCoverPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionSsdaforofCoverPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa100200years { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa100200yearsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa100200yearsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa100200yearsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa100200yearsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa100200yearsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa2050years { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa2050yearsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa2050yearsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa2050yearsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa2050yearsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa2050yearsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa20years { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa20yearsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa20yearsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa20yearsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa20yearsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa20yearsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa50100years { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa50100yearsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa50100yearsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa50100yearsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa50100yearsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTa50100yearsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStools { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionThnotifiablePestOrDisease { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot5 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionThotherDiseaseOrPest { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionThotherDiseaseOrPestPlot1 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionThotherDiseaseOrPestPlot2 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionThotherDiseaseOrPestPlot3 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionThotherDiseaseOrPestPlot4 { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSectionThotherDiseaseOrPestPlot5 { get; set; }
        public virtual User Lmu { get; set; }
    }
}
