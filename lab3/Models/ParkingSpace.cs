namespace lab3.Models
{
    public class ParkingSpace//停车位
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public bool Parked { get; set; }

        //One-To-Many with Reservation
        public ICollection<Reservation> Reservations { get; set; }
        public ParkingSpace()
        {
            Reservations = new HashSet<Reservation>();
        }
        public ParkingSpace(int num)
        {
            Number = num;
            Reservations = new HashSet<Reservation>();
        }
    }
}
