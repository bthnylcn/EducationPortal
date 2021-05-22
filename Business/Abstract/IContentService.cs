using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IContentService
    {
        IResult Add(Content content);
        IResult Delete(Content content);
        IResult Update(Content content);
        IDataResult<List<Content>> GetAll();
        IDataResult<List<Content>> GetById(int Id);
    }
}
