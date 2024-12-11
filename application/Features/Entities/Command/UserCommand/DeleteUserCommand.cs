using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UseCaseRJ.application.Features.Entities.Command.UserCommand
{
    public class DeleteUserCommand : IRequest<bool>
    {
        public int userid;
    }
}
