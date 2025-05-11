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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _product;

        public ProductManager(IProductDal product)
        {
            _product = product;
        }

        public void TDelete(Product t)
        {
            _product.Delete(t);
        }

        public Product TGetByID(int id)
        {
            var values = _product.GetByID(id);
            return values;
        }

        public List<Product> TGetList()
        {
            var values = _product.GetList();
            return values;
        }

        public void TInsert(Product t)
        {
            _product.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _product.Update(t);
        }
    }
}
