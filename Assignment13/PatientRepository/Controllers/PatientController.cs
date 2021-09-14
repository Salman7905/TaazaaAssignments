using System;
using Microsoft.AspNetCore.Mvc;
using PatientRepository.Models;

namespace PatientRepository.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController:ControllerBase
    {
        IPatientRepository ipatientRepository;
        public PatientController(IPatientRepository _ipatientRepository)
        {
            ipatientRepository = _ipatientRepository;
        }
        [HttpPost("Add")]
        public IActionResult createPatient(Patient patient)
        {
            ipatientRepository.AddPatientRecord(patient);
            return Ok("Record added successfully!");
        }
        [HttpPut]
        public IActionResult updatePatient(Patient patient)
        {
            if(ModelState.IsValid)
            {
              ipatientRepository.UpdatePatientRecord(patient);
              return Ok("Record updated successfully");
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult deletePatient(string id)
        {
            if(ModelState.IsValid)
            {
                ipatientRepository.DeletePatientRecord(id);
                return Ok("Record deleted successfully");
            }
            return BadRequest();
        }
        [HttpGet("{id}")]
        public IActionResult searchPatient(string id)
        {
            if(ModelState.IsValid)
            {
                var record = ipatientRepository.GetPatientSingleRecord(id);
                return Ok("Record found ! "+"\nName : "+record.name+"\nAge : "+record.age+"\nCity : "+record.city+"\nAddress : "+record.address);
            }
            return BadRequest();
        }
        [HttpGet("Lists")]
        public IActionResult allPatientRecords()
        {
            if(ModelState.IsValid)
            {
                return Ok(ipatientRepository.GetPatientRecords());
            }
            return BadRequest();
        }
    }
}