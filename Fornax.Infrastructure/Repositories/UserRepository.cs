using Fornax.Domain.Entities;
using Fornax.Domain.Interfaces;
using Fornax.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Fornax.Infrastructure.Repositories
{
    public class UserRepository : IRepository
    {
        private readonly DbContextDB _dbContext;

        public UserRepository(DbContextDB dbContext) 
		{
            _dbContext = dbContext;
		}

        public async Task<User> AddAsync(User user)
        {
            var result = _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<IEnumerable<User>> GetAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<int> UpdateAsync(User user)
        {
            _dbContext.Users.Update(user);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var userData = _dbContext.Users.Where(x => x.Id == id).FirstOrDefault();
            _dbContext.Users.Remove(userData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<User> GetByIdAsync(int Id)
        {
            return await _dbContext.Users.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }
    }
}

