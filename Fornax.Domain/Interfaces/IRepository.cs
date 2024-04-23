using Fornax.Domain.Entities;

namespace Fornax.Domain.Interfaces
{
    public interface IRepository
	{
		Task<IEnumerable<User>> GetAsync();
        Task<User> GetByIdAsync(int Id);
        Task<User> AddAsync(User user);
		Task<int> UpdateAsync(User user);
		Task<int> DeleteAsync(int id);
	}
}

