using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Group
    {
        public int Id { get; set; }
        public int Course { get; set; }
        public List<Student> Students { get; set; }
    }
}
