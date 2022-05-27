using HospitalRevamped.Enums;

namespace HospitalRevamped.Models
{
    public class Doctor : Staff
    {
        public Doctor(string firstName, string lastName, Gender gender, Hospital hospital) : base(firstName, lastName, gender, hospital)
        {
            
        }

        public virtual List<Appointment>? Appointments { get; set; }

    }
}