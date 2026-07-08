using System;

namespace Main.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Importance Importance { get; set; }

        
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = null!;
    }
}