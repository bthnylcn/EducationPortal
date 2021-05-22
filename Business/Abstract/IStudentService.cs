using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStudentService
    {
        IResult Add(Student student);
        IResult Delete(Student student);
        IResult Update(Student student);
        IDataResult<List<Student>> GetAll();
        IDataResult<List<Student>> GetById(int Id);
        IDataResult<List<StudentDetailDto>> GetStudentDetails();
    }
}
