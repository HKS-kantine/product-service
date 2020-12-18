using ProductEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductData.Controllers
{
    public class ProductController : IProduct
    {
        private readonly CollectionAdminContext db = new CollectionAdminContext();
        public ProductDTO Create(ProductDTO product)
        {
            if (product != null)
            {
                db.Product.Add(product);
                db.SaveChanges();
                return product;
            }
            return null;
        }

        public bool Delete(ProductDTO company)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> Read()
        {
            List<ProductDTO> products = db.Product.ToList();
            return products;
        }

        public ProductDTO Read(int id)
        {
            ProductDTO products = db.Product.Where(b => b.Id == id).FirstOrDefault();
            return products;
        }

        public bool Update(ProductDTO product)
        {
            ProductDTO result = db.Product.SingleOrDefault(o => o.Id == product.Id);
            if (result != null)
            {
                result.Name = product.Name;
                result.Price = product.Price;
                result.Image = product.Image;

                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
