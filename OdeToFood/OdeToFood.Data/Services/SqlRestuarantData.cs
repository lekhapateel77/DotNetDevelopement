using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class SqlRestuarantData : IRestuarantData
    {
        private readonly  OdeToFoodDbContext db;

        public SqlRestuarantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }
        public void Add(Restuarant restuarant)
        {
            db.Restuarants.Add(restuarant);
            db.SaveChanges();
        }
        public Restuarant Get(int Id)
        {
            return db.Restuarants.FirstOrDefault(r => r.Id == Id);
        }

        public IEnumerable<Restuarant> GetAll()
        {
            return from r in db.Restuarants
                   orderby r.Name
                   select r;

        }

        public void Update(Restuarant restuarant)
        {
            var entry = db.Entry(restuarant);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int Id)
        {
            var restuarant =db.Restuarants.Find(Id);
            db.Restuarants.Remove(restuarant);
            db.SaveChanges();

        }
    }
}
