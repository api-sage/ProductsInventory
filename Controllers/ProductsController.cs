using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductInventoryMgt.Model.Domain;
using ProductInventoryMgt.Model.DTO;
using ProductInventoryMgt.ProductDbContext;
using ProductInventoryMgt.Repo;
using System.Net.WebSockets;

namespace ProductInventoryMgt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProducts _Productsdb;
        public ProductsController(IProducts productsdb)
        {
            _Productsdb = productsdb;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            IEnumerable<Products> AllProducts = await _Productsdb.GetProductsAsync();
            return Ok(AllProducts);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetProductsAsync(Guid id)
        {
            Products OneProduct = await _Productsdb.GetProductAsync(id);
            return Ok(OneProduct);
        }

        [HttpPost]
        [Route("/newProduct")]
        public async Task<IActionResult> AddProductAsync(AddProduct newProduct)
        {
            Products NewProduct = new Products()
            {
                ProductName = newProduct.ProductName,
                QtyReceived = newProduct.QtyReceived,
                QtySold = newProduct.QtySold,
                Status = newProduct.Status,
            };

            var AddedProduct = await _Productsdb.AddProductAsync(NewProduct);
            return Ok(AddedProduct);
        }

        [HttpPut]
        [Route("id")]
        public async Task<IActionResult> UpdateProductAsync(Guid id, AddProduct updateProduct)
        {
            Products ExistingProduct = new Products()
            {
                ProductName = updateProduct.ProductName,
                QtyReceived = updateProduct.QtyReceived,
                QtySold = updateProduct.QtySold,
                Status = updateProduct.Status,
            };
            Products UpdatedProduct = await _Productsdb.UpdateProductAsync(id, ExistingProduct);
            return Ok(UpdatedProduct);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteProductAsync(Guid id)
        {
            Products DeletedProduct = await _Productsdb.DeleteProductAsync(id);
            return Ok(DeletedProduct);
        }
    }
}
