using OdataNetCoreDemoApI.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdataNetCoreDemoApI.Repository.Interface
{
    public interface ITodoRepository
    {
        IQueryable<Todo> GetTodos();
    }
}
