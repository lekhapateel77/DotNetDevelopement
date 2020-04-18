using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public interface IRestuarantData
    {
        IEnumerable<Restuarant> GetAll();

        Restuarant Get(int Id);
        void Add(Restuarant restuarant);
       // void Edit(Restuarant restuarant);

        void Update(Restuarant restuarant);

        void Delete(int Id);
    }

}
