using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyInterface.Models
{
    public class CSuite : IEmployee, IManagementLevelEmployee, ICSuite_Privilege
    {
        public string Name { get; set; }
        public string Designation { get; set; }

        public IEvaluatedEmployee EvaluateSubordinate(IEvaluatedEmployee Manager)
        {
            Random random = new Random();
            Manager.KPI = random.Next(60, 100);
            return Manager;
        }

        public void TerminateExecutive(Executive ex)
        {
            Console.WriteLine($"Employee {ex.Name} with KPI {ex.KPI} has been terminated because of KPI below 70");
        }

        public void TerminateManager(Manager mg)
        {
            Console.WriteLine($"Employee {mg.Name} with KPI {mg.KPI} has been terminated because of KPI below 70");
        }


    }
}
