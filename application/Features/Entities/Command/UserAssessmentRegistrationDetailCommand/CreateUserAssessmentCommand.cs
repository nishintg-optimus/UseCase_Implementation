using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using UseCaseRJ.domain.Entities;

namespace UseCaseRJ.application.Features.Entities.Command.UserAssessmentRegistrationDetailCommand
{
    public class CreateUserAssessmentCommand : IRequest<bool>
    {
        //public int id { get; set; }
       
        public DateTime invitedAt { get; set; }

        public DateTime RegisteredAt { get; set; }

        public DateTime Expiry { get; set; }

        public DateTime StartedAt { get; set; }

        public int userid { get; set; }


    }
}
