using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        IResult Add(Instructor instructor);
        IResult Delete(Instructor instructor);
        IResult Update(Instructor instructor);
        IDataResult<List<Instructor>> GetAll();
        IDataResult<List<Instructor>> GetById(int Id);
    }
}
