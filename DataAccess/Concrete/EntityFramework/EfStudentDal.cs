﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, EducationPortalContext>, IStudentDal
    {
        public List<StudentDetailDto> GetStudentDetails(Expression<Func<Student, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
