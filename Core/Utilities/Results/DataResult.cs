using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        //result'dan inherit alıyoruz, IdataResulttan da implement alıyoruz.
        public DataResult(T data,bool success,string message):base(success,message)//baseye success ve messageyi yolla.burada tekrarlamamak için.
        {
            Data = data; 
        }
        public DataResult(T data,bool success):base(success)
        {
            Data = data; 
        }
        public T Data { get; }
    }
}
