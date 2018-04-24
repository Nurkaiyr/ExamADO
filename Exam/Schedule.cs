using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public Group Group { get; set; }
        public Teachers Teacher { get; set; }
        public Subject Subject { get; set; }
    }
}