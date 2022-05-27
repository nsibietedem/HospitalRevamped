using FluentNHibernate.Mapping;
using HospitalRevamped.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRevamped.Maps
{
    public class HospitalMap:ClassMap<Hospital>
    {
        public HospitalMap()
        {
            Id(x => x.id);
            Map(x => x.HospitalAddress);
            Map(x => x.HospitalName);
            HasMany(x => x.Doctors).Cascade.All();


        }
    }
}
