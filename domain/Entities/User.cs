using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseRJ.domain.Entities
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string name { get; set; }

        public string organisation { get; set; }

        public string phonenumber{ get; set; }

        public string city { get; set; }

        public string state{ get; set; }

        public string pincode { get; set; }

        public string streetline { get; set; }

        //  public int createdBy { get; set; }

        //navigation property

        public ICollection<UserAssessmentRegistrationDetail> userAssessmentRegistrationDetails { get; set; }


    }
}
