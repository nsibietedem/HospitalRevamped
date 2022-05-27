using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRevamped.Models
{
    public class Hospital
    {

        public Hospital(string hospitalName, string hospitalAddress)
        {
            HospitalName = hospitalName;
            HospitalAddress = hospitalAddress;
            List<Doctor> DoctorsList = new List<Doctor>();
            //Receptionist Receptionist =new Receptionist();
        }

        public virtual string HospitalName { get; set; }
        public virtual string HospitalAddress { get; set; }
        public virtual int id { get; set; }
        public virtual Receptionist? Receptionist { get; set; }
        public virtual List<Doctor>? Doctors { get; set; }
        public virtual List<Nurse>? Nurses {get;set;}
        public virtual List<Pharmacists>? Pharmacist { get; set; }

        // public List<RegisteredPatients> RegisteredPatients { get; set; }
       // public List<Unregisteredpatients> Unregisteredpatients { get; set; }
    }
}
