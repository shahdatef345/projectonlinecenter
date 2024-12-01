﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TeacherBook
    {
        public string TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }


    }
}
