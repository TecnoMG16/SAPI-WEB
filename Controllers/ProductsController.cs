using Microsoft.AspNetCore.Mvc;
using SILA_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace SILA_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>();

        // GET: /products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(products);
        }

        // POST: /products
        [HttpPost]
        public ActionResult<Product> AddProduct(Product product)
        {
            product.Id = products.Count + 1; // Asigna un ID simple
            products.Add(product);
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }

        // DELETE: /products/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            products.Remove(product);
            return NoContent();
        }
    }
}