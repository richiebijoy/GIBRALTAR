using FluentValidation;
namespace GIBRALTAR_Project.Models

{
    public class PatientDetailsValidator : AbstractValidator<PatientDetails>
    {
        public PatientDetailsValidator()
        {
            RuleFor(patient => patient.Id).NotEmpty();
            RuleFor(patient => patient.Address).NotEmpty();
            RuleFor(patient => patient.FirstName).NotEmpty();
            RuleFor(patient => patient.LastName).NotEmpty();
            RuleFor(patient => patient.Vaccinated).NotEmpty();
            RuleFor(patient => patient.BloodType).NotEmpty();
            RuleFor(patient => patient.DOB).NotNull();
        }
    }
}
