using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GIBRALTAR_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationDetailsController : ControllerBase
    {
        IBusiness _business;
        public VaccinationDetailsController(IBusiness business)
        {
            _business = business;
        }
        [HttpGet]
        public async Task<ActionResult<List<VaccinationDetails>>> GetAll()
        {
            try
            {
                return Ok(_business.GetAllPatientsVaccinationDetails());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<VaccinationDetails>> GetPatientVaccinationDetails(int id)
        {
            try
            {
                var result = _business.GetPatientVaccinationDetails(id);
                if (result != null)
                    return Ok(result);
                else
                    return BadRequest(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPost]
        public async Task<ActionResult<string>> AddPatientVaccinationDetails(VaccinationDetails vaccinationDetails)
        {
            try
            {
                var result = _business.AddPatientVaccinationDetails(vaccinationDetails);
                if (result == "Patient Vaccination Details Added")
                    return Ok(result);
                else
                    return BadRequest(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPut]
        public async Task<ActionResult<string>> UpdatePatientVaccinationDetails(VaccinationDetails vaccinationDetails)
        {
            try
            {
                var result = _business.UpdatePatientVaccinationDetails(vaccinationDetails);
                if (result == "Patient Vaccination Details Updated")
                    return Ok(result);
                else
                    return BadRequest(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> DeletePatientVaccinationDetails(int id)
        {
            try
            {
                var result = _business.DeletePatientVaccinationDetails(id);
                if (result == "Patient Vaccination Details Deleted")
                    return Ok(result);
                else
                    return BadRequest(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
