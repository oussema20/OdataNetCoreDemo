using OdataNetCoreDemoApI.Model.Entities;
using OdataNetCoreDemoApI.Repository.Data;
using OdataNetCoreDemoApI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdataNetCoreDemoApI.Repository.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private AppDbContext _context;

        public TodoRepository(AppDbContext context)
        {
            _context = context;
        }
        public IQueryable<Todo> GetTodos()
        {
            return _context.Todos.AsQueryable();
        }
    }
}
