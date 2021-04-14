using System.Collections.Generic;
using FistMVCProject.Contracts;
using FistMVCProject.Data;

namespace FistMVCProject.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;

        public EmployeeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Employee entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Employee entity)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Employee> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Employee FindById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Employee entity)
        {
            throw new System.NotImplementedException();
        }
    }
}