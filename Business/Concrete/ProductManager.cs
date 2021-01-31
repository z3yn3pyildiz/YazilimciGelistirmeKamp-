using Business.Abstarct;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDao _productDao;
        public ProductManager(IProductDao productDao)
        {
            _productDao = productDao;
        }
        public List<Product> GetAll()
        {
            return _productDao.GetAll();
            
        }
    }
}
