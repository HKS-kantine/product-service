using ProductEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLogic.Entities;

namespace ProductLogic
{
    public class Product
    {
        private readonly IProduct _ProductsDal = ProductFactory.ProductFactory.GetProducts();

        public List<ProductDTO> Read()
        {
            List<ProductDTO> productList = _ProductsDal.Read();
            return productList;
        }
        public ProductDTO Read(int id)
        {
            return _ProductsDal.Read(id);
        }

        public ProductDTO Update(ProductEntity product)
        {
            ProductDTO returnProduct = new ProductDTO();
            if (_ProductsDal.Update(product.ProductToProductDTO()))
            {
                returnProduct = this.Read(product.Id);
            }
            return returnProduct;
        }

        public ProductEntity Create(ProductEntity product)
        {
            ProductDTO returnProduct = new ProductDTO();
            returnProduct = _ProductsDal.Create(product.ProductToProductDTO());
            return new ProductEntity().ProductDTOToProduct(this.Read(returnProduct.Id));
        }
    }
}
