namespace lab3.Models
{
    public class Reservation//预定
    {
        public int Id { get; set; }
        public bool Current { get; set; }

        //Many-to-one with ParkingSpace, One-To-Many with Vehicle
        public int ParkingSpaceId { get; set; }
        public ParkingSpace ParkingSpace { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
