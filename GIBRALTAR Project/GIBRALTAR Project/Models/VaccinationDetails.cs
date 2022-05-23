namespace GIBRALTAR_Project.Models
{
    public class VaccinationDetails
    {
        //Foreign Key
        public int Id { get; set; }
        public string Vaccinated { get; set; } = string.Empty;
        public string? VaccinationName1 { get; set; } = string.Empty;
        public DateTime? Dose1 { get; set; }
        public string? VaccinationName2 { get; set; } = string.Empty;
        public DateTime? Dose2 { get; set; }
        public string? Booster { get; set; } = string.Empty;
        public DateTime? Dose3 { get; set; }

    }
    //private List<VaccinationDetails> VaccinationDetails = new List<VaccinationDetails>
    //{
    //    new VaccinationDetails
    //    {
    //        Id=1,
    //        VaccinationName1="Covishield",
    //        Dose1=new DateTime(2021,5,16),
    //        VaccinationName2="Covishield",
    //        Dose2=new DateTime(2021,6,16),
    //        Booster="Pfizer",
    //        Dose3=new DateTime(2022,1,16)
    //    },
    //    new VaccinationDetails
    //    {
    //        Id=2,
    //        VaccinationName1="Covishield",
    //        Dose1=new DateTime(2021,5,26),
    //        VaccinationName2="Covishield",
    //        Dose2=new DateTime(2021,6,26),
    //        Booster="Pfizer",
    //        Dose3=new DateTime(2022,1,26)
    //    }
    //};
}
