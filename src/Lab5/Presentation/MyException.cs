namespace Presentation;

public class MyException : Exception
{
    public MyException()
        : base("Error")
    {
    }

    public MyException(string message)
        : base(message)
    {
    }

    public MyException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}