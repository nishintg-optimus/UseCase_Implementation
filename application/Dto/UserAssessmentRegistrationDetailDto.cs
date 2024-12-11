using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCaseRJ.domain.Entities;

namespace UseCaseRJ.application.Dto
{
    public class UserAssessmentRegistrationDetailDto
    {
        public int id { get; set;}
        public int assessmentidext { get; set;}

        public DateTime invitedAt { get; set;}

        public DateTime RegisteredAt {get; set;}

        public DateTime Expiry {get; set;}

        public DateTime StartedAt { get; set; }

        public int userid { get; set; }
    }
}
