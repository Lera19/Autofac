namespace BL.Model
{
    public class AnimalModel
    {
        public AnimalModel() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public int HousesId { get; set; }
        public HouseModel Houses { get; set; }
    }
}
