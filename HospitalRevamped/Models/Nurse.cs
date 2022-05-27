using HospitalRevamped.Enums;

namespace HospitalRevamped.Models
{
    public class Nurse : Staff
    {
        public Nurse(string firstName, string lastName, Gender gender, Hospital Hospital) : base(firstName, lastName, gender, Hospital)
        {
        }
    }
}