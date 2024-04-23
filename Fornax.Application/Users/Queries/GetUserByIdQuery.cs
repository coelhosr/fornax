using Fornax.Domain.Entities;
using MediatR;

namespace Fornax.Application.Users.Queries
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public int Id { get; set; }
    }
}

