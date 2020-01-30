using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DbObjects
{
    public class Group
    {
        public int ID { get; set; }

        public string Name { get; set; }


        public ICollection<Student> Students { get; set; }
    }
}
