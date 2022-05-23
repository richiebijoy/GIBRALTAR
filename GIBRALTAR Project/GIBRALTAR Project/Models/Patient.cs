namespace GIBRALTAR_Project.Models
{
    public class Patient
    {
        //Primary Key
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DOB { get; set; }
        public string Address { get; set; } = string.Empty;
        public string BloodType { get; set; } = string.Empty;
        public string Vaccinated { get; set; } = string.Empty;
        public string? VaccinationName1 { get; set; } = string.Empty;
        public DateTime? Dose1 { get; set; }
        public string? VaccinationName2 { get; set; } = string.Empty;
        public DateTime? Dose2 { get; set; }
        public string? Booster { get; set; } = string.Empty;
        public DateTime? Dose3 { get; set; }
    }
}
