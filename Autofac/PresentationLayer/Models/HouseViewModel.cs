using System.Collections.Generic;

namespace PresentationLayer.Models
{
    public class HouseViewModel
    {
        public HouseViewModel()
        {
            Animals = new List<AnimalViewModel>();
        }
        public int Id { get; set; }
        public int NumberHome { get; set; }
        public int AnimalId { get; set; }
        public List<AnimalViewModel> Animals { get; set; }
    }
}
