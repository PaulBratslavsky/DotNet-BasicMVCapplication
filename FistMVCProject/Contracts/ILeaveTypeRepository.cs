using System.Collections.Generic;
using FistMVCProject.Data;

namespace FistMVCProject.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeeByLeaveType(int id);
    }
}