using System;

namespace FutShowMe.WebAPI.DTO
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Success = true;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
    public class ResponseBase<T> : ResponseBase
    {
        public T Data { get; set; }
    }
}
