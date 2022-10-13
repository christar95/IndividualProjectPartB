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
    public class StudentRepository
    {
        public void Add(Student student)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(student).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public Student Get(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var student = db.Students.Find(id);
                return student;
            }
        }

        public List<Student> GetAll()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Students.ToList();
            }
        }

        public List<Student> GetAllWithCourses()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Students.Include(x=>x.Courses).ToList();
            }
        }

        public List<Student> GetAllWithAssignments()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Students.Include(x=>x.Assignments).ToList();
            }
        }

        public void Update(Student student)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var stu = db.Students.Find(student.Id);
                if (stu != null)
                {

                    db.Entry(stu).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception($"Student with {student.Id} doesn't exist");
                }
            }
        }
    }
}
