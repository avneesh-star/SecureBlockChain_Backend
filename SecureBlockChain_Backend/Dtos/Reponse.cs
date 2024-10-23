using Microsoft.CodeAnalysis.Differencing;

namespace SecureBlockChain_Backend.Dtos
{
    public class Response<T>
    {
        public Response(bool isSuccess, string message, T data)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }

        public Response(string message, bool isSuccess = false)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = default; // Default value for the type T
        }

        public Response(T data)
        {
            IsSuccess = true;
            Message = "success";
            Data = data;
        }

        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public static Response<T> Success(T data)
        {
            return new Response<T>(data);
        }

        public static Response<T> Failed(string message)
        {
            return new Response<T>(message);
        }
    }

}