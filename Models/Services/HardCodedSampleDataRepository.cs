using Bogus;

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
        List<ProductModel> productsList = new List<ProductModel>(); // Class member variable.

        public int Delete(ProductModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Service that generates a list of all the products.
        /// References the class member variable for a more globalised view.
        /// </summary>
        /// <returns></returns>
        public List<ProductModel> GetAllProducts()
        {
            if (productsList.Count == 0)
            {
                productsList.Add(new ProductModel { Id = 1, Name = "Mouse Pad", Price = 5.99m, Description = "A square piece of plastic to make mousing easier" });
                productsList.Add(new ProductModel { Id = 2, Name = "Web Cam", Price = 45.50m, Description = "Enables you attend more Zoom meetings" });
                productsList.Add(new ProductModel { Id = 3, Name = "4 TB USB hard drive", Price = 130.00m, Description = "Backup all of your work. You won't regret it." });
                productsList.Add(new ProductModel { Id = 4, Name = "Wireless Mouse", Price = 15.99m, Description = "Notebook mice don't work very well, do they?" });

                // Add some new items.
                // Take the products list and add an item to it to create a new Faker object.
                for (int i = 0; i < 100; i++)
                {
                    productsList.Add(new Faker<ProductModel>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                        .RuleFor(p => p.Description, f => f.Rant.Review())
                        );
                }
            }

            return productsList;
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
