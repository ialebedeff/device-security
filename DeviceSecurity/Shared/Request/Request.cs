using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceSecurity.Shared.Request
{
    public class Request<T>
    {
        public Request(T data)
        {
            Data = data;
        }

        public T Data { get; set; } = default(T)!;
    }
}
