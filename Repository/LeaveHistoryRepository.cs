using leave_management.Contracts;
using leave_management.Data;
using System.Collections.Generic;
using System;
using System.Linq;

namespace leave_management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;   // Dependency Injection (1st step)
        }

        // Returning all (select * from table)
        public ICollection<LeaveHistory> FindAll()
        {
            return _db.LeaveHistories.ToList();
        }

        public LeaveHistory FindById(int id)
        {
            return _db.LeaveHistories.Find(id);
        }

        public bool Create(LeaveHistory entity)
        {
            _db.LeaveHistories.Add(entity);
            return Save();
        }

        public bool Update(LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);
            return Save();
        }

        public bool Save()
        {
            int changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Exists(int id)
        {
            return _db.LeaveHistories.Any(q => q.Id == id);
        }
    }
}