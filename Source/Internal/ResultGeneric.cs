namespace Vinder.IdentityProvider.Sdk.Contracts.Internal;

public class Result<TData>
{
    public bool IsSuccess { get; private set; }
    public bool IsFailure => !IsSuccess;

    public Error Error { get; private set; }
    public TData? Data { get; private set; }

    protected Result(bool isSuccess, TData? data, Error error)
    {
        IsSuccess = isSuccess;
        Error = error;
        Data = data;
    }

    public static Result<TData> Success(TData data) =>
        new(true, data, Error.None);

    public static Result<TData> Failure(Error error)
    {
        if (error == null || error == Error.None)
            throw new ArgumentException("Invalid error for failure.", nameof(error));

        return new Result<TData>(false, default, error);
    }
}