namespace PresentationLayer.Models
{
    public class AnimalViewModel
    {
        public AnimalViewModel() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public int HousesId { get; set; }
        public HouseViewModel Houses { get; set; }
    }
}
