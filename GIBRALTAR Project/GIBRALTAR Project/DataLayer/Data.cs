using FluentValidation.Results;
using GIBRALTAR_Project.DataLayer.Interfaces;
using System.Linq;
namespace GIBRALTAR_Project.DataLayer
{
    public class Data : IData
    {
        private List<Patient> _patients = new List<Patient>
        {
            new Patient{
                Id = 1,
                FirstName ="Richie",
                LastName ="Bijoy",
                DOB = new DateTime(1996,2,26),
                Address ="Dubai",
                BloodType ="O positive",
                Vaccinated="Second Dose",
                VaccinationName1="Covishield",
                Dose1=new DateTime(2021,5,16),
                VaccinationName2="Covishield",
                Dose2=new DateTime(2021,6,16),
                Booster="Pfizer",
                Dose3=new DateTime(2022,1,16)
            },
            new Patient
            {
                Id = 2,
                FirstName ="Leena",
                LastName ="Bijoy",
                DOB = new DateTime(1968,5,16),
                Address ="Dubai",
                BloodType ="B positive",
                Vaccinated="Second Dose",
                VaccinationName1="Covishield",
                Dose1=new DateTime(2021,5,26),
                VaccinationName2="Covishield",
                Dose2=new DateTime(2021,6,26),
                Booster="Pfizer",
                Dose3=new DateTime(2022,1,26)
            }
        };

        public List<Patient> GetAllPatients()
        {
            try
            {
                return _patients;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public string AddNewPatient(PatientDetails patientDetails)
        {
            try
            {
                if (_patients.Any(x => x.Id == patientDetails.Id))
                    return "Id already exists.";

                Patient patient = new Patient
                {
                    Id = patientDetails.Id,
                    FirstName = patientDetails.FirstName,
                    LastName = patientDetails.LastName,
                    Address = patientDetails.Address,
                    DOB = patientDetails.DOB,
                    BloodType = patientDetails.BloodType,
                    Vaccinated = patientDetails.Vaccinated
                };
                _patients.Add(patient);
                if (_patients.Contains(patient))
                    return "Patient Added Successfully";
                else
                    return "Patient not added";
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public string UpdatePatient(PatientDetails patientDetails)
        {
            try
            {
                
                var patient = _patients.Find(x => x.Id == patientDetails.Id);
                if (patient == null)
                    return "Patient does not exist.";

                patient.Id = patientDetails.Id;
                patient.FirstName = patientDetails.FirstName;
                patient.LastName = patientDetails.LastName;
                patient.Address = patientDetails.Address;
                patient.DOB = patientDetails.DOB;
                patient.BloodType = patientDetails.BloodType;
                patient.Vaccinated = patientDetails.Vaccinated;

                if (_patients.Contains(patient))
                    return "Patient Details Updated Successfully";
                else
                    return "Patient Details Not Updated";
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public string DeletePatient(int id)
        {
            try
            {
                var patient = _patients.Find(x => x.Id == id);
                if (patient == null)
                    return "Patient does not exist.";
                _patients.Remove(patient);
                return "Patient deleted.";

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Patient> GetAllPatientsVaccinationDetails()
        {
            try
            {
                return _patients;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public string AddPatientVaccinationDetails(VaccinationDetails patientVaccinationDetails)
        {
            try
            {
                var patient = _patients.Find(x => x.Id == patientVaccinationDetails.Id);
                if (patient != null && patient.Dose1 == null)
                {
                    patient.Vaccinated = patientVaccinationDetails.Vaccinated;
                    patient.VaccinationName1 = patientVaccinationDetails.VaccinationName1;
                    patient.Dose1 = patientVaccinationDetails.Dose1;
                    patient.VaccinationName2 = patientVaccinationDetails.VaccinationName2;
                    patient.Dose2 = patientVaccinationDetails.Dose2;
                    patient.Booster = patientVaccinationDetails.Booster;
                    patient.Dose3 = patientVaccinationDetails.Dose3;
                    return "Patient Vaccination Details Added";
                }
                else if (patient != null && patient.Dose1 != null) return "Use UpdatePatientVaccinationDetails Method";
                else return "Patient does not exist";

            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public string UpdatePatientVaccinationDetails(VaccinationDetails patientVaccinationDetails)
        {
            try
            {
                var patient = _patients.Find(x => x.Id == patientVaccinationDetails.Id);
                if (patient != null)
                {
                    patient.Vaccinated = patientVaccinationDetails.Vaccinated;
                    patient.VaccinationName1 = patientVaccinationDetails.VaccinationName1;
                    patient.Dose1 = patientVaccinationDetails.Dose1;
                    patient.VaccinationName2 = patientVaccinationDetails.VaccinationName2;
                    patient.Dose2 = patientVaccinationDetails.Dose2;
                    patient.Booster = patientVaccinationDetails.Booster;
                    patient.Dose3 = patientVaccinationDetails.Dose3;
                    return "Patient Vaccination Details Updated";
                }
                else return "Patient does not exist";

            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public string DeletePatientVaccinationDetails(int id)
        {
            try
            {
                var patient = _patients.Find(x => x.Id == id);
                if (patient != null)
                {
                    patient.Vaccinated = "Not Vaccinated";
                    patient.VaccinationName1 = "";
                    patient.Dose1 = null;
                    patient.VaccinationName2 = "";
                    patient.Dose2 = null;
                    patient.Booster = "";
                    patient.Dose3 = null;
                    return "Patient Vaccination Details Deleted";
                }
                else return "Patient does not exist";

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
