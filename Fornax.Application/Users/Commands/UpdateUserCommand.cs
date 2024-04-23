using Fornax.Domain.Entities;
using MediatR;

namespace Fornax.Application.Users.Commands
{
    public class UpdateUserCommand : IRequest<int>
    {
        public int Id { get; set; }

        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public bool? Ativo { get; set; }

        public UpdateUserCommand(int id, string nomeCompleto, string email, bool ativo)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            Email = email;
            Ativo = ativo;
        }
    }
}

