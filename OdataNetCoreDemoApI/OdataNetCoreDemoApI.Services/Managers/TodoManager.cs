using OdataNetCoreDemoApI.Model.Entities;
using OdataNetCoreDemoApI.Repository.Interface;
using OdataNetCoreDemoApI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdataNetCoreDemoApI.Services.Managers
{
    public class TodoManager : ITodoManager
    {
        private ITodoRepository _repo;

        public TodoManager(ITodoRepository repo)
        {
            _repo = repo;
        }
        public IEnumerable<Todo> GetTodos()
        {
            return _repo.GetTodos();
        }
    }
}
