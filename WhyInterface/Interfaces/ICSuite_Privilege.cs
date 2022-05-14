using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyInterface.Models;

namespace WhyInterface
{
    public interface ICSuite_Privilege:IEmployee
    {
        bool TerminateEmployee(IEvaluatedEmployee executive);
        
    }
}