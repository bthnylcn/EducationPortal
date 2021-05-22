using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }
        public IResult Add(Student student)
        {
            _studentDal.Add(student);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Student student)
        {
            _studentDal.Delete(student);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IResult Update(Student student)
        {
            _studentDal.Update(student);
            return new SuccessResult(Messages.CustomerUpdated);
        }

        public IDataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<List<Student>> GetById(int Id)
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll(c => c.StudentId == Id), Messages.CustomersListed);
        }

        public IDataResult<List<StudentDetailDto>> GetStudentDetails()
        {
            return new SuccessDataResult<List<StudentDetailDto>>(_studentDal.GetStudentDetails(), Messages.CustomersListed);
        }
    }
}
