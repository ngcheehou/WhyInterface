using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyInterface.Models
{
    public class Executive : IEmployee, IEvaluatedEmployee
    { 
        public string Name { get; set; }
        public string Designation { get; set; }
        public int KPI { get; set; }
    }
}
