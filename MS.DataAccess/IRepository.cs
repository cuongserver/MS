using System;
using System.Linq;
using MS.DomainModel;
namespace MS.DataAccess
{
    public interface IRepository<TId, TEntity>
        where TId: struct
        where TEntity: class, IEntityId<TId>
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(TId id);
    }
}
