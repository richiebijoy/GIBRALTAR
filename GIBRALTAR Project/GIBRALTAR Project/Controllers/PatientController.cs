using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GIBRALTAR_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        IBusiness _business;
        public PatientController(IBusiness business)
        {
            _business = business;
        }
        [HttpGet]
        public async Task<ActionResult<List<PatientDetails>>> GetAll()
        {
            try
            {
                return Ok(_business.GetAllPatients());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PatientDetails>> GetPatient(int id)
        {
            try
            {
                var patient = _business.GetPatient(id);
                if (patient == null)
                    return BadRequest("Patient does not exist.");
                return Ok(patient);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPost]
        public async Task<ActionResult<string>> AddPatient(PatientDetails patientDetails)
        {
            try
            {
                var result = _business.AddNewPatient(patientDetails);
                if (result == "Patient Added Successfully") return Ok(result);
                else
                    return BadRequest(result);

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPut]
        public async Task<ActionResult<string>> UpdatePatient(PatientDetails patientDetails)
        {
            try
            {
                var result = _business.UpdatePatient(patientDetails);
                if (result == "Patient Details Updated Successfully")
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
        public async Task<ActionResult<string>> DeletePatient(int id)
        {
            try
            {
                var result = _business.DeletePatient(id);
                if (result == "Patient deleted.")
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
