using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVenta.DAL.Repositories.Contract;
using SistemaVenta.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SistemaVenta.DAL.Repositories;
public class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity : class
{
    private readonly DbsaleContext _dbContext;

    public GenericRepository(DbsaleContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
    {
        try 
        {
            TEntity entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(filter);
            return entity;
        }
        catch 
        {
            throw; 
        }
    }

    public async Task<TEntity> Create(TEntity entity)
    {
        try
        {
            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        catch
        {
            throw;
        }
    }

    public Task<bool> Edit(TEntity entity)
    {
        try
        {

        }
        catch
        {
            throw;
        }
    }

    public Task<bool> Delete(TEntity entity)
    {
        try
        {

        }
        catch
        {
            throw;
        }
    }

    public Task<IQueryable<TEntity>> Query(Expression<Func<TEntity, bool>> filter = null)
    {
        try
        {

        }
        catch
        {
            throw;
        }
    }
}
