using System;

namespace Bdaya.Net.Exceptions.IdentityExceptions
{
    public class UserNotInRoleException : Exception
    {
        public UserNotInRoleException(string role)
            : base($"The User is not in role of {role}")
        {

        }
    }
}
