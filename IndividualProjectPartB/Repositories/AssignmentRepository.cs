using IndividualProjectPartB.Entities;
using IndividualProjectPartB.MyDatabase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Repositories
{
    public class AssignmentRepository
    {
        public void Add(Assignment assignment)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(assignment).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public Assignment Get(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var assignment = db.Assignments.Find(id);
                return assignment;
            }
        }

        public List<Assignment> GetAll()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Assignments.ToList();
            }
        }

        public List<Assignment> GetAllWithCourses()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Assignments.Include(x=>x.Course).ToList();
            }
        }

        public List<Assignment> GetAllWithStudents()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Assignments.Include(x=>x.Students).ToList();
            }
        }

        public void Update(Assignment assignment)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var ass = db.Assignments.Find(assignment.Id);
                if (ass != null)
                {

                    db.Entry(ass).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception($"Assignment with {assignment.Id} doesn't exist");
                }
            }
        }
    }
}
