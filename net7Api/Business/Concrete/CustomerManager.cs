using net7Api.Business.Abstract;
using net7Api.DataAccess.EntityFramework;
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

        private DataContext _dataContext;
        public CustomerManager(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Customer> GetAll()
        {
            var result = _dataContext.Customers.ToList();
            return result;
        }

        public Customer GetById(int id)
        {
            var result = _dataContext.Customers.Find(id);
            return result;
        }

        public void Update(int id, Customer customer)
        {
            var result = _dataContext.Customers.Find(id);
          //  result.Id = customer.Id;
            result.Name=customer.Name;
            result.Surname=customer.Surname;
            result.City=customer.City;
            result.BirthDate=customer.BirthDate;
            _dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var result = _dataContext.Customers.Find(id);
            _dataContext.Customers.Remove(result);
            _dataContext.SaveChanges();
        }

        public void Add(Customer customer)
        {

            _dataContext.Customers.Add(customer);
            _dataContext.SaveChanges(); 
        }
    }
}
