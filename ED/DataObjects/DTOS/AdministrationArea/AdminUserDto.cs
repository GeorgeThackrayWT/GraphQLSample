namespace DataObjects.DTOS.AdministrationArea
{
    public class AdminUserDto
    {
        public int ID { get; set; }

        public string LoginName { get; set; }

        public string DisplayName { get; set; }

        public int RegionID { get; set; }

        public string Country { get; set; }

        public bool Status { get; set; }

        public string Email { get; set; }

    }
}