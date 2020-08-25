using DAL.Model;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IAnimalsRepository
    {
        IList<Animal> GetAllAnimals();
    }
}
