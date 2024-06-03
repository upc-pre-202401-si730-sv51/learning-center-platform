namespace ACME.LearningCenterPlatform.API.IAM.Domain.Model.Queries;

/** 
 * Query to get a user by its identifier.
 * <summary>
 * This query is used to get a user by its identifier.
 * </summary>
 * <param name="UserId"> The ID to search for</param>
 * <returns> The user with the given ID</returns>
 * 
 */
public record GetUserByIdQuery(int UserId);