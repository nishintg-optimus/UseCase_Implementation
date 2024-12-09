using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UseCaseRJ.domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UseCaseRJ.domain.Entities;

namespace UseCaseRJ.persistence.configuration 
{
    public class UserAssessmentRegistrationDetailConfiguration : IEntityTypeConfiguration<UserAssessmentRegistrationDetail>
    {

        //it is an over riding method .......
        public void Configure(EntityTypeBuilder<UserAssessmentRegistrationDetail> builder)
        {

            builder.Property(ng => ng.assessmentidext).IsRequired();

            builder.HasKey(ng => ng.id);

            builder.Property(ng => ng.invitedAt).IsRequired();

            builder.Property(ng => ng.RegisteredAt).IsRequired();

            builder.Property(ng => ng.Expiry).IsRequired();

            builder.Property(ng => ng.StartedAt).IsRequired();

            builder.Property(ng => ng.userid).IsRequired();
            builder.Property(ng => ng.userid).IsRequired();

            builder.HasOne(ng => ng.user)
                .WithMany(ng => ng.userAssessmentRegistrationDetails)
                .HasForeignKey(ng => ng.userid);

        }

    }
}
