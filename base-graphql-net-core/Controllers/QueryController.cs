using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using base_graphql_net_core.Consumer;
using Microsoft.AspNetCore.Mvc;

namespace base_graphql_net_core.Controllers
{
    [Route("/user")]
    public class QueryController : Controller
    {
        private readonly UserConsumer _consumer;
        public QueryController(UserConsumer consumer)
        {
            _consumer = consumer;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _consumer.GetUsers();
            return Ok(users);
        }
    }
}
