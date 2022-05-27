using HospitalRevamped.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRevamped.Models
{
    public class Staff
    {
        public Staff(string firstName, string lastName, Gender gender, Hospital Hospital)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            
            this.Hospital = Hospital;
        }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual int id { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
