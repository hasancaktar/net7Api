using net7Api.Entity;

namespace net7Api.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        bool Update(int id , Customer customer);
        void Delete(int id);
        void Add(Customer customer);
    }
}
