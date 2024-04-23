using Fornax.Domain.Entities;
using MediatR;

namespace Fornax.Application.Users.Queries
{
    public class GetUsersQuery : IRequest<List<User>>
    {
		public GetUsersQuery() 
		{
		}
	}
}