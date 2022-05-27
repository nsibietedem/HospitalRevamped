using HospitalRevamped.Enums;

namespace HospitalRevamped.Models
{
    public class Patients
    {
        public Patients(string firstName, string lastName, Gender gender, Hospital hospital, bool registrationStatus)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Hospital = hospital;
            RegistrationStatus = registrationStatus;
        }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual int id { get; set; }
        public virtual Hospital Hospital { get; set; }
        public bool RegistrationStatus { get; internal set; }
    }
}