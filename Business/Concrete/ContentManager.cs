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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;
        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }
        public IResult Add(Content content)
        {
            _contentDal.Add(content);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Content content)
        {
            _contentDal.Delete(content);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IResult Update(Content content)
        {
            _contentDal.Update(content);
            return new SuccessResult(Messages.CustomerUpdated);
        }

        public IDataResult<List<Content>> GetAll()
        {
            return new SuccessDataResult<List<Content>>(_contentDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<List<Content>> GetById(int Id)
        {
            return new SuccessDataResult<List<Content>>(_contentDal.GetAll(c => c.ContentId == Id), Messages.CustomersListed);
        }
    }
}
