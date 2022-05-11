using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyInterface.Models;

namespace WhyInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Initialise Employees
            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(new Executive() { Name = "Alex", Designation = "Programmer" }); 
            employees.Add(new Manager() { Name = "Bob", Designation = "Sales Manager" });
            employees.Add(new CSuite() { Name = "Daisy", Designation = "CFO" });
            #endregion

            #region Display Employees Info
            Console.WriteLine("-----Display Employee's Information-----");
            foreach (IEmployee employee in employees)
            {
                DisplayEmployeeInfo(employee);
            }
            Console.WriteLine();
            #endregion

            #region Review Employees KPI
            Console.WriteLine("-----Begin KPI Review-----");
            foreach (IEmployee employee in employees)
            {
                if (employee is Executive exec)
                {
                    EvaluateExecutiveByManager(exec);
                }


                if (employee is Manager cs)
                {
                    EvaluateManagerByCFO(cs);
                }
            }
            Console.WriteLine();
            #endregion

            #region Terminate Underperform Employee
            Console.WriteLine("-----Terminate Underperform Employee-----");
            bool terminated= false;
            foreach (IEmployee employee in employees)
            {
                if (employee is Executive exec && exec.KPI < 70)
                {
                    terminated = true;
                    TerminateExecutive(exec);
                }
                else if (employee is Manager m && m.KPI < 70)
                {
                    terminated = true;
                    TerminateManager(m);
                }

            }

            if (terminated == false)
            {
                Console.WriteLine("No one has been terminated");
            }
            #endregion

            Console.ReadLine();
        }







        static void DisplayEmployeeInfo(IEmployee employee)
        {
            Console.WriteLine($"{employee.Name} is a executive level employee, " +
                $"{employee.Name}'s role is a {employee.Designation}");
        }

      

        static void EvaluateExecutiveByManager(Executive e)
        {
            Console.Write($"Evaluate {e.Name} now.");
            Manager manager = new Manager();
            manager.EvaluateSubordinate(e);
            Console.WriteLine($"{e.Name} got {e.KPI} for KPI!"); 
        }

        static void EvaluateManagerByCFO(Manager m)
        {
            Console.Write($"Evaluate {m.Name} now. ");
            CSuite CFO = new CSuite();
            CFO.EvaluateSubordinate(m);
            Console.WriteLine($"{m.Name} got {m.KPI} for KPI!");
        }

        static void TerminateExecutive(Executive e)
        {
            CSuite cSuite = new CSuite();
            cSuite.TerminateExecutive(e);
            
        }

        static void TerminateManager(Manager mg)
        {
            CSuite cSuite = new CSuite();
            cSuite.TerminateManager(mg);

        }

    }
}
