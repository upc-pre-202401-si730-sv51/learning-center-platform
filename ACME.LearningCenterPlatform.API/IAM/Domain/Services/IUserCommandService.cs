using ACME.LearningCenterPlatform.API.IAM.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.IAM.Domain.Model.Commands;

namespace ACME.LearningCenterPlatform.API.IAM.Domain.Services;

/**
 * Interface for User Command Service
 * <summary>
 * This interface defines the contract for the User Command Service
 * </summary>
 */
public interface IUserCommandService
{
    /**
     * Handle the SignUp Command
     * <summary>
     * This method handles the SignUp Command
     * </summary>
     * <param name="command">SignUp Command</param>
     * <returns>Task</returns>
     */
    Task Handle(SignUpCommand command);
    /**
     * Handle the SignIn Command
     * <summary>
     * This method handles the SignIn Command
     * </summary>
     * <param name="command">SignIn Command</param>
     * <returns>Task - the user and generated token on success</returns>
     */
    Task<(User user, string token )> Handle(SignInCommand command);
}