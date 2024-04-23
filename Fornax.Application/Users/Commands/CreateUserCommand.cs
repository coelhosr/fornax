using Fornax.Domain.Entities;
using MediatR;

namespace Fornax.Application.Users.Commands
{
    public class CreateUserCommand : IRequest<User>
	{
        public string NomeCompleto { get; set; }

        public string Email { get; set; } 

        public bool? Ativo { get; set; }

        public CreateUserCommand(string nomeCompleto, string email, bool ativo)
		{
			NomeCompleto = nomeCompleto;
			Email = email;
			Ativo = ativo;
		}
	}
}

