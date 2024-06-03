using ACME.LearningCenterPlatform.API.IAM.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.IAM.Domain.Model.Queries;
using ACME.LearningCenterPlatform.API.IAM.Domain.Repositories;
using ACME.LearningCenterPlatform.API.IAM.Domain.Services;

namespace ACME.LearningCenterPlatform.API.IAM.Application.Internal.QueryServices;

/**
 * User query service.
 * <summary>
 *    This class is responsible for handling user queries.
 * </summary>
 */
public class UserQueryService(IUserRepository userRepository) : IUserQueryService
{
    /**
     * Get user by id.
     * <summary>
     *   This method is responsible for getting a user by id.
     * </summary>
     * <param name="query">Get user by id query.</param>
     * <returns>User.</returns>
     */
    public async Task<User?> Handle(GetUserByIdQuery query)
    {
        return await userRepository.FindByIdAsync(query.UserId);
    }

    /**
     * Get user by username.
     * <summary>
     *   This method is responsible for getting a user by username.
     * </summary>
     * <param name="query">Get user by username query.</param>
     * <returns>User.</returns>
     */
    public async Task<User?> Handle(GetUserByUsernameQuery query)
    {
        return await userRepository.FindByUsernameAsync(query.Username);
    }

    /**
     * Get all users.
     * <summary>
     *   This method is responsible for getting all users.
     * </summary>
     * <param name="query">Get all users query.</param>
     * <returns>Users.</returns>
     */
    public async Task<IEnumerable<User>> Handle(GetAllUsersQuery query)
    {
        return await userRepository.ListAsync();
    }
}