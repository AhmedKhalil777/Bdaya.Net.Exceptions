using System;

namespace Bdaya.Net.Exceptions.IdentityExceptions
{
    public class RefreshTokenNotCompletedException : Exception
    {
        public RefreshTokenNotCompletedException(string message)
            : base(message)
        {

        }
    }
}
