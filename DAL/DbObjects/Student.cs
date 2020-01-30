using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DbObjects
{
    public class Student
    {
        public int Id { get; set; }

        public int Gender { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string UniqueName { get; set; }


        public ICollection<Group> Groups { get; set; }
    }
}
