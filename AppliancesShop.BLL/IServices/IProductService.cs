using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliancesShop.BLL.IServices
{
    public interface IProductService
    {
        public ProductOutputModel AddProduct(ProductInputModel product);

        public List<ProductOutputModel> GetAllProducts();

        public ProductOutputModel GetProductById(int id);
    }
}
