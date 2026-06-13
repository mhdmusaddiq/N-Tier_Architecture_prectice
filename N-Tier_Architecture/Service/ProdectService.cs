using N_Tier_Architecture.Model;
using N_Tier_Architecture.Repository;

namespace N_Tier_Architecture.Service
{
    public class ProdectService
    {
        ProductRepository repository;
        public ProdectService(IConfiguration configuration)
        {
            repository = new ProductRepository(configuration);
        }

        public List<Product> GetAllFromServices()
        {
            var products = repository.GetAllProdects();
            return products;
        }

    }
}
