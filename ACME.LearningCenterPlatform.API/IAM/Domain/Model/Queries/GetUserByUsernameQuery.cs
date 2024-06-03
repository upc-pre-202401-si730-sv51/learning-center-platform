namespace ACME.LearningCenterPlatform.API.IAM.Domain.Model.Queries;

/** 
 * Query to get a user by its username.
 * <summary>
 * This query is used to get a user by its username.
 * </summary>
 * <param name="Username"> The username to search for</param>
 * <returns> The user with the given username</returns>
 * 
 */
public record GetUserByUsernameQuery(string Username);