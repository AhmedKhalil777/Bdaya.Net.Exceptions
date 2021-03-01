using System;

namespace Bdaya.Net.Exceptions.GeneralExceptions
{
    public class ItemNotFoundException<T>: Exception
    {
        public ItemNotFoundException(string id): base($"The item of id {id} of type {nameof(T)}")
        {
            
        }
    }
}