namespace ACME.LearningCenterPlatform.API.IAM.Domain.Model.Commands;

/**
 * Command to sign up a new user
 * <summary>
 *    The command is used to sign up a new user
 * </summary>
 * <param name="Username">The username of the user</param>
 * <param name="Password">The password of the user</param>
 * <returns>The sign up command</returns>
 */
public record SignUpCommand(string Username, string Password);