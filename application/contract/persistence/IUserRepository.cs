using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCaseRJ.application.Features.Entities.Command.UserCommand;
using UseCaseRJ.domain.Entities;

namespace UseCaseRJ.application.contract.persistence
{
    public interface IUserRepository 
    {
        Task<bool> AddUserAsync(User user);
        Task<bool> CreateAsync(CreateUserCommand command);
    }
}
