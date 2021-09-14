using System.Collections.Generic;
using PatientRepository.DataAccess;
using PatientRepository.Models;
using System.Linq;

namespace PatientRepository
{
    public class PatientRepository : IPatientRepository
    {
        PatientDBContext patientDBContext;
        public PatientRepository(PatientDBContext _patientDBContext)
        {
            patientDBContext = _patientDBContext;
        }
        void IPatientRepository.AddPatientRecord(Patient patient)
        {
           patientDBContext.Add(patient);
           patientDBContext.SaveChanges(); // commit and save records in db
        }


        List<Patient> IPatientRepository.GetPatientRecords()
        {
           return patientDBContext.patients.ToList();
        }

        Patient IPatientRepository.GetPatientSingleRecord(string id)
        {
             var patientToSearch = patientDBContext.patients.FirstOrDefault(e=>e.id == id);
             return patientToSearch;
        }

        void IPatientRepository.UpdatePatientRecord(Patient patient)
        {
             patientDBContext.patients.Update(patient);  
             patientDBContext.SaveChanges();  
        }
        void IPatientRepository.DeletePatientRecord(string id)
        {
            var patientToDelete = patientDBContext.patients.FirstOrDefault(t => t.id == id);  
            patientDBContext.patients.Remove(patientToDelete);  
            patientDBContext.SaveChanges();  
        }
    }
}