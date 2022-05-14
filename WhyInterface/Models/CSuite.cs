using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyInterface.Models
{


    

    public class CSuite :  IManagementLevelEmployee, ICSuite_Privilege
    {
        public string Name { get; set; }
        public string Designation { get; set; }

        public IEvaluatedEmployee EvaluateSubordinate(IEvaluatedEmployee Manager)
        {
            Random random = new Random();
            Manager.KPI = random.Next(60, 100);
            return Manager;
        }

        public bool TerminateEmployee(IEvaluatedEmployee evemp)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Employee {evemp.Name} with KPI {evemp.KPI} has been terminated because of KPI below 70");
            Console.ForegroundColor = ConsoleColor.White;
            return true;
        }

       
    }
}