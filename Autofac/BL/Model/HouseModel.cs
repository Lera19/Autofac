using System.Collections.Generic;

namespace BL.Model
{
    public class HouseModel
    {
        public HouseModel()
        {
            Animals = new List<AnimalModel>();
        }
        public int Id { get; set; }
        public int NumberHome { get; set; }
        public int AnimalId { get; set; }
        public List<AnimalModel> Animals { get; set; }
    }
}
