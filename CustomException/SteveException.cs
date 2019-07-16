using System;

namespace CustomException
{
    public class SteveException: Exception
    {
        public SteveException(string msg) : base(msg)
        {

        }
    }
}
