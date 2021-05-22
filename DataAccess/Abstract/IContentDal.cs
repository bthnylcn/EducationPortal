using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IContentDal : IEntityRepository<Content>
    {
    }
}
