using Business.Abstratc;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstratc;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal ProductDal;

        public IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
                return ErrorResult();
            return new DataResult<List<Product>>( _productDal.GetAll(),true,"Ürünler Listelendi");
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryID == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public IResult Add(Product product)
                        
        {
            if (product.ProductName.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);
            
            return new SuccessResult(Messages.ProductAdded);

        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p=>p.ProductID == productId);
        }
    }
}
