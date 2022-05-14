using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
Executive executive = new Executive() { Name = "Alice", Designation = "Programmer"}; 
Manager manager = new Manager() { Name = "Bob", Designation = "Sales Manager"};
CSuite cSuite = new CSuite() { Name = "Daisy", Designation = "CFO" };



        }
    }
}
