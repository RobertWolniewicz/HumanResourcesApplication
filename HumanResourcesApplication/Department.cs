using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesApplication
{
    public class Department : IHadId
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
