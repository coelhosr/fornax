using Fornax.Application.Users.Queries;
using Fornax.Domain.Entities;
using Fornax.Domain.Interfaces;
using MediatR;

namespace Fornax.Application.Users.Handlers
{
    public class GetUsersHandler : IRequestHandler<GetUsersQuery, IEnumerable<User>>
    {
        private readonly IRepository _repository;

        public GetUsersHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAsync();
        }
    }
}

