namespace ACME.LearningCenterPlatform.API.IAM.Application.Internal.OutboundServices;

/**
 * Hashing service interface
 * <summary>
 *    This interface is used to hash and verify passwords
 * </summary>
 */
public interface IHashingService
{
    /**
     * Hashes the password
     * <param name="password">The password to hash</param>
     * <returns>The hashed password</returns>
     */
    string HashPassword(string password);
    /**
     * Verifies the password
     * <param name="password">The password to verify</param>
     * <param name="hashedPassword">The hashed password</param>
     * <returns>True if the password is verified to be equal to hashed password, otherwise false</returns>
     */
    bool VerifyPassword(string password, string hashedPassword);
}