using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //tinfo200:[2021-03-13-tamt2-dykstra2] - get input names and enrollment dates of students
        //tinfo200:[2021-03-13-tamt2-dykstra2] - entity framework will recognize naming convention of property
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //tinfo200:[2021-03-13-tamt2-dykstra2] - Enrollment is singular, Enrollments is plural
        //tinfo200:[2021-03-13-tamt2-dykstra2] - generate class Enrollment
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
