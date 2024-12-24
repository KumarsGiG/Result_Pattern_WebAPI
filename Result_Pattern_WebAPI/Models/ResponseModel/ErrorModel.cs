namespace Result_Pattern_WebAPI.Models.ResponseModel
{
    [System.ComponentModel.DisplayName("Error")]
    public class ErrorModel
    {
        public ErrorModel(string message) => Message = message;

        public string Message { get; }

        public static ErrorModel None => new(string.Empty);

        public static implicit operator ErrorModel(string message) => new(message);

        public static implicit operator string(ErrorModel error) => error.Message;
    }
}
