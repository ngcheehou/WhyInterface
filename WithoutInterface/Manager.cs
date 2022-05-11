using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutInterface
{
    public class Manager
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public int KPI { get; set; }

        public int EvaluateSubordinate(Executive executive)
        {
            Random random = new Random();
            return random.Next(60, 100);
        }
    }
}
