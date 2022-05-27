using HospitalRevamped.Enums;

namespace HospitalRevamped.Models
{
    public class Receptionist : Staff
    {
        public Receptionist(string firstName, string lastName, Gender gender, Hospital hospital) : base(firstName, lastName, gender, hospital)
        {
        }

        public void CheckStatus(Patients patient)
        {
            if (patient.RegistrationStatus  is true)
            {

                Console.WriteLine("You Can see the Doctor");
            }
        }
    }
}