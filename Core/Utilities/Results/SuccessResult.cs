using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message)//baseye yani resulta bir şey göndermek istiyoruz o yüzden base.
        {

        }
        public SuccessResult():base(true)//baseye tek parametreli olanı çalıştır dedik
        {

        }
    }
}
