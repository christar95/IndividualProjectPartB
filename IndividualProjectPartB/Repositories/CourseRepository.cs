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
    public class CourseRepository
    {
        public void Add(Course course)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(course).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public Course Get(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var course = db.Courses.Find(id);
                return course;
            }
        }

        public List<Course> GetAll()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Courses.ToList();
            }
        }

        public List<Course> GetAllWithStudents()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Courses.Include(x=>x.Students).ToList();
            }
        }

        public List<Course> GetAllWithTrainers()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Courses.Include(x=>x.Trainers).ToList();
            }
        }

        public List<Course> GetAllWithAssignments()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Courses.Include(x=>x.Assignments).ToList();
            }
        }

        public void Update(Course course)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var cou = db.Courses.Find(course.Id);
                if (cou != null)
                {

                    db.Entry(cou).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception($"Course with {course.Id} doesn't exist");
                }
            }
        }
    }
}
