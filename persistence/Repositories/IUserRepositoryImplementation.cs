using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCaseRJ.application.contract.persistence;
using UseCaseRJ.domain.Entities;
using UseCaseRJ.application.contract.persistence;

namespace UseCaseRJ.persistence.Repositories
{
    public class IUserRepositoryImplementation : IUserRepository
    {
        private readonly UseCaseRJDbContext _useCaseRJDbContext;

        public IUserRepositoryImplementation(UseCaseRJDbContext useCaseRJDbContext)
        {
            this._useCaseRJDbContext = useCaseRJDbContext;
        }
        public async Task<bool> AddUserAsync(User user)
        {
            _useCaseRJDbContext.Users.Add(user);
            await _useCaseRJDbContext.SaveChangesAsync();
            return true;

        }

    }
}
