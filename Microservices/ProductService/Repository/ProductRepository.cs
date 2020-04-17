using ProductService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly AdventureWorks2017Context _context;

        public ProductRepository(AdventureWorks2017Context context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll() => _context.Product.ToList();

        public IEnumerable<ProductReview> GetAllReviews() => _context.ProductReview.ToList();
    }
}
