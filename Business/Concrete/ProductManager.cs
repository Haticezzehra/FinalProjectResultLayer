using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal productDal;//DependencyInjection

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public IResult Add(Product product)
        {

            if(product.ProductName.Length<2)
            {
                return new ErrorResult("Ürün ismi min 2 karakter olmalıdır");
            }
            productDal.Add(product);

            return new SuccessResult("Ürün eklendi");
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }

        public List<Product> GetAll()
        {
            return productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return productDal.GetAll(p => p.CategoryId == id);
        }

        public Product GetById(int productId)
        {
            return productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return productDal.GetProductDetails();
        }

        
    }
}
