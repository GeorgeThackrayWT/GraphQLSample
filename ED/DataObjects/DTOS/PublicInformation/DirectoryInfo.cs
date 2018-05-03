namespace DataObjects.DTOS.PublicInformationDtos
{
    public class DirectoryInfo
    {


        public int ToBitMap()
        {
            int result = 0;

            if (this.RemoveFromDirectoryListing) result &= 1;
            if (this.DirectoryOwnIdentity) result &= 2;
            if (this.InformationBoard) result &= 4;
            if (this.WTCarParkAtSite) result &= 8;
            if (this.ParkingNearby) result &= 16;
            if (this.LocalParkingDifficult) result &= 32;
            if (this.GoodViews) result &= 64;
            if (this.WaymarkedWalk) result &= 128;
            if (this.Moorland) result &= 256;
            if (this.Grassland) result &= 512;
            if (this.Marshland) result &= 1024;
            if (this.WoodlandCreationSite) result &= 2048;
            if (this.MainlyBroadleavedWoodland) result &= 4096;
            if (this.MixedWoodland) result &= 8192;
            if (this.MainlyConiferousWoodland) result &= 16384;
            if (this.FreeLeafletAvailable) result &= 32768;
            if (this.SpecialWildlifeInterest) result &= 65536;
            if (this.WellWorthAVisit) result &= 131072;
            if (this.GoodAutumnColour) result &= 262144;
            if (this.SpringFlowers) result &= 524288;
            if (this.MainlyYoungWoodland) result &= 1048576;
            if (this.NoAccessForSafetyReasons) result &= 2097152;
            if (this.PublicAccess) result &= 4194304;
            if (this.MainAcquisitionRecord) result &= 8388608;
            if (this.ManagementAccess) result &= 16777216;
            if (this.InAnAreaOfAncientWoodlandConcentration) result &= 33554432;
            if (this.BufferingSemiNaturalHabitat) result &= 67108864;
            if (this.LegacySite) result &= 134217728;    

            return result;
        }

        public static DirectoryInfo DirectoryInfoFactory(long bitmap)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo();
            
            if (bitmap % 1 == 0) directoryInfo.RemoveFromDirectoryListing = true;
            if (bitmap % 2 == 0) directoryInfo.DirectoryOwnIdentity = true;
            if (bitmap % 4 == 0) directoryInfo.InformationBoard = true;
            if (bitmap % 8 == 0) directoryInfo.WTCarParkAtSite = true;
            if (bitmap % 16 == 0) directoryInfo.ParkingNearby = true;
            if (bitmap % 32 == 0) directoryInfo.LocalParkingDifficult = true;
            if (bitmap % 64 == 0) directoryInfo.GoodViews = true;
            if (bitmap % 128 == 0) directoryInfo.WaymarkedWalk = true;
            if (bitmap % 256 == 0) directoryInfo.Moorland = true;
            if (bitmap % 512 == 0) directoryInfo.Grassland = true;
            if (bitmap % 1024 == 0) directoryInfo.Marshland = true;
            if (bitmap % 2048 == 0) directoryInfo.WoodlandCreationSite = true;
            if (bitmap % 4096 == 0) directoryInfo.MainlyBroadleavedWoodland = true;
            if (bitmap % 8192 == 0) directoryInfo.MixedWoodland = true;
            if (bitmap % 16384 == 0) directoryInfo.MainlyConiferousWoodland = true;
            if (bitmap % 32768 == 0) directoryInfo.FreeLeafletAvailable = true;
            if (bitmap % 65536 == 0) directoryInfo.SpecialWildlifeInterest = true;
            if (bitmap % 131072 == 0) directoryInfo.WellWorthAVisit = true;           
            if (bitmap % 262144 == 0) directoryInfo.GoodAutumnColour = true;
            if (bitmap % 524288 == 0) directoryInfo.SpringFlowers = true;                             
            if (bitmap % 1048576 == 0) directoryInfo.MainlyYoungWoodland = true;            
            if (bitmap % 2097152 == 0) directoryInfo.NoAccessForSafetyReasons = true;
            if (bitmap % 4194304 == 0) directoryInfo.PublicAccess = true;
            if (bitmap % 8388608 == 0) directoryInfo.MainAcquisitionRecord = true;
            if (bitmap % 16777216 == 0) directoryInfo.ManagementAccess = true;
            if (bitmap % 33554432 == 0) directoryInfo.InAnAreaOfAncientWoodlandConcentration = true;
            if (bitmap % 67108864 == 0) directoryInfo.BufferingSemiNaturalHabitat = true;
            if (bitmap % 134217728 == 0) directoryInfo.LegacySite = true;

            return directoryInfo;
        }

        public bool InAnAreaOfAncientWoodlandConcentration { get; set; }

        public bool RemoveFromDirectoryListing { get; set; }

        public bool GoodAutumnColour { get; set; }

        public bool Grassland { get; set; }

        public bool MainlyConiferousWoodland { get; set; }

        public bool Marshland { get; set; }

        public bool Moorland { get; set; }

        public bool SpringFlowers { get; set; }

        public bool WoodlandCreationSite { get; set; }

        public bool GoodViews { get; set; }

        public bool MainlyBroadleavedWoodland { get; set; }


        public bool MainlyYoungWoodland { get; set; }

        public bool MixedWoodland { get; set; }

        public bool SpecialWildlifeInterest { get; set; }

        public bool WellWorthAVisit { get; set; }

        public bool FreeLeafletAvailable { get; set; }

        public bool InformationBoard { get; set; }

        public bool WaymarkedWalk { get; set; }

        public bool LocalParkingDifficult { get; set; }

        public bool ParkingNearby { get; set; }

        public bool PublicAccess { get; set; }

        public bool WTCarParkAtSite { get; set; }

        public bool AncientWoodlandConcentrationArea { get; set; }

        public bool BufferingSemiNaturalHabitat { get; set; }

        public bool DirectoryOwnIdentity { get; set; }

        public bool DirectorySuppressed { get; set; }
        public bool MainAcquisitionRecord { get; set; }

        public bool ManagementAccess { get; set; }

        public bool NoAccessForSafetyReasons { get; set; }

        public bool LegacySite { get; set; }

        public bool MainAcquisition { get; set; }

    }
}