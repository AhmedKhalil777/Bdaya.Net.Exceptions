using System;

namespace Bdaya.Net.Exceptions.IdentityExceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string userCredential)
            : base($"user with email or name {userCredential} is not found")
        {

        }
    }
}
