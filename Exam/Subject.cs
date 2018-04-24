using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Teachers> Teachers { get; set; }
    }
}
