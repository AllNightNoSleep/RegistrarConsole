using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistrarConsole
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Start Date"), DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [Display(Name = "Start Date"), DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Category")]
        public virtual Specialization Specialization { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
