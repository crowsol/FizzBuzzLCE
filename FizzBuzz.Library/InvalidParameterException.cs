namespace FizzBuzz.Library
{
    using System;

    [Serializable]
    public class InvalidParameterException: Exception
    {
        public InvalidParameterException(string message):base(message)
        {            
        }
    }
}
