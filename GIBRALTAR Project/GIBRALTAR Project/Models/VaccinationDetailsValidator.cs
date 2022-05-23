using FluentValidation;
namespace GIBRALTAR_Project.Models
{
    public class VaccinationDetailsValidator : AbstractValidator<VaccinationDetails>
    {
        public VaccinationDetailsValidator()
        {
            RuleFor(patient=>patient.Vaccinated).NotEmpty();
            RuleFor(patient=>patient.Id).NotEmpty();
            RuleFor(patient=>patient.VaccinationName1).NotNull();
            RuleFor(patient=>patient.VaccinationName2).NotNull();
            RuleFor(patient=>patient.Booster).NotNull();
        }
    }
}
