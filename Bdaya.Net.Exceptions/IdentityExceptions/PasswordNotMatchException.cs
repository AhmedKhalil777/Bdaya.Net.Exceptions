using System;

namespace Bdaya.Net.Exceptions.IdentityExceptions
{
    public class PasswordNotMatchException : Exception
    {
        public PasswordNotMatchException(): base("password not match") { }
    }
}
