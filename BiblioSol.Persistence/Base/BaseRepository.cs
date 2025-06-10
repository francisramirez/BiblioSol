

using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using BiblioSol.Application.Interfaces.Repositories;
using BiblioSol.Domain.Base;
using BiblioSol.Persistence.Context;

namespace BiblioSol.Persistence.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly HealtSyncContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public BaseRepository(HealtSyncContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public virtual async Task<OperationResult> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            OperationResult Opresult = new OperationResult();
            try
            {
                
                var entities = await _dbSet.Where(filter).ToListAsync();
                Opresult = OperationResult.Success($"Entity {typeof(TEntity)} retrieved successfully.", entities);

            }
            catch (Exception ex)
            {
                Opresult = OperationResult.Failure($"Error retrieving entity {typeof(TEntity)}  from the database.");

            }
            return Opresult;
        }
        public virtual async Task<OperationResult> GetByIdAsync(int id)
        {
            OperationResult Opresult = new OperationResult();
            try
            {

                var entity = await _dbSet.FindAsync(id);

                if (entity is null)
                {
                    Opresult = OperationResult.Failure($"the entity not found in the database.");
                    return Opresult;

                }
                Opresult = OperationResult.Success($"Entity {typeof(TEntity)} retrieved successfully.", entity);

            }
            catch (Exception ex)
            {
                Opresult = OperationResult.Failure($"Error retrieving entity {typeof(TEntity)}  from the database.");

            }
            return Opresult;
        }
        public virtual async Task<OperationResult> AddAsync(TEntity entity)
        {
            OperationResult Opresult = new OperationResult();
            try
            {
                _dbSet.Add(entity);
                await _context.SaveChangesAsync();
                Opresult = OperationResult.Success($"Entity {typeof(TEntity)} added successfully.", entity);
            }
            catch (Exception ex)
            {
                Opresult = OperationResult.Failure($"Error adding entity {typeof(TEntity)} to the database.");
            }
            return Opresult;
        }
        public virtual async Task<OperationResult> UpdateAsync(TEntity entity)
        {
            OperationResult Opresult = new OperationResult();
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
                Opresult = OperationResult.Success($"Entity {typeof(TEntity)} updated successfully.", entity);
            }
            catch (Exception ex)
            {
                Opresult = OperationResult.Failure($"Error updating entity {typeof(TEntity)} in the database.");
            }
            return Opresult;
        }
        public virtual async Task<OperationResult> DeleteAsync(TEntity entity)
        {
            OperationResult Opresult = new OperationResult();
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
                Opresult = OperationResult.Success($"Entity {typeof(TEntity)} updated successfully.", entity);
            }
            catch (Exception ex)
            {
                Opresult = OperationResult.Failure($"Error updating entity {typeof(TEntity)} in the database.");
            }
            return Opresult;
        }
        public virtual async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> filter)
        {
           return await _dbSet.AnyAsync(filter);
        }
    }

}
