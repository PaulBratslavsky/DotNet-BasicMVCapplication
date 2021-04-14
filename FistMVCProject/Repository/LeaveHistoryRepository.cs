using System.Collections.Generic;
using FistMVCProject.Contracts;
using FistMVCProject.Data;

namespace FistMVCProject.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveHistory entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(LeaveHistory entity)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public LeaveHistory FindById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(LeaveHistory entity)
        {
            throw new System.NotImplementedException();
        }
    }
}