using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Course> courses { get; set; } = new HashSet<Course>();
    }
}
