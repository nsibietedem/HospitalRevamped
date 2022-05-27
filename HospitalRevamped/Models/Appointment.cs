namespace HospitalRevamped.Models
{
    public class Appointment
    {
        public virtual int Id { get; set; }
        public virtual Patients Patients { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual DateTime AppointmentDate { get; set; }
    }
}