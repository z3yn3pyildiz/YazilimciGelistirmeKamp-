using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDao : IProductDao
    {
        List<Product> _products;
        public InMemoryProductDao()
        {
            this._products = new List<Product> {
            new Product{ProductId=2 ,CatagoryId=2,ProductName="BARDAK",UnitPrice=5,UnitsInStock=15} ,
            new Product{ProductId=4 ,CatagoryId=4,ProductName="KAMERA",UnitPrice=15,UnitsInStock=25},
            new Product{ProductId=6 ,CatagoryId=6,ProductName="bİLGİSAYAR",UnitPrice=25,UnitsInStock=35}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete;
            productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCatagory(int catagoryId)
        {
           return _products.Where(p => p.CatagoryId == catagoryId).ToList();
          
        }

        public void Update(Product product)
        {
            Product productToUpdate;
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CatagoryId = product.CatagoryId;
        }
    }
}
