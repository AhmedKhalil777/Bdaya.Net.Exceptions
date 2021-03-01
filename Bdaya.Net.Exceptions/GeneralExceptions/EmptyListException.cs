using System;

namespace Bdaya.Net.Exceptions.GeneralExceptions
{
    public class EmptyListException<T> : Exception
    {
        public EmptyListException() : base($"The List of {typeof(T).Name} is empty you must provide entries")
        {

        }
    }
}
