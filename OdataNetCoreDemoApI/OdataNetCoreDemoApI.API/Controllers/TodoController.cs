using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using OdataNetCoreDemoApI.Model.Entities;
using OdataNetCoreDemoApI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdataNetCoreDemoApI.API.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    [ODataRoutePrefix("todos")]
    public class TodoController:ODataController
    {
        private ITodoManager _manager;

        public TodoController(ITodoManager manager)
        {
            _manager = manager;
        }


        //[HttpGet]
        //GET: api/contacts
        [EnableQuery]
        [ODataRoute]
        public IEnumerable<Todo> Get()
        {
            return _manager.GetTodos().AsQueryable();
        }
    }
}
