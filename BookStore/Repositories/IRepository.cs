using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repositories
{
    public interface IRepository<TEntity>
    {
        List<TEntity> GetAll();
    }
}