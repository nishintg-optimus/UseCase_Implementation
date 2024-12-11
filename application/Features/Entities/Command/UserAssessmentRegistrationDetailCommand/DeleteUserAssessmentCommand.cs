using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UseCaseRJ.application.Features.Entities.Command.UserAssessmentRegistrationDetailCommand
{
    public class DeleteUserAssessmentCommand : IRequest<bool>
    {
        public int userid {get; set;}

    }
}
