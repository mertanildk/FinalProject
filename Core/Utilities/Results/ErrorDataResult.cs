using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //ctor versiyonu veriyoruz.
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)//fazla kullanlmaz
        {

        }
        public ErrorDataResult() : base(default, false)//default verdik yani orda neyse o. //fazla kullanılmaz //alternatif kullanım 
        {

        }
    }

}
