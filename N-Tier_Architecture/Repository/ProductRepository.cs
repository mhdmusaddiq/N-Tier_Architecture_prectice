using Microsoft.Data.SqlClient;
using N_Tier_Architecture.Model;

namespace N_Tier_Architecture.Repository

{
    public class ProductRepository : IProductRepository
    {
        private readonly IConfiguration _configuration;
        public ProductRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //2.create a method

        public List<Product> GetAllProducts()
        {
            //3.Create emty list
            List<Product> ProductList = new List<Product>();

            //4. create data base connection

            string ConnectionString = _configuration.GetConnectionString("DefaultConnection");

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Produts";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Product newProduct = new Product
                    {
                        Id = Convert.ToInt32(reader["ID"]),
                        Name = reader["NAME"].ToString(),
                        Price = Convert.ToDecimal(reader["PRICE"]),
                        IsActive = Convert.ToBoolean(reader["ISACTIVE"])
                    };
                    ProductList.Add(newProduct);
                }
            }
            return ProductList;
        }

    }
}

