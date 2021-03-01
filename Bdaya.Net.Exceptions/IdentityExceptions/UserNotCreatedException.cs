using System;

namespace Bdaya.Net.Exceptions.IdentityExceptions
{
    public class UserNotCreatedException : Exception
    {
        public UserNotCreatedException(string[] errors): base(string.Concat(errors))
        {

        }
    }
}
