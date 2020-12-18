using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompassSurvey.Data.EFCore
{
    public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
            where TEntity : class, IEntity
            where TContext : DbContext
    {
        internal readonly TContext context;
        public EfCoreRepository(TContext context)
        {
            this.context = context;

        }
        public async Task<TEntity> Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);

            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(int id)
        {
            //Extension class GetIncludePaths is added to do the eager loading so that it returns the nested objects
            var query = context.Set<TEntity>().Include(context.GetIncludePaths(typeof(TEntity)));
            return await query.FirstAsync(p => p.Id == id);

        }

        public async Task<List<TEntity>> GetAll()
        {
            //Extension class GetIncludePaths is added to do the eager loading so that it returns the nested objects
            var query = context.Set<TEntity>().Include(context.GetIncludePaths(typeof(TEntity)));
            return await query.ToListAsync();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }

    }
}
