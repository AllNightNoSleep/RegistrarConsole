using System;
using System.Collections.Generic;

namespace RegistrarConsole
{
    public class Teacher : Person
    {
        public Specialization Specialization { get; set; }

        public Teacher()
        {
        }
    }
}