using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;
        public ProductsController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns all products.
        /// </summary>
        /// <returns>All products</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        /// <summary>
        /// Return the product with the specific Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /products/{id}
        ///     http://localhost:5000/products/1
        ///
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>The product with the specific Id</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        /// <summary>
        /// Creates a product.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /products/new
        ///     http://localhost:5000/products/new
        ///
        ///     {
        ///         "name": "Apa",
        ///         "type": "Bauturi",
        ///         "weight": 1
        ///     }
        /// </remarks>
        /// <returns>200 OK or NOT OK</returns>
        [HttpPost("new")]
        public async Task<ActionResult<IEnumerable<Product>>> AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return Ok();
        }

        /// <summary>
        /// Updates a product.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /products/update/{id}
        ///     http://localhost:5000/products/update/1
        ///
        ///     {
        ///         "name": "Apa",
        ///         "type": "Bauturi",
        ///         "weight": 1
        ///     }
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>200 OK or NOT OK</returns>
        [HttpPut("update/{id}")]
        public async Task<ActionResult<IEnumerable<Product>>> UpdateProductFromQuery(int id, Product product)
        {
            var oldProduct = await _context.Products.FindAsync(id);
            var newProduct = new Product()
            {
                Id = oldProduct.Id,
                Name = product.Name,
                Type = product.Type,
                Weight = product.Weight
            };
            _context.Entry(oldProduct).CurrentValues.SetValues(newProduct);
            await _context.SaveChangesAsync();

            return Ok();
        }

        /// <summary>
        /// Updates a product.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /products/update/{id}
        ///     http://localhost:5000/products/update
        ///
        ///     {
        ///         "id": 1,
        ///         "name": "Apa",
        ///         "type": "Bauturi",
        ///         "weight": 1
        ///     }
        /// </remarks>
        /// <returns>200 OK or NOT OK</returns>
        [HttpPut("update")]
        public async Task<ActionResult<IEnumerable<Product>>> UpdateProductFromBody(Product product)
        {
            var oldProduct = await _context.Products.FindAsync(product.Id);

            _context.Entry(oldProduct).CurrentValues.SetValues(product);
            await _context.SaveChangesAsync();

            return Ok();
        }

        /// <summary>
        /// Deletes a product.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /products/delete/{id}
        ///     http://localhost:5000/products/delete/1
        ///
        /// </remarks>
        /// <returns>200 OK or NOT OK</returns>
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<IEnumerable<Product>>> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}