using System.Collections.Generic;

namespace DAL.Model
{
    public class House
    {
        public House()
        {
            Animals = new List<Animal>();
        }
        public int Id { get; set; }
        public int NumberHome { get; set; }
        public int AnimalId { get; set; }
        public List<Animal> Animals { get; set; }
    }
}
