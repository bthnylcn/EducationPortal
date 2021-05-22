using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Student:IEntity
    {
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public Boolean CourseStatus { get; set; }
    }
}
