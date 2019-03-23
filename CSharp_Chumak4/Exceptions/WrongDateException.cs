using System;

namespace CSharp_Chumak4.Exceptions
{
    class WrongDateException: Exception
    {
        public WrongDateException(DateTime wrongDate)
        {
            WrongDate = wrongDate;
            Message = $"Received wrong Date: {wrongDate.ToShortDateString()}";
        }

        public DateTime WrongDate { get; }

        public override string Message { get; }
    }
}
