﻿using App.Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace App.Core.Dal.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task<long> Count()
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().LongCountAsync();
            }

        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().SingleOrDefaultAsync(filter);
            }
        }

        public async Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, bool>>[] include)
        {
            using (var context = new TContext())
            {
                var query = context.Set<TEntity>();
                if (include != null)
                {
                    foreach (var item in include)
                    {
                        query.Include(item);
                    }
                }
                return filter == null ? await query.ToListAsync() : await query.Where(filter).ToListAsync();
            }
        }

        public async Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null, Expression<Func<TEntity, bool>> orderProperty = null, int pageNumber = 1, int pageSize = 10, bool isAscendingOrder = true, params Expression<Func<TEntity, bool>>[] include)
        {
            using (var context = new TContext())
            {
                var query = context.Set<TEntity>();
                if (include != null)
                {
                    foreach (var item in include)
                    {
                        query.Include(item);
                    }
                }
                if (filter != null)
                {
                    query.Where(filter);
                }

                if (orderProperty != null)
                {
                    if (isAscendingOrder)
                    {
                        query.OrderBy(orderProperty);
                    }
                    else
                    {
                        query.OrderByDescending(orderProperty);
                    }
                }

                return await query.Skip(pageNumber - 10 * pageSize).Take(pageSize).ToListAsync();
            }
        }

        public async Task Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

    }
}
