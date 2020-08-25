namespace DAL.Model
{
    public class Animal
    {
        public Animal() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public int HousesId { get; set; }
        public House Houses { get; set; }
    }
}
