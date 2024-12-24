namespace Result_Pattern_WebAPI.Models.ResponseModel
{
    [System.ComponentModel.DisplayName("Result")]
    public class BaseResponse<T> : ResultModel
    {
        public T? Data { get; }

        public BaseResponse(bool isSuccess, ErrorModel error, T? data) : base(isSuccess, error)
        {
            Data = data;
        }
    }
}
