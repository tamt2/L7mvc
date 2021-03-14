﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Course
    {
        //tinfo200:[2021-03-13-tamt2-dykstra2] - data annotation, built-in helpers that affect the CourseID
        //tinfo200:[2021-03-13-tamt2-dykstra2] - dont generate a value for each record, according to data annotation
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
