using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{ //BURAYA IEntity yazabilir miyiz ? çıplak class kalmasın dedik buraya ekleyebilir miyiz ?
    //bu bi veritabanı tablosu değil o yüzden IEntity Gelmemeli buraya *********IDto gelebilir***********
    //IDTO DA EVRENSELDİR.
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }






    }
}
