using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
        Personel Get(int id);
        void Add(Personel personel);    
        void Update(Personel personel);
        void Delete(Personel personel);
    }
}
