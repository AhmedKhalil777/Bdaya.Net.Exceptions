using System;

namespace Bdaya.Net.Exceptions.IdentityExceptions
{
    public class RoleNotAddedException: Exception
    {
        public RoleNotAddedException(string[] errors) : base(string.Concat(errors))
        {

        }
    }
}
