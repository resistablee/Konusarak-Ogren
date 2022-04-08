using System.Linq.Expressions;

namespace KonusarakOgren.DataAccess.Abstract
{
    public interface IGenericRepository<TEntity>
    {
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllWithAsNoTrackingAsync();

        Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FindOneWithAsNoTrackingAsync(Expression<Func<TEntity, bool>> predicate);

        Task<IList<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate);

        Task DeleteAsync(int id);
        Task<TEntity> InsertAsync(TEntity entity);

        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
