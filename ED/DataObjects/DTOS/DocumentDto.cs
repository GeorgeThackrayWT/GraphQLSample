namespace DataObjects.DTOS
{
    public class DocumentDto
    {
        public string DocumentName { get; set; }
        public string Cabinet { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }

        public string Length { get; set; }

        public string Status { get; set; }

        public string ErrorMessage { get; set; }

        public string Date { get; set; }

        public string UserName { get; set; }

    }
}