using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public void Add(Product product)
        {
            this.productDal.Add(product);
        }

        public string Buy(Product product, User user, double demandQuantity)
        {
            string message = "";
            bool IsSuccess = false;
            if ((user.Balance >= product.UnitPrice * demandQuantity) && (demandQuantity <= product.UnitsInStock))
            { 
                this.productDal.BuyProduct(product, user);
                message = "Satın Alınma İşlemi Başarılı bir şekilde gerçekleşti";
                IsSuccess = true;
            }
            else if ((user.Balance >= product.UnitPrice * demandQuantity) && (demandQuantity !<= product.UnitsInStock))
            {
                message += " Yeterli miktarda ürün bulunmamaktadır.";
                IsSuccess = false;
            }
            else if ((user.Balance !>= product.UnitPrice * demandQuantity) && (demandQuantity <= product.UnitsInStock))
            {
                message += " Yetersiz Bakiye.";
                IsSuccess = false;
            }
            return message;   
        }

        public void Delete(Product product)
        {
            this.productDal.Delete(product);
        }

        public List<ProductDto> GetDetailsByCategoryId(List<Category> categories)
        {
            return this.productDal.GetDetailsByCategoryId(categories);
        }

        public List<Product> GetList()
        {
            return this.productDal.GetList();
        }

        public void Update(Product product)
        {
            this.productDal.Update(product);
        }
    }
}
