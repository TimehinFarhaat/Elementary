using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoEntites.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual List<Worker> Workers { get; set; } = new List<Worker>();
    }
}
