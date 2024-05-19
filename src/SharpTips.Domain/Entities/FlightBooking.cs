namespace SharpTips.Domain.Entities
{
    public class FlightBooking
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public DateTime DepartureTimeLocal { get; set; }
        public DateTime DepartureTimeUTC { get; set; }
        public string TimeZoneID { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
