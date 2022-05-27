using FluentNHibernate.Mapping;
using HospitalRevamped.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRevamped.Maps
{
    public class ReceptionistMap:ClassMap<Receptionist>
    {
        public ReceptionistMap()
        {
            Id(x => x.id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Gender);
            References(x => x.Hospital);

        }
    }
}
