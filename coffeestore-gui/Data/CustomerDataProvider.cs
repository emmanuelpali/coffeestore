using coffeestore_gui.Model;

namespace coffeestore_gui.Data
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }

    public class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllAsync()
        {
            await Task.Delay(100); // Simulate a bit of server work

            return new List<Customer>
              {
                new Customer{Id=1,FirstName="Yuvraj",LastName="Tanwar", IsRegular=true},
                new Customer{Id=2,FirstName="Ken",LastName="Okondo", IsRegular=false},
                new Customer{Id=3, FirstName="Babu",LastName="Kamra",IsRegular=true},
                new Customer{Id=4,FirstName="Anna",LastName="Johnes", IsRegular = false},
                new Customer{Id=5,FirstName="Giulia",LastName="Ger", IsRegular = false},
                new Customer{Id=6,FirstName="Amal",LastName="Mohammed", IsRegular = false}
              };
        }
    }
}
