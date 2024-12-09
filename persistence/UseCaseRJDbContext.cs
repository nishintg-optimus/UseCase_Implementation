using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UseCaseRJ.domain.Entities;

namespace UseCaseRJ.persistence
{
    public class UseCaseRJDbContext : DbContext
    {
        public UseCaseRJDbContext(DbContextOptions<UseCaseRJDbContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserAssessmentRegistrationDetail> UserAssessmentRegistrationDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //apply the configurations
            modelBuilder.ApplyConfiguration(new configuration.UserConfiguration());
            modelBuilder.ApplyConfiguration(new configuration.UserAssessmentRegistrationDetailConfiguration());

        }
    }
}
