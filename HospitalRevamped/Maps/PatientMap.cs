using FluentNHibernate.Mapping;
using HospitalRevamped.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRevamped.Maps
{
    public class PatientMap:ClassMap<Patients>
    {
        public PatientMap()
        {
            Id(x => x.id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Gender);
            References(x => x.Hospital);

        }
    }
}
