using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UseCaseRJ.application.Features.Entities.Command.UserAssessmentRegistrationDetailCommand
{
    public class UpdateUserAssessment : IRequest<bool>
    {
        public string email { get; set; }
        public string name { get; set; }
        public string organisation { get; set; }

        public string phonenumber { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string pincode { get; set; }

        public string streetline { get; set; }

    }
}
