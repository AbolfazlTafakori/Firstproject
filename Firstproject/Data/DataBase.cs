using Firstproject.Models;

namespace Firstproject.Data
{
    public static class DataBase
    {
        public static List<Customer> Customer { get; set; } = new List<Customer>();
        public static List<Customer> GetAllCustomer()
        {
            if (Customer == null || Customer.Count == 0)
            {
                Customer =  new()
                {
                    new Customer() { Id = 1, UserName = "test", Email = "test@test.test" },
                    new Customer() { Id = 2, UserName = "temp", Email = "temp@temp.temp" }
                };
            }
            return Customer;
        }
    }
}
