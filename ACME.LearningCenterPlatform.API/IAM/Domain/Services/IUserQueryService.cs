using ACME.LearningCenterPlatform.API.IAM.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.IAM.Domain.Model.Queries;

namespace ACME.LearningCenterPlatform.API.IAM.Domain.Services;

/**
 * Interface for User Query Service
 * <summary>
 * This interface defines the contract for the User Query Service
 * </summary>
 */
public interface IUserQueryService
{
    /**
     * Handle the GetUserById Query
     * <summary>
     * This method handles the GetUserById Query
     * </summary>
     * <param name="query">GetUserById Query</param>
     * <returns>Task - the user on success</returns>
     */
    Task<User?> Handle(GetUserByIdQuery query);
    /**
     * Handle the GetUserByUsername Query
     * <summary>
     * This method handles the GetUserByUsername Query
     * </summary>
     * <param name="query">GetUserByUsername Query</param>
     * <returns>Task - the user on success</returns>
     */
    Task<User?> Handle(GetUserByUsernameQuery query);
    /**
     * Handle the GetAllUsers Query
     * <summary>
     * This method handles the GetAllUsers Query
     * </summary>
     * <param name="query">GetAllUsers Query</param>
     * <returns>Task - the list of users on success</returns>
     */
    Task<IEnumerable<User>> Handle(GetAllUsersQuery query);
}