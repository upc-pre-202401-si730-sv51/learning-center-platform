using ACME.LearningCenterPlatform.API.IAM.Application.Internal.OutboundServices;
using BCryptNet = BCrypt.Net.BCrypt;

namespace ACME.LearningCenterPlatform.API.IAM.Infrastructure.Hashing.BCrypt.Services;

/**
 * <summary>
 *  Hashing service using BCrypt algorithm.
 * </summary>
 */
public class HashingService : IHashingService
{
    /**
     * <summary>
     *  Hashes the password using BCrypt algorithm.
     * </summary>
     * <param name="password">The password to hash.</param>
     * <returns>The hashed password.</returns>
     */
    public string HashPassword(string password)
    {
        return BCryptNet.HashPassword(password);
    }

    /**
     * <summary>
     *  Verifies the password against the hashed password using BCrypt algorithm.
     * </summary>
     * <param name="password">The password to verify.</param>
     * <param name="hashedPassword">The hashed password to verify against.</param>
     * <returns>True if the password is verified, otherwise false.</returns>
     */
    public bool VerifyPassword(string password, string hashedPassword)
    {
        return BCryptNet.Verify(password, hashedPassword);
    }
}