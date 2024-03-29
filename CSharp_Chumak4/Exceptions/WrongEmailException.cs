﻿using System;

namespace CSharp_Chumak4.Exceptions
{
    class WrongEmailException: Exception
    {
        public WrongEmailException(string wrongEmail)
        {
            WrongEmail = wrongEmail;
            Message = $"Received wrong Email: {WrongEmail}";
        }

        public string WrongEmail { get; }

        public override string Message { get; }
    }
}
