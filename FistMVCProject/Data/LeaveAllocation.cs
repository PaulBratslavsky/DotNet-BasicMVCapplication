using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FistMVCProject.Data
{
    public class LeaveAllocation
    {
        [Key]
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public Employee Employee { get; set; }
        [ForeignKey("EmployeeId")]       
        public string EmployeeId { get; set; }
        [ForeignKey("LeaveTypeId")] 
        public LeaveType LeaveType { get; set; }
        public string LeaveTyprId { get; set; }
    }
}