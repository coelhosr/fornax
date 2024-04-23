using Fornax.Application.Users.Commands;
using Fornax.Domain.Interfaces;
using MediatR;

namespace Fornax.Application.Users.Handlers
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, int>
    {
        private readonly IRepository _repository;

        public DeleteUserHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(DeleteUserCommand command, CancellationToken cancellationToken)
        {
            var user = await _repository.GetByIdAsync(command.Id);
            if (user == null)
                return default;

            return await _repository.DeleteAsync(user.Id);
        }
    }
}

