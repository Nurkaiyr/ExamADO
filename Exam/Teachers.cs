using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Teachers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public string Occupation { get; set; }
        public List<Group> Groups { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
