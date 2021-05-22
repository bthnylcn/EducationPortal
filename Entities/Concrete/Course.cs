using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Course:IEntity
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public String CourseName { get; set; }
        public Decimal UnitPrice { get; set; }
        public int CourseQuota { get; set; }
        public int CourseLength { get; set; }
        public String Description { get; set; }
    }
}
