using ACME.LearningCenterPlatform.API.IAM.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.IAM.Domain.Repositories;
using ACME.LearningCenterPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using ACME.LearningCenterPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ACME.LearningCenterPlatform.API.IAM.Infrastructure.Persistence.EFC.Repositories;

/**
 * The UserRepository class
 * <summary>
 * This class is responsible for handling the User entity in the database.
 * It implements the IUserRepository interface.
 * </summary>
 */
public class UserRepository(AppDbContext context) : BaseRepository<User>(context), IUserRepository
{
    /**
     * The FindByUsernameAsync method
     * <summary>
     * This method is responsible for finding a user by username.
     * </summary>
     * <param name="username">The username of the user to find.</param>
     * <returns>The user with the specified username.</returns>
     */
    public async Task<User?> FindByUsernameAsync(string username)
    {
        return await Context.Set<User>().FirstOrDefaultAsync(user => user.Username.Equals(username));
    }

    /**
     * The ExistsByUsername method
     * <summary>
     * This method is responsible for checking if a user with the specified username exists.
     * </summary>
     * <param name="username">The username of the user to check.</param>
     * <returns>True if a user with the specified username exists, otherwise false.</returns>
     */
    public bool ExistsByUsername(string username)
    {
        return Context.Set<User>().Any(user => user.Username.Equals(username));
    }
}