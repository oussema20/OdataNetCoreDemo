using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OdataNetCoreDemoApI.Model.Entities
{
    public class Todo
    {
        [Key]
        public Guid Id { get; set; }
        public string Label { get; set; }
        public string Details { get; set; }
    }
}
