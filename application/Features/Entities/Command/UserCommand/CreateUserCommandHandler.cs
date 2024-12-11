using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using UseCaseRJ.application.contract.persistence;

namespace UseCaseRJ.application.Features.Entities.Command.UserCommand
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand,bool>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
        public async Task<bool> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            var Result = await _userRepository.CreateAsync(command);
            return Result;
        }
    }
}
