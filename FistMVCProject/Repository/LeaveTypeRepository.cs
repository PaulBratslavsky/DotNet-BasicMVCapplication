using System.Collections.Generic;
using FistMVCProject.Contracts;
using FistMVCProject.Data;

namespace FistMVCProject.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveType entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(LeaveType entity)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<LeaveType> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public LeaveType FindById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<LeaveType> GetEmployeeByLeaveType()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<LeaveType> GetEmployeeByLeaveType(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(LeaveType entity)
        {
            throw new System.NotImplementedException();
        }
    }
}