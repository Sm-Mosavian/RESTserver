using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTserver.Models;

namespace RESTserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {


        private readonly CustomerContext context;

        public CustomerController(CustomerContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] IEnumerable<Models.Customer> customerList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Node new_node;
            foreach (Customer customer in customerList)
            {
                if (context.getIdList().Contains(customer.id))
                    return BadRequest("Error: Id " + customer.id + " has been used before");

                new_node = new Node(customer);
                context.sortedInsert(new_node);
            }

            return Ok(customerList);
        }

        [HttpGet]
        public IEnumerable<Models.Customer> Get()
        {
            return context.getCustomerList();
        }






    }
}
