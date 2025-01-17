﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Teacher : Person
    {
        public virtual List<Subject> Subjects { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
