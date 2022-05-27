using FluentNHibernate.Mapping;
using HospitalRevamped.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRevamped.Maps
{
    public class DoctorsMap:ClassMap<Doctor>
    {
        public DoctorsMap()
        {
            Id(x => x.id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Gender);
            HasMany(x => x.Appointments);
            References(x => x.Hospital);
        }
    }
}
