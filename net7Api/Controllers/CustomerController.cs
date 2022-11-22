
using Microsoft.AspNetCore.Mvc;
using net7Api.Business.Abstract;
using net7Api.Entity;

namespace net7Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
           var result =  _customerService.GetAll();
           if(result is null)
               return NotFound("Faild");
           return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _customerService.GetById(id);
            if (result is null)
                return NotFound("Faild");
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            _customerService.Add(customer);
            if (Response.StatusCode!=200)
                return NotFound("Faild");
            return Ok(_customerService.GetAll());
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Customer customer)
        {
            _customerService.Update(id, customer);
            return Ok(_customerService.GetAll());
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _customerService.Delete(id);
            return Ok(_customerService.GetAll());
        }
    }
}
