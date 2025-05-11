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
    public class SaleManagementManager : ISaleManagementService
    {
        private readonly ISaleManagementDal _salesManagement;

        public SaleManagementManager(ISaleManagementDal salesManagement)
        {
            _salesManagement = salesManagement;
        }

        public void TDelete(SaleManagement t)
        {
            _salesManagement.Delete(t);
        }

        public SaleManagement TGetByID(int id)
        {
            var values = _salesManagement.GetByID(id);
            return values;
        }

        public List<SaleManagement> TGetList()
        {
            var values = _salesManagement.GetList();
            return values;
        }

        public void TInsert(SaleManagement t)
        {
            _salesManagement.Insert(t);
        }

        public void TUpdate(SaleManagement t)
        {
            _salesManagement.Update(t);
        }
    }
}
