using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public  class Response
    {
        public object Result { get; set; }
        public Exception Exception { get; set; }

        public T ParseResponse<T>()
        {
            if (this.Exception == null)
            {
                return (T)this.Result;
            }
            else
            {
                throw this.Exception;
            }
        }
    }
}
