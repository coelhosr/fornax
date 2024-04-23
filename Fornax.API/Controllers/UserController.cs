using Fornax.Application.Users.Commands;
using Fornax.Application.Users.Queries;
using Fornax.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fornax.API.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

		public UserController(IMediator mediator)
		{
            _mediator = mediator;
		}

        [HttpGet(Name = "GetUsers")]
        public async Task<IActionResult> Get()
        {
            var query = new GetUsersQuery();
            var users = await _mediator.Send(query);
            return Ok(users);
        }

        [HttpPost]
        public async Task<User> Add(User user)
        {
            var userAdd = await _mediator.Send(new CreateUserCommand(
                user.NomeCompleto, user.Email, user.Ativo.Value));
            return userAdd;
        }

        [HttpPut]
        public async Task<int> Update(User user)
        {
            var userUpdate = await _mediator.Send(new UpdateUserCommand(
                user.Id = user.Id,
                user.NomeCompleto, user.Email, user.Ativo.Value));
            return userUpdate;
        }

        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            return await _mediator.Send(new DeleteUserCommand(){ Id = id });
        }
    }
}

