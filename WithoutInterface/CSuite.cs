using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutInterface
{
    public class CSuite
    {
        public string Name { get; set; }
        public string Designation { get; set; }

        public int EvaluateSubordinate(Manager manager)
        {
            return 100;
        }

        public void TerminateEmpployee(Executive executive)
        {
        }

        public void TerminateEmpployee(Manager manager)
        {
        }
    }
}
