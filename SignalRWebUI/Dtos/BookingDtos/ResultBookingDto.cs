namespace SignalRWebUI.Dtos.BookingDtos
{
    public class ResultBookingDto
    {
        public int BookingID { get; set; }
        public string BookingName { get; set; }
        public string BookingPhone { get; set; }
        public string BookingMail { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}
