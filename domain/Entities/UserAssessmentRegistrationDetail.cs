using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseRJ.domain.Entities
{
    public class UserAssessmentRegistrationDetail
    {
        public int id {  get; set; }
        public int assessmentidext { get; set; }

      //  public int invitedBy { get; set; }

      //  public int invitationstatus { get; set; }

        public DateTime invitedAt { get; set; }

        public DateTime RegisteredAt { get; set; }

        public DateTime Expiry { get; set; }

        public DateTime StartedAt { get; set; }

        public int userid { get; set; } //foreign key

        public User user { get; set; }
        



    }
}
