using System.Collections.Generic;
using FistMVCProject.Contracts;

namespace FistMVCProject.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Data.LeaveAllocation entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Data.LeaveAllocation entity)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Data.LeaveAllocation> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Data.LeaveAllocation FindById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Data.LeaveAllocation entity)
        {
            throw new System.NotImplementedException();
        }
    }
}