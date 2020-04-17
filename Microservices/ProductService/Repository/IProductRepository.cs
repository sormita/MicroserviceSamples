using ProductService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        IEnumerable<ProductReview> GetAllReviews();
    }
}
