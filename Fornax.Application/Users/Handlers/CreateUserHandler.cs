using Fornax.Application.Users.Commands;
using Fornax.Domain.Entities;
using Fornax.Domain.Interfaces;
using MediatR;

namespace Fornax.Application.Users.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, User>
    {
        private readonly IRepository _repository;

        public CreateUserHandler(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<User> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                NomeCompleto = command.NomeCompleto,
                Email = command.Email,
                Ativo = command.Ativo
            };

            return await _repository.AddAsync(user);
        }
    }
}

