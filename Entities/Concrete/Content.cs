﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Content:IEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public String FilePath { get; set; }
    }
}
