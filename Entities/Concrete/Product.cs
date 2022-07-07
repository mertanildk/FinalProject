using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity//public bu classa diğer katmanlar da ulaşabilsin demek.
    {
        //internal demek sadece IEntity ulaşabilir demek
        //default oalrak gelir 


        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }//sort intin bir küçüğü 
        public decimal UnitPrice { get; set; }

    }
}
