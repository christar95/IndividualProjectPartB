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
    public class TrainerRepository
    {
        public void Add(Trainer trainer)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(trainer).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public Trainer Get(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var trainer = db.Trainers.Find(id);
                return trainer;
            }
        }

        public List<Trainer> GetAll()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Trainers.ToList();
            }
        }

        public List<Trainer> GetAllWithCourses()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Trainers.Include(x=>x.Courses).ToList();
            }
        }

        public void Update(Trainer trainer)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var tra = db.Trainers.Find(trainer.Id);
                if (tra != null)
                {

                    db.Entry(tra).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception($"Trainer with {trainer.Id} doesn't exist");
                }
            }
        }
    }
}
