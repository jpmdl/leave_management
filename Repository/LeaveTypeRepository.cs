using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;

namespace leave_management.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;   // Dependency Injection (1st step)
        }

        // Returning all (select * from table)
        public ICollection<LeaveType> FindAll()
        {
            return _db.LeaveTypes.ToList();    // _db.LeaveTypes is just like `select * from LeaveTypes`
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public LeaveType FindById(int id)
        {
            // Another way: _db.LeaveTypes.FirstOrDefault(lt => lt.Id == id)
            return _db.LeaveTypes.Find(id);
        }

        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity); // LeaveTypes is like a collection and we're adding a new item to that collection.
            return Save();
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        // Commit method
        public bool Save()
        {
            int changes = _db.SaveChanges();  // Returns integer for how many records changed.
            return changes > 0;
        }

        public bool Exists(int id)
        {
            return _db.LeaveTypes.Any(q => q.Id == id);
        }
    }
}