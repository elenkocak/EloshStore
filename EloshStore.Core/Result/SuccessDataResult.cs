using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloshStore.Core.Result
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(Task<List<string>> data1, T data) : base(data, true)
        {
        }

        public SuccessDataResult(T data, string message, string messageCode) : base(true, message, messageCode, data)
        {
        }
    }
}
