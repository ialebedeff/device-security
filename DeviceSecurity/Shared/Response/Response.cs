using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceSecurity.Shared.Response
{
    public class Response<T> 
    {
        public Response(T data)
        {
            Data = data;
            IsSuccess = true;
        }
        public Response(string errorMessage)
        {
            ErrorMessage = errorMessage;
            IsSuccess = false;
        }
        public T? Data { get; set; }
        public string? ErrorMessage { get; set; }
        public bool IsSuccess { get; set; }
    }
}
