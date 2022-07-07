using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
    //
    public interface IResult
    {
        bool Success { get; }//sadece okunabilir //sadece geti varsa ctorla setlersin sadece
        string Message { get; }

        //amaç kullanıcıya bir geribildirim vermek



    }
}
