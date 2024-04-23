using Fornax.Application.Users.Queries;
using Fornax.Domain.Entities;
using Fornax.Domain.Interfaces;
using MediatR;

namespace Fornax.Application.Users.Handlers
{
    public class GetUserHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly IRepository _repository;

        public GetUserHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> Handle(GetUserByIdQuery query, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(query.Id);
        }
    }
}

