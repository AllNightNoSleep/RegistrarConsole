using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarConsole
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}"), DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
    }
}
