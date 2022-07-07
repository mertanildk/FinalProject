using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult //SADECE VOİDLER İÇİN BÖYLE.
    { //this(succes) iki parametre gönderen birisi için, this(success) demek git alttaki ctoru da çalıştır demek.
        //this(succes,message) deseydin tekrar aynı ctoru çalıştırırdı.sonsuz döngü gibi bişe olurdu
        public Result(bool success, string message):this(success)//set edilemeyen prop'lar ctor ile set edilebilir.
        {
            
            this.Message = message;
        }
        public Result(bool success)//set edilemeyen prop'lar ctor ile set edilebilir. OVERLOAD MESAJ VERMEK İSTEMİYORUZZZ
        {
            this.Success = success;
            
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
