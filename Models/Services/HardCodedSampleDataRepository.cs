namespace DatabaseAppMockarooData.Models.Services
{
    /// <summary>
    /// Hard coded as it it's not going to come from any database.
    /// Sample data tells us we have fake data.
    /// Data repository usually has those functions that are in the interface.
    /// The : makes it part of an interface. Uses IProductDataService as the item.
    /// 'Implement interface' implements all the fucntions that were in the interface.
    /// </summary>
    public class HardCodedSampleDataRepository : IProductDataService
    {
        public int Delete(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
