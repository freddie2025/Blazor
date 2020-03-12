using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IEnumerable<PersonModel> GetPeople()
        {
            return new List<PersonModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey", AccountBalance = 19.45M },
                new PersonModel { FirstName = "Mary", LastName = "Jones", AccountBalance = 105.87M },
                new PersonModel { FirstName = "John", LastName = "Smith", AccountBalance = 115.32M }
            };
        }

        [HttpPost]
        public void Post(PersonModel person)
        {

        }
    }
}