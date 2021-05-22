using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Instructor:IEntity
    {
        public int InstructorId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public String InstructorInformation { get; set; }

    }
}
