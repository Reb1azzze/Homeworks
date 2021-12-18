namespace hw9.Calculator
{
    public enum Answer
    {
        Success,
        Error
    }

    public class Result<TSuccess, TError>
    {
        public readonly Answer Type;
        public readonly TSuccess Success;
        public readonly TError Error;

        public Result(TSuccess success)
        {
            Type = Answer.Success;
            Success = success;
        }

        public Result(TError error)
        {
            Type = Answer.Error;
            Error = error;
        }
    }
}