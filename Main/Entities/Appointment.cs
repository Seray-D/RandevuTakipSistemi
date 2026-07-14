using Main.Enums;

namespace Main.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        
        public AppointmentStatus Status { get; set; } = AppointmentStatus.New;
    }
}