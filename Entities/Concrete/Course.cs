using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Course:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public String Name { get; set; }
        public Decimal UnitPrice { get; set; }
        public int Quota { get; set; }
        public int Length { get; set; }
        public String Description { get; set; }
    }
}
