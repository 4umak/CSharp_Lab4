﻿using System;

namespace CSharp_Chumak4.Exceptions
{
    class WrongSurnameException : Exception
    {
        public WrongSurnameException(string wrongSurname)
        {
            WrongSurname = wrongSurname;
            Message = $"Received wrong surname: {wrongSurname}";
        }

        public string WrongSurname { get; }

        public override string Message { get; }
    }
}
