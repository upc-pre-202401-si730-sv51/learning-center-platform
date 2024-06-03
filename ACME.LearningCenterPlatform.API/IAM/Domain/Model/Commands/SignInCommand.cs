namespace ACME.LearningCenterPlatform.API.IAM.Domain.Model.Commands;

/**
 * Command to sign in a user
 * <summary>
 *    The command is used to sign in a user
 * </summary>
 * <param name="Username">The username of the user</param>
 * <param name="Password">The password of the user</param>
 * <returns>The sign in command</returns>
 */
public record SignInCommand(string Username, string Password);