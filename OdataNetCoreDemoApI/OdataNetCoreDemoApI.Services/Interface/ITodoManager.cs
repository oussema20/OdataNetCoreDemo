using OdataNetCoreDemoApI.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdataNetCoreDemoApI.Services.Interface
{
    public interface ITodoManager
    {
        IEnumerable<Todo> GetTodos();
    }
}
