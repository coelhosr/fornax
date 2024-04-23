using Fornax.Application.Users.Commands;
using Fornax.Domain.Interfaces;
using MediatR;

namespace Fornax.Application.Users.Handlers
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, int>
    {
        private readonly IRepository _repository;

        public UpdateUserHandler(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
        {
            var user = await _repository.GetByIdAsync(command.Id);
            if (user == null)
                return default;

            user.Id = command.Id;
            user.NomeCompleto = command.NomeCompleto;
            user.Email = command.Email;
            user.Ativo = command.Ativo;

            return await _repository.UpdateAsync(user);
        }
    }
}

