using Business.Abstract;
using Business.Constants;
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

            if (product.ProductName.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(productDal.GetAll(),"Ürünler Listelendi");
        }

       

        public IDataResult<Product> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Product>> IProductService.GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }
    }
    }

      
        
