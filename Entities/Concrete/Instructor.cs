﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Instructor:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public String Information { get; set; }

    }
}
