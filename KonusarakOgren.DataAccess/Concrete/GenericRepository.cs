using KonusarakOgren.DataAccess.Abstract;
using KonusarakOgren.DataAccess.Context;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.DataAccess.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity.SqlLiteKonusarakOgren.Entities.Entity
    {
        private readonly KonusarakOgrenContext _context;
        private readonly DbSet<TEntity> _entities;

        public GenericRepository(KonusarakOgrenContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
            => await _entities.AnyAsync(predicate);

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
            => await _entities.CountAsync(predicate);

        public async Task DeleteAsync(int id)
        {
            var entity = await FindOneAsync(x => x.Id == id);

            if (entity == null)
                throw new ArgumentNullException("entity");

            entity.IsDeleted = true;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
        }

        public async Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> predicate)
            => await _entities.FirstOrDefaultAsync(predicate);

        public async Task<TEntity> FindOneWithAsNoTrackingAsync(Expression<Func<TEntity, bool>> predicate)
            => await _entities.AsNoTracking().FirstOrDefaultAsync(predicate);

        public async Task<IList<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate)
            => await _entities.Where(predicate).ToListAsync();

        public async Task<IList<TEntity>> FindAllWithAsNoTrackingAsync(Expression<Func<TEntity, bool>> predicate)
            => await _entities.AsNoTracking().Where(predicate).ToListAsync();

        public async Task<List<TEntity>> GetAllAsync()
            => await _entities.Where(x => !x.IsDeleted).ToListAsync();

        public async Task<List<TEntity>> GetAllWithAsNoTrackingAsync()
            => await _entities.AsNoTracking().Where(x => !x.IsDeleted).ToListAsync();

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }

            _context.Entry(entity).State = EntityState.Detached;

            return entity;
        }
    }
}
