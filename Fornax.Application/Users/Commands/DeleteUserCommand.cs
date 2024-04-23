using MediatR;

namespace Fornax.Application.Users.Commands
{
    public class DeleteUserCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}

