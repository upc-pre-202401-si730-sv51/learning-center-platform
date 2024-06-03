using ACME.LearningCenterPlatform.API.IAM.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.Shared.Domain.Repositories;

namespace ACME.LearningCenterPlatform.API.IAM.Domain.Repositories;

/**
 * The IUserRepository interface defines the contract for the User repository.
 */
public interface IUserRepository : IBaseRepository<User>
{
 /**
  * Find a user by username.
  * <param name="username"> The user name</param>
  * <returns>
  * The user if found, otherwise null.
  * </returns>
  */
 Task<User?> FindByUsernameAsync(string username);
 /**
  * Check if a user exists by username.
  * <param name="username"> The user name</param>
  * <returns>
  * True if the user exists, otherwise false.
  * </returns>
  */
 bool ExistsByUsername(string username);
    
}