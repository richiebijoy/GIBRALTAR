namespace GIBRALTAR_Project.DataLayer.Interfaces
{
    public interface IData
    {
        List<Patient> GetAllPatients();
        string AddNewPatient(PatientDetails patientDetails);
        string UpdatePatient(PatientDetails patientDetails);
        string DeletePatient(int id);
        List<Patient> GetAllPatientsVaccinationDetails();
        string AddPatientVaccinationDetails(VaccinationDetails patientVaccinationDetails);
        string UpdatePatientVaccinationDetails(VaccinationDetails patientVaccinationDetails);
        string DeletePatientVaccinationDetails(int id);
    }
}
