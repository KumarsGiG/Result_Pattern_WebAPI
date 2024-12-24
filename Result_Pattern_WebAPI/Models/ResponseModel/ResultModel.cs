namespace Result_Pattern_WebAPI.Models.ResponseModel
{
    [System.ComponentModel.DisplayName("Result")]
    public class ResultModel
    {
        public ResultModel(bool isSuccess, ErrorModel error)
        {
            IsSuccess = isSuccess;
            Error = error;
        }

        public bool IsSuccess { get; }
        public ErrorModel Error { get; }

        public static ResultModel Success() => new(true, ErrorModel.None);

        public static ResultModel Failure(ErrorModel error) => new(false, error);

        public static BaseResponse<T> Success<T>(T data) => new(true, ErrorModel.None, data);

        public static BaseResponse<T> Failure<T>(ErrorModel error) => new(false, error, default);
    }
}
