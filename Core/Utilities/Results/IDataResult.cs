using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult//hangi tipi döndüreceğini söyle T 
    //Iresult veriyoruz çünkü Iresult'da mesaj var işlem sonucu var üzerine data ekleyecez tekrar etmiyoruz....
    //interface implemnt ettiğinde burada yazmasına gerek yok zaten vardır gözükmez.
    {
        T Data { get; }




    }
}
