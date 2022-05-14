using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyInterface.Models
{
    public class Executive : IEvaluatedEmployee
    { 
        public string Name { get; set; }
        public string Designation { get; set; }
        public int KPI { get; set; }


        public bool CheckEmployee()
        {
            //pretend that we are calling database here
            return false;
        }

      
    }
}
