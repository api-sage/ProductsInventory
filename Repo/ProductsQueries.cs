using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Isam.Esent.Interop;
using ProductInventoryMgt.Model.Domain;
using ProductInventoryMgt.ProductDbContext;

namespace ProductInventoryMgt.Repo
{
    public class ProductsQueries : IProducts
    {
        private readonly ProductsDbContext _db;

        public ProductsQueries(ProductsDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Products>> GetProductsAsync()
        {
            List<Products> AllProducts = await _db.ProductsInventory.ToListAsync();
            return AllProducts;
        }

        public async Task<Products> GetProductAsync(Guid id)
        {
            return await _db.ProductsInventory.FindAsync(id);
        }

        public async Task<Products> AddProductAsync(Products newProduct)
        {
            newProduct.ProductId = Guid.NewGuid();
            await _db.ProductsInventory.AddAsync(newProduct);
            await _db.SaveChangesAsync();
            return await _db.ProductsInventory.FindAsync(newProduct.ProductId);
        }

        public async Task<Products> UpdateProductAsync(Guid id, Products updateEntries)
        {
            Products ProductToUpdate = await _db.ProductsInventory.FindAsync(id);

            ProductToUpdate.ProductName = updateEntries.ProductName;
            ProductToUpdate.QtyReceived = updateEntries.QtyReceived;
            ProductToUpdate.QtySold = updateEntries.QtySold;
            ProductToUpdate.Status = updateEntries.Status;

            await _db.SaveChangesAsync();

            return await _db.ProductsInventory.FindAsync(id);
        }

    }
}
