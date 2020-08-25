using BL.Model;
using System.Collections.Generic;

namespace BL.Interfaces
{
    public interface IAnimalsManager
    {
        IList<AnimalModel> GetAllAnimals();
    }
}
