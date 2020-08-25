using DAL.Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL
{
    public class Initializer : CreateDatabaseIfNotExists<AnimalsContext>
    {
        protected override void Seed(AnimalsContext animalsContext)
        {

            var home1 = new House() { NumberHome = 1, Id = 1 };
            var home2 = new House() { NumberHome = 2, Id = 2 };


            var dataAnimal =
                new List<Animal>()
                {
                    new Animal() {Name = "Cat", Houses= home1, Id=1},
                    new Animal() {Name = "Dog", Houses = home1, Id=2},
                    new Animal() {Name = "Rabbit", Houses = home2, Id=3}
                };


            animalsContext.Houses.Add(home2);
            animalsContext.Houses.Add(home1);
            animalsContext.Animals.AddRange(dataAnimal);

            animalsContext.SaveChanges();

        }
    }
}
