﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCL
{
    internal class Course
    {
        public long CourseID { get; set; }
        public long longInstitutionID  { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
