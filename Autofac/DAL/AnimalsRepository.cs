using DAL.Model;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DAL.Interfaces;

namespace DAL
{
    public class AnimalsRepository : IAnimalsRepository
    {
        public IList<Animal> GetAllAnimals()
        {
            using (var context = new AnimalsContext())
            {
                var result = context.Animals.Include(h => h.Houses).ToList();
                return result;
            }
        }
    }
}
