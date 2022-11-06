namespace DatabaseAppMockarooData.Models.Services
{
    /// <summary>
    /// Different functions that a typical CRUD app has to do.
    /// Defines the functions we want to happen.
    /// </summary>
    public interface IProductDataService
    {
        List<ProductModel> GetAllProducts(); // First item that I want to guarantee that happens
        List<ProductModel> SearchProducts(string searchTerm); // Returns a list of anything that matches the saerch term.
        ProductModel GetProductById(int id); // Get product by ID
        int Insert(ProductModel model); // INSERT
        int Delete(ProductModel model); // DELETE
        int Update(ProductModel model); // UPDATE
    }
}
