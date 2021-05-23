using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public IResult Add(Course course)
        {
            _courseDal.Add(course);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CustomerUpdated);
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<List<Course>> GetById(int Id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.Id == Id), Messages.CustomersListed);
        }
    }
}
