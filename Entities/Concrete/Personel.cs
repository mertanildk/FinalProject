using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Personel:IEntity
    {

        public int id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }


        //MAPPING YAPACAĞIZ.
        //DATABASEDE İSİMLENDİRMELERİN YANLIŞ OLDUĞUNU GENELLİKLE GÖRÜRÜZ.
        //DATABASE İLE KENDİ PROPERTYLERİMİZİN ADI NORMALDE AYNI OLMALI 
        //DATABASEDE İSİMLENDİRMELER SIKINTILI İSE CUSTOM MAPPİNG YAPARIZ...
    }
}
