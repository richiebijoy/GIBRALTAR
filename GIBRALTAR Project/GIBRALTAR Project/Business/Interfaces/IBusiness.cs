namespace GIBRALTAR_Project.Business.Interfaces
{
    public interface IBusiness
    {
        List<PatientDetails> GetAllPatients();
        string AddNewPatient(PatientDetails patientDetails);
        string UpdatePatient(PatientDetails patientDetails);
        string DeletePatient(int id);
        PatientDetails GetPatient(int id);
        List<VaccinationDetails> GetAllPatientsVaccinationDetails();
        VaccinationDetails GetPatientVaccinationDetails(int id);
        string AddPatientVaccinationDetails(VaccinationDetails patientVaccinationDetails);
        string UpdatePatientVaccinationDetails(VaccinationDetails patientVaccinationDetails);
        string DeletePatientVaccinationDetails(int id);
    }
}
