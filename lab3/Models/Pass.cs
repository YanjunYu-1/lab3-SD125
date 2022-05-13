namespace lab3.Models
{
    public class Pass//通行证
    {
        public int Id { get; set; }
        public string Purchaser { get; set; }
        
        //One-to-many with Vehicle
        public ICollection<Vehicle> Vehicles { get; set; }
        public Pass(string purchaser)
        {
            Purchaser = purchaser;
            Vehicles = new HashSet<Vehicle>();
        }
    }
}
