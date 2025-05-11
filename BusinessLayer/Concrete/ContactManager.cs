using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contact;

        public ContactManager(IContactDal contact)
        {
            _contact = contact;
        }

        public void TDelete(Contact t)
        {
            _contact.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            var values = _contact.GetByID(id);
            return values;
        }

        public List<Contact> TGetList()
        {
            var values = _contact.GetList();
            return values;
        }

        public void TInsert(Contact t)
        {
            _contact.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            _contact.Update(t);
        }
    }
}
