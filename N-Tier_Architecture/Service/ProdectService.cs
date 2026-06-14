using N_Tier_Architecture.Model;
using N_Tier_Architecture.Repository;

namespace N_Tier_Architecture.Service
{
    public class ProdectService : IProductService
    {
        IProductRepository _repository;
        public ProdectService(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetAllFromServices()
        {
            var products = _repository.GetAllProducts();
            return products;
        }

    }
}
