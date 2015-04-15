using System;
using System.Web.Http;
using Hoebeke.Domain;

namespace Hoebeke.WebApi
{
    public class CustomerController : ApiController
    {
        [HttpGet]
        public Customer Get(string customerId)
        {
            return new Customer()
            {
                Id = Int32.Parse(customerId),
                Name = "john doe"
            };
        }
    }
}
