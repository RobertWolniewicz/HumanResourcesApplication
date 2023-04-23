using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesApplication
{
    public class Worker : IHadId
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comments { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime? DismissalDate { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }

    }
}
