namespace ProjektASP.Models
{
    public class rezerwacja
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual auta auta { get; set; }
        public virtual ApplicationUser User { get; set; }
    }

}
