namespace DataObjects.DTOS.PublicInformationDtos
{
    public class PublicInformationSearchDto : SearchBase
    {

        public int ID { get; set; }

        public string GridReference { get; set; }

        public string PostCode { get; set; }

        public bool? PhotoLibrary { get; set; }

        public string Facilities { get; set; }

        public string DirectionDescription { get; set; }

        public DirectoryInfo DirectoryInfo { get; set; }
    }
}