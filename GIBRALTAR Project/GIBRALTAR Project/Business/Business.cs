using GIBRALTAR_Project.DataLayer.Interfaces;
using GIBRALTAR_Project.Business.Interfaces;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;

namespace GIBRALTAR_Project.Business
{
    public class Business : IBusiness
    {
        IData _data;
        public Business(IData data)
        {
            _data = data;
        }
        public List<PatientDetails> GetAllPatients()
        {
            try
            {
                List<Patient> patients = _data.GetAllPatients();
                List<PatientDetails> patientDetails = patients.Select(x => new PatientDetails
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Address = x.Address,
                    DOB = x.DOB,
                    BloodType = x.BloodType,
                    Vaccinated = x.Vaccinated
                }).ToList();
                return patientDetails;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public PatientDetails GetPatient(int id)
        {
            try
            {
                var patients = _data.GetAllPatients();
                var patient = patients.Find(x => x.Id == id);
                if (patient != null)
                    return new PatientDetails
                    {
                        Id = patient.Id,
                        FirstName = patient.FirstName,
                        LastName = patient.LastName,
                        Address = patient.Address,
                        DOB = patient.DOB,
                        BloodType = patient.BloodType,
                        Vaccinated = patient.Vaccinated
                    };
                else
                    return null;
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
                PatientDetailsValidator validator = new PatientDetailsValidator();
                ValidationResult results = validator.Validate(patientDetails);

                if (!results.IsValid)
                {
                    string errors = string.Empty;
                    foreach (var failure in results.Errors)
                    {
                        errors += "Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage + " .";
                    }
                    return errors;
                }
                return _data.AddNewPatient(patientDetails);
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
                PatientDetailsValidator validator = new PatientDetailsValidator();
                ValidationResult results = validator.Validate(patientDetails);

                if (!results.IsValid)
                {
                    string errors = string.Empty;
                    foreach (var failure in results.Errors)
                    {
                        errors += "Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage + " .";
                    }
                    return errors;
                }
                return _data.UpdatePatient(patientDetails);
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
                return _data.DeletePatient(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<VaccinationDetails> GetAllPatientsVaccinationDetails()
        {
            try
            {
                var patients = _data.GetAllPatients();
                List<VaccinationDetails> vaccinationDetails = patients.Select(x => new VaccinationDetails
                {
                    Id = x.Id,
                    VaccinationName1 = x.VaccinationName1,
                    Dose1 = x.Dose1,
                    VaccinationName2 = x.VaccinationName2,
                    Dose2 = x.Dose2,
                    Booster = x.Booster,
                    Dose3 = x.Dose3,
                    Vaccinated = x.Vaccinated

                }).ToList();
                return vaccinationDetails;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public VaccinationDetails GetPatientVaccinationDetails(int id)
        {
            try
            {
                var patientsVaccinationDetails = _data.GetAllPatientsVaccinationDetails();
                var patientVaccinationDetails = patientsVaccinationDetails.Find(x => x.Id == id);
                if (patientVaccinationDetails != null)
                    return new VaccinationDetails
                    {
                        Id = patientVaccinationDetails.Id,
                        VaccinationName1 = patientVaccinationDetails.VaccinationName1,
                        Dose1 = patientVaccinationDetails.Dose1,
                        VaccinationName2 = patientVaccinationDetails.VaccinationName2,
                        Dose2 = patientVaccinationDetails.Dose2,
                        Booster = patientVaccinationDetails.Booster,
                        Dose3 = patientVaccinationDetails.Dose3,
                        Vaccinated = patientVaccinationDetails.Vaccinated
                    };
                else
                    return null;
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
                VaccinationDetailsValidator validator = new VaccinationDetailsValidator();
                ValidationResult results = validator.Validate(patientVaccinationDetails);

                if (!results.IsValid)
                {
                    string errors = string.Empty;
                    foreach (var failure in results.Errors)
                    {
                        errors += "Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage + " .";
                    }
                    return errors;
                }
                return _data.AddPatientVaccinationDetails(patientVaccinationDetails);
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
                VaccinationDetailsValidator validator = new VaccinationDetailsValidator();
                ValidationResult results = validator.Validate(patientVaccinationDetails);

                if (!results.IsValid)
                {
                    string errors = string.Empty;
                    foreach (var failure in results.Errors)
                    {
                        errors += "Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage + " .";
                    }
                    return errors;
                }
                return _data.UpdatePatientVaccinationDetails(patientVaccinationDetails);
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
                return _data.DeletePatientVaccinationDetails(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
