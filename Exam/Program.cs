using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new UniversityContext())
            {
                Schedule schedule = new Schedule
                {
                    Id = 1,
                    Time = new DateTime(2018, 04, 24, 10, 57, 52),
                    Group = context.Groups.FirstOrDefault(),
                    Teacher = context.Teachers.FirstOrDefault(),
                    Subject = context.Subjects.FirstOrDefault()
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
        }
    }
}
