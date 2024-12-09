using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UseCaseRJ.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace UseCaseRJ.persistence.configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //builder.ToTable("User");

            builder.HasKey(ng=>ng.id);

            builder.Property(ng=>ng.email).IsRequired().HasMaxLength(100);

            builder.Property(ng => ng.name).IsRequired().HasMaxLength(50);

            builder.Property(ng => ng.phonenumber).IsRequired().HasMaxLength(15);

            builder.Property(ng => ng.city).IsRequired().HasMaxLength(20);

            builder.Property(ng => ng.state).IsRequired().HasMaxLength(20);

            builder.Property(ng => ng.pincode).IsRequired().HasMaxLength(20);

            builder.Property(ng => ng.streetline).IsRequired().HasMaxLength(20);

            //builder.HasMany(ng => ng.userAssessmentRegistrationDetails)
            //    .WithOne(ng => ng.user)
            //    .HasForeignKey(ng => ng.id);
        }
    }
}
