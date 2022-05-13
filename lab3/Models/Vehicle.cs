namespace lab3.Models
{
    public class Vehicle//交通工具
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Parked { get; set; }

        //Many-to-one with Pass, One-to-Many with Reservation
        public int PassId { get; set; }
        public Pass Pass { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public Vehicle()
        {
            Reservations = new List<Reservation>();
        }
    }
}
