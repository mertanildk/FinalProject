using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user,List<OperationClaim> operationClaims);//Token üretecek Mekanizmamız
        //api sistemimize kullanıcı adı ve şifresini gönderir.
        //Apide kullanıcı adı ve şifresi doğruysa CreateToken çalışacak.
        //İlgili kullanıcı için veritabanına gidecek, bu kullanıcının Claimlerini bulacak.
        //JWT üretecek onları da kullanıcıya döndürecek.

    }

}
