using ProductInventoryMgt.Model.Domain;

namespace ProductInventoryMgt.Repo
{
    public interface IProducts
    {
        Task<IEnumerable<Products>> GetProductsAsync();
        Task<Products> GetProductAsync(Guid id);
        Task<Products> AddProductAsync(Products newproduct);
        Task<Products> UpdateProductAsync(Guid id, Products updateEntries);
    }
}
