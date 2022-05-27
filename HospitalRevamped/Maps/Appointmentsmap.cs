using FluentNHibernate.Mapping;
using HospitalRevamped.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRevamped.Maps
{
    public class Appointmentsmap:ClassMap<Appointment>
    {
        public Appointmentsmap()
        {
            Id(x => x.Id);
            References(x => x.Patients);
            References(x => x.Doctor);
            Map(x => x.AppointmentDate);

        }
    }
}
