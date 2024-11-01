using FeiraTech.Exceptions.ExceptionsBase;

namespace FeiraTech.Exceptions.ExceptionsBase
{
    public class ErrorOnValidationException : FeiraTechExceptions
    {
        public IList<string> ErrorsMessages { get; set; }

        public ErrorOnValidationException(IList<string> errorsMessages) : base(string.Empty)
        {
            ErrorsMessages = errorsMessages;
        }

    }
}
