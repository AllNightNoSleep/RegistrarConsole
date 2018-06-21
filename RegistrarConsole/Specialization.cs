using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarConsole
{
    public class Specialization
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    
    public class SpecializationSeeding
    {
        public static List<Specialization> specializationList ;
        Specialization specialization = new Specialization();
        public SpecializationSeeding()
        {
            specializationList = new List<Specialization>();
            Seed();
        }

        void Seed()
        {
            specializationList.Add(new Specialization { ID = 1, Name = "Technology"});
            specializationList.Add(new Specialization { ID = 2, Name = "Information" });
        }
    }
}
