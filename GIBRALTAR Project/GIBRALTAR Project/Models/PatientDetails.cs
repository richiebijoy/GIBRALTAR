namespace GIBRALTAR_Project.Models
{
    public class PatientDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DOB { get; set; }
        public string Address { get; set; } = string.Empty;
        public string BloodType { get; set; } = string.Empty;
        public string Vaccinated { get; set; } = string.Empty;
    }
}
