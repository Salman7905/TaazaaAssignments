using ContactRepositoryPractice.Models;
using System.Collections.Generic;
namespace ContactRepositoryPractice.Repository
{
    public interface IEmployee
    {
        void Add(Employee employee);
        void Update(Employee employee);
        void Remove(int id);
        Employee Find(int id);
        List<Employee> GetAll();
    }
}