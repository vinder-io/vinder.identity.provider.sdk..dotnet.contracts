namespace Vinder.IdentityProvider.Sdk.Contracts.Internal;

public class Result
{
    public bool IsSuccess { get; private set; }
    public bool IsFailure => !IsSuccess;

    public Error Error { get; private set; }

    protected Result(bool isSuccess, Error error)
    {
        IsSuccess = isSuccess;
        Error = error;
    }

    public static Result Success() => new(true, Error.None);
    public static Result Failure(Error error)
    {
        if (error == null || error == Error.None)
            throw new ArgumentException("Invalid error for failure.", nameof(error));

        return new Result(false, error);
    }
}