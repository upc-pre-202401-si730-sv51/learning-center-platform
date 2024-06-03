using System.Text.Json.Serialization;
using ACME.LearningCenterPlatform.API.IAM.Domain.Model.Commands;

namespace ACME.LearningCenterPlatform.API.IAM.Domain.Model.Aggregates;

/***
 * <summary>
 *    User aggregate root entity
 * </summary>
 * <remarks>
 *   This class is the aggregate root entity for the User aggregate
 * </remarks>
 */
public class User(string username, string passwordHash)
{
    public int Id { get; }

    public string Username { get; private set; } = username;
    
    [JsonIgnore] public string PasswordHash { get; private set; } = passwordHash;
    
    public User() : this(string.Empty, string.Empty)
    {
    }
    
    
    /***
     * <summary>
     *    Update the username of the user
     * </summary>
     * <param name="username">The new username</param>
     * <returns>The updated user</returns>
     */
    public User UpdateUsername(string username)
    {
        Username = username;
        return this;
    }
    
    /***
     * <summary>
     *    Update the password hash of the user
     * </summary>
     * <param name="passwordHash">The new password hash</param>
     * <returns>The updated user</returns>
     */
    public User UpdatePasswordHash(string passwordHash)
    {
        PasswordHash = passwordHash;
        return this;
    }
    
}