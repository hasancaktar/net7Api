using net7Api.Business.Abstract;
using net7Api.Entity;

namespace net7Api.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private List<Customer> customers = new List<Customer>()
        {

            new Customer
            {
                Id = 1,
                Name = "Hasan",
                Surname = "Sancaktar",
                City = "İstanbul",
                BirthDate = DateTime.Now
            },
            new Customer
            {
                Id = 2,
                Name = "Ali",
                Surname = "Con",
                City = "Ankara",
                BirthDate = DateTime.Now
            },
            new Customer
            {
                Id = 3,
                Name = "Mehmet",
                Surname = "Sar",
                City = "İzmir",
                BirthDate = DateTime.Now
            }
        };
        public List<Customer> GetAll()
        {
            return customers.ToList();
        }

        public Customer GetById(int id)
        {
            var result = customers.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public void Update(int id, Customer customer)
        {
            var result = customers.Find(x => x.Id == id);
          //  result.Id = customer.Id;
            result.Name=customer.Name;
            result.Surname=customer.Surname;
            result.City=customer.City;
            result.BirthDate=customer.BirthDate;
        }

        public void Delete(int id)
        {
            var result = customers.Find(x => x.Id == id);
            customers.Remove(result);
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
