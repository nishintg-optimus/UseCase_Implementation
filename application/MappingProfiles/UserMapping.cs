using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using UseCaseRJ.application.Features.Entities.Command.UserCommand;
using UseCaseRJ.domain.Entities;

namespace UseCaseRJ.application.MappingProfiles
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<CreateUserCommand, User>()
                .ForMember(b => b.name, ng => ng.MapFrom(a => a.name))
                                .ForMember(b => b.name, ng => ng.MapFrom(a => a.name))
                                .ForMember(b => b.email, ng => ng.MapFrom(a => a.email))
                                .ForMember(b => b.organisation, ng => ng.MapFrom(a => a.organisation))
                                .ForMember(b => b.phonenumber, ng => ng.MapFrom(a => a.phonenumber))
                                .ForMember(b => b.city, ng => ng.MapFrom(a => a.city))
                                .ForMember(b => b.state, ng => ng.MapFrom(a => a.state))
                                .ForMember(b => b.pincode, ng => ng.MapFrom(a => a.pincode))
                                .ForMember(b => b.streetline, ng => ng.MapFrom(a => a.streetline));

            CreateMap<UpdateUserCommand, User>()
                .ForMember(b => b.name, ng => ng.MapFrom(a => a.name))
                                .ForMember(b => b.name, ng => ng.MapFrom(a => a.name))
                                .ForMember(b => b.email, ng => ng.MapFrom(a => a.email))
                                .ForMember(b => b.organisation, ng => ng.MapFrom(a => a.organisation))
                                .ForMember(b => b.phonenumber, ng => ng.MapFrom(a => a.phonenumber))
                                .ForMember(b => b.city, ng => ng.MapFrom(a => a.city))
                                .ForMember(b => b.state, ng => ng.MapFrom(a => a.state))
                                .ForMember(b => b.pincode, ng => ng.MapFrom(a => a.pincode))
                                .ForMember(b => b.streetline, ng => ng.MapFrom(a => a.streetline));







        }

    }
}
