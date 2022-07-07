using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public void Add(Personel personel)
        {
            _personelDal.Add(personel);
        }

        public void Delete(Personel personel)
        {
            _personelDal.Delete(personel);
        }

        public Personel Get(int id)
        {
           Personel GetToPersonel = _personelDal.Get(p => p.id == id);
            return GetToPersonel;
        }

        public List<Personel> GetAll()
        {
           return _personelDal.GetAll();
        }

        public void Update(Personel personel)
        {
            _personelDal.Update(personel);
        }
    }
}
