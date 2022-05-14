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

        public Manager EvaluateSubordinate(Manager manager)
        {
            Random random = new Random();
            manager.KPI = random.Next(60, 100);
            return manager;
        }

        public void TerminateExecutive(Executive executive)
        {
            Console.WriteLine($"Employee {executive.Name} with KPI {executive.KPI} has been terminated because of KPI below 70");
        }

        public void TerminateManager(Manager manager)
        {
            Console.WriteLine($"Employee {manager.Name} with KPI {manager.KPI} has been terminated because of KPI below 70");
        }
    }
}
